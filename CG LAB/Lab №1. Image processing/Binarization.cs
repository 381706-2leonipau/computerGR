using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab__1.Image_processing
{
    class Binarization : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            if (sourceColor.B + sourceColor.G + sourceColor.R > 325)
                sourceColor = Color.FromArgb(255, 255, 255);
            else
                sourceColor = Color.FromArgb(0, 0, 0);
            sourceImage.SetPixel(x, y, sourceColor);

            return sourceColor;
        }
    }
}
