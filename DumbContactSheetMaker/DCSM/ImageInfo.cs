using System;
using System.Drawing;
using System.IO;

namespace DumbContactSheetMaker
{
	class ImageInfo
	{
		public int Height;
		public int Width;
		public string Name;
		public string FullName;
		public RotateFlipType Rotate = RotateFlipType.RotateNoneFlipNone;


		public ImageInfo(string path) : this(new FileInfo(path)) { }

		public ImageInfo(FileInfo file)
		{
			using (FileStream fs = new FileStream(file.FullName, FileMode.Open, FileAccess.Read))
			{
				using (Image image = Image.FromStream(stream: fs, useEmbeddedColorManagement: false, validateImageData: false))
				{
					if (Array.IndexOf(image.PropertyIdList, 274) > -1)
					{
						switch ((int)image.GetPropertyItem(274).Value[0])
						{
							case 1:
								Rotate = RotateFlipType.RotateNoneFlipNone;
								break;
							case 2:
								Rotate = RotateFlipType.RotateNoneFlipX;
								break;
							case 3:
								Rotate = RotateFlipType.Rotate180FlipNone;
								break;
							case 4:
								Rotate = RotateFlipType.Rotate180FlipX;
								break;
							case 5:
								Rotate = RotateFlipType.Rotate90FlipX;
								break;
							case 6:
								Rotate = RotateFlipType.Rotate90FlipNone;
								break;
							case 7:
								Rotate = RotateFlipType.Rotate270FlipX;
								break;
							case 8:
								Rotate = RotateFlipType.Rotate270FlipNone;
								break;
						}
						image.RotateFlip(Rotate);
					}
					Height = image.Height;
					Width = image.Width;
				}
			}

			Name = file.Name;
			FullName = file.FullName;
		}
	}
}
