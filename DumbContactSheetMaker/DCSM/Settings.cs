using System.Drawing;

namespace DumbContactSheetMaker
{
    class Settings
    {
		// output
		public OutputLocation Output;
		public string OutputPath;
		
        // size
        public int sheetWidth;
        public int thumbHeight;
        public bool useMaxNumThunbs;
        public int maxNumThumbs;
        public bool largeFirst;

        // cover
        public bool cover;
        public bool coverFirst;
        public string coverPath;

        // title
        public bool title;
        public bool titleCustom;
        public string titleText;
        public Color titleBgColor;
        public Font titleFont;
        public Color titleFontColor;




        public Settings()
        {

        }




		public enum OutputLocation { ImageFolder, RootFolder, Folder }
    }
}
