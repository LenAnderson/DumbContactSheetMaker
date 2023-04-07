using System.Drawing;
using System.Linq;

namespace DumbContactSheetMaker
{
    class Settings
    {
		// output
		public OutputLocation Output = OutputLocation.RootFolder;
		public string OutputPath;
		
        // size
        public int sheetWidth = 900;
        public int thumbHeight = 200;
        public bool useMaxNumThunbs = false;
        public int maxNumThumbs;
        public bool largeFirst = false;

        // cover
        public bool cover = false;
        public bool coverFirst = false;
        public string coverPath;

        // title
        public bool title = false;
        public bool titleCustom = false;
        public string titleText;
        public Color titleBgColor = Color.Black;
        public Font titleFont = SystemFonts.DefaultFont;
        public Color titleFontColor = Color.White;




        public Settings()
        {
            
        }




		public enum OutputLocation { ImageFolder, RootFolder, Folder }
    }
}
