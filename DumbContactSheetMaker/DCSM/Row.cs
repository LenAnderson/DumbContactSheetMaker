using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace DumbContactSheetMaker
{
    internal class Row
    {
        public List<ImageInfo> images;

        public Row(List<ImageInfo> images)
        {
            this.images = images;
        }

        public int GetHeight(int sheetWidth, int thumbHeight)
        {
            int width = images.Select(image => (int)Math.Ceiling((decimal)image.Width* thumbHeight / image.Height)).Sum();
            return (int)Math.Ceiling((decimal)thumbHeight * sheetWidth / width);
        }
    }
}