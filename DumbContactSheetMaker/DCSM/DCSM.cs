using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace DumbContactSheetMaker
{
    class DCSM
    {
        public static void RunFromCommandLine(string[] args)
        {
            var settings = new Settings();
            var recursive = false;
            var path = "";
            for(var i = 0; i < args.Length; i++)
            {
                var arg = args[i];
                switch (arg)
                {
                    case "--output":
                    case "-o":
                        if (args.Length > i + 1)
                        {
                            var val = args[++i];
                            switch (val)
                            {
                                case "i":
                                    settings.Output = Settings.OutputLocation.ImageFolder;
                                    break;
                                case "r":
                                    settings.Output = Settings.OutputLocation.RootFolder;
                                    break;
                                default:
                                    settings.Output = Settings.OutputLocation.Folder;
                                    settings.OutputPath= val;
                                    break;
                            }
                        }
                        break;
                    case "--recursive":
                    case "-r":
                        recursive = true;
                        break;
                    case "--width":
                    case "-w":
                        if (args.Length > i+1)
                        {
                            settings.sheetWidth = Convert.ToInt32(args[++i]);
                        }
                        break;
                    case "--height":
                    case "-h":
                        if (args.Length > i+1)
                        {
                            settings.thumbHeight= Convert.ToInt32(args[++i]);
                        }
                        break;
                    case "--max-num":
                    case "-mn":
                        if (args.Length > i+1)
                        {
                            settings.useMaxNumThunbs = true;
                            settings.maxNumThumbs= Convert.ToInt32(args[++i]);
                        }
                        break;
                    case "--large-first":
                    case "-lf":
                        settings.largeFirst = true;
                        break;
                    case "--cover":
                    case "-c":
                        if (args.Length > i+1)
                        {
                            settings.cover = true;
                            settings.coverPath= args[++i];
                        }
                        break;
                    case "--cover-first":
                    case "-cf":
                        settings.coverFirst = true;
                        break;
                    case "--title":
                    case "-t":
                        settings.title = true;
                        break;
                    case "--title-text":
                    case "-tt":
                        if (args.Length > i+1)
                        {
                            settings.titleCustom = true;
                            settings.titleText= args[++i];
                        }
                        break;
                    case "--background":
                    case "-bg":
                        if (args.Length > i+1 && args[++i].Length == 8)
                        {
                            settings.titleBgColor = Color.FromArgb(
                                Convert.ToInt32(args[i].Substring(6, 2), 16),
                                Convert.ToInt32(args[i].Substring(0, 2), 16),
                                Convert.ToInt32(args[i].Substring(2, 2), 16),
                                Convert.ToInt32(args[i].Substring(4, 2), 16)
                                );
                        }
                        break;
                    case "--font":
                    case "-f":
                        if (args.Length > i + 1)
                        {
                            settings.titleFont = new Font(args[++i], settings.titleFont.Size, settings.titleFont.Style);
                        }
                        break;
                    case "--font-color":
                    case "-fc":
                        if (args.Length > i + 1 && args[++i].Length == 8)
                        {
                            settings.titleFontColor = Color.FromArgb(
                                Convert.ToInt32(args[i].Substring(6, 2), 16),
                                Convert.ToInt32(args[i].Substring(0, 2), 16),
                                Convert.ToInt32(args[i].Substring(2, 2), 16),
                                Convert.ToInt32(args[i].Substring(4, 2), 16)
                                );
                        }
                        break;
                    case "--font-size":
                    case "-fs":
                        if (args.Length > i + 1)
                        {
                            settings.titleFont = new Font(settings.titleFont.SystemFontName, Convert.ToInt32(args[++i]), settings.titleFont.Style);
                        }
                        break;
                    case "--font-style":
                    case "-fst":
                        if (args.Length > i + 1)
                        {
                            var styles = args[++i];
                            settings.titleFont = new Font(
                                settings.titleFont.SystemFontName,
                                settings.titleFont.Size,
                                settings.titleFont.Style | (styles.Contains("b") ? FontStyle.Bold : 0) | (styles.Contains("i") ? FontStyle.Italic : 0)
                                );
                        }
                        break;
                    default:
                        path = args[i];
                        break;

                }
            }

            if (!string.IsNullOrWhiteSpace(path))
            {
                var maker = new DCSM(settings);
                if (recursive)
                {
                    maker.createSheetsRecursive(path);
                }
                else
                {
                    maker.createSheet(path);
                }
            }
        }




        Settings settings;
		bool aborting = false;
        string[] extensions = new string[] { ".jpg", ".tiff", ".bmp", ".png", ".gif" };

        public DCSM(Settings settings)
        {
            this.settings = settings;
            StatusEvent.statusPrefix = "";
        }


        public event EventHandler<StatusEvent> StatusChanged;
        protected virtual void OnStatusChanged(StatusEvent e)
        {
            EventHandler<StatusEvent> handler = StatusChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        public class StatusEvent : EventArgs
        {
            public static string statusPrefix = "";
            public int step;
            public int stepMax;
            public string status;
        }


        public void createSheetsRecursive(string path)
        {
			aborting = false;
            Thread thread = new Thread(() => doCreateSheetsRecursive(path, path));
            thread.Start();
		}
        public void doCreateSheetsRecursive(string path, string root)
        {
            DirectoryInfo[] dirs = new DirectoryInfo(path).GetDirectories();
            if (dirs.Length > 0)
            {
                foreach (DirectoryInfo di in new DirectoryInfo(path).GetDirectories())
                {
					if (aborting)
					{
						OnStatusChanged(new StatusEvent() { step = 1, stepMax = 1, status = "done" });
						return;
					}
                    doCreateSheetsRecursive(di.FullName, root);
                }
            }
            else
            {
                StatusEvent.statusPrefix = "[" + new DirectoryInfo(path).Name + "] ";
                doCreateSheet(path, root);
            }
            
        }
        
        public void createSheet(string path)
		{
			aborting = false;
			createSheet(path, path);
		}
		public void createSheet(string path, string root)
        {
            Thread thread = new Thread(() => doCreateSheet(path, root));
            thread.Start();
		}

		public void doCreateSheet(string path)
		{
			doCreateSheet(path, path);
		}
        public void doCreateSheet(string path, string root)
        {
            OnStatusChanged(new StatusEvent() { step = 0, stepMax = 100, status = "getting images" });
            var files = new DirectoryInfo(path).GetFiles().Where(file => extensions.Contains(file.Extension.ToLower())).ToArray<FileInfo>();

			if (files.Length == 0)
			{
				OnStatusChanged(new StatusEvent() { step = 1, stepMax = 1, status = "done" });
				return;
			}

            if (settings.useMaxNumThunbs && files.Length > settings.maxNumThumbs)
            {
                int nStep = (int)Math.Floor((decimal)files.Length / (decimal)settings.maxNumThumbs);
                files = files.Where((x, i) => i % nStep == 0).Take(settings.maxNumThumbs).ToArray();
            }
            ImageInfo[] images = files.Select(file => new ImageInfo(file)).ToArray<ImageInfo>();

            if (settings.cover)
            {
                if (settings.coverFirst)
                {
                    images = new ImageInfo[] { new ImageInfo(settings.coverPath) }.Concat(images).ToArray<ImageInfo>();
                }
                else
                {
                    images = images.Concat(new ImageInfo[] { new ImageInfo(settings.coverPath) }).ToArray<ImageInfo>();
                }
            }
            OnStatusChanged(new StatusEvent() { step = 0, stepMax = images.Length, status = "calculating size" });

            List<Row> rows = MakeRows(images);

            int titleHeight = 0;
            string titleText = "";
            if (settings.titleCustom)
            {
                titleText = settings.titleText;
            }
            else
            {
                titleText = new DirectoryInfo(path).Name;
            }
            if (settings.title)
            {
                titleHeight = TextRenderer.MeasureText(titleText, settings.titleFont, new Size(settings.sheetWidth-10, 0), TextFormatFlags.WordBreak).Height+10;
            }

            Bitmap sheet = new Bitmap(settings.sheetWidth, titleHeight + rows.Select(row => row.GetHeight(settings.sheetWidth, settings.thumbHeight)).Sum());
            
            Rectangle destRect;
            int top = titleHeight;
            int step = 0;

            using (Graphics graphics = Graphics.FromImage(sheet))
            {
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                using (ImageAttributes wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    if (settings.title)
                    {
                        OnStatusChanged(new StatusEvent() { step = 0, stepMax = images.Length, status = "adding title" });
                        graphics.FillRectangle(new SolidBrush(settings.titleBgColor), 0, 0, settings.sheetWidth, titleHeight);
                        graphics.DrawString(titleText, settings.titleFont, new SolidBrush(settings.titleFontColor), 5, 5);
                    }
                    graphics.CompositingMode = CompositingMode.SourceCopy;
                    foreach (Row row in rows)
                    {
						if (aborting)
						{
							OnStatusChanged(new StatusEvent() { step = 1, stepMax = 1, status = "done" });
							return;
						}
						int left = 0;
                        int height = row.GetHeight(settings.sheetWidth, settings.thumbHeight);
                        foreach (ImageInfo image in row.images)
                        {
                            OnStatusChanged(new StatusEvent() { step = step++, stepMax = images.Length, status = "adding images" });
                            destRect = new Rectangle(left, top, (int)Math.Ceiling((decimal)image.Width * height / image.Height), height);
                            left += (int)Math.Ceiling((decimal)image.Width * height / image.Height);
                            using (Image img = Image.FromFile(image.FullName))
                            {
                                img.RotateFlip(image.Rotate);
                                graphics.DrawImage(img, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                            }
                        }
                        top += height;
                    }
                }
			}

			string outputPath;
			switch (settings.Output)
			{
				case Settings.OutputLocation.Folder:
					outputPath = settings.OutputPath;
					break;
				case Settings.OutputLocation.RootFolder:
					outputPath = root;
					break;
				default:
					outputPath = path;
					break;
			}
			OnStatusChanged(new StatusEvent() { step = step, stepMax = images.Length, status = "saving file" });
            int fileNameCount = 0;
            while (File.Exists(outputPath + @"\_" + titleText + (fileNameCount==0?"":("_"+fileNameCount)) + @".jpg"))
			{
				if (aborting)
				{
					OnStatusChanged(new StatusEvent() { step = 1, stepMax = 1, status = "done" });
					return;
				}
				fileNameCount++;
            }

            sheet.Save(
				outputPath + @"\_" + titleText + (fileNameCount == 0 ? "" : ("_" + fileNameCount)) + @".jpg",
                ImageCodecInfo.GetImageDecoders().First(c => c.FormatID == ImageFormat.Jpeg.Guid),
                new EncoderParameters() {  Param = new[] { new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 90L)}}
                );

            // cleanup
            sheet.Dispose();

            OnStatusChanged(new StatusEvent() { step = 1, stepMax = 1, status = "done" });
        }

        protected List<Row> MakeRows(ImageInfo[] images)
        {
            List<Row> rows = new List<Row>();
            List<ImageInfo> row = null;
            int rowW = settings.sheetWidth;
            foreach (ImageInfo image in images)
            {
                if (rowW >= settings.sheetWidth || (settings.largeFirst && rows.Count == 1))
                {
                    row = new List<ImageInfo>();
                    rows.Add(new Row(row));
                    rowW = 0;
                }
                row.Add(image);
                rowW += image.Width * settings.thumbHeight / image.Height;
            }
            return rows;
        }



		public void Abort()
		{
			aborting = true;
		}
    }
}
