using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab__1.Image_processing
{
    class BlackWhite : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            int color = (sourceColor.R + sourceColor.G + sourceColor.B) / 3;
            Color resultColor = Color.FromArgb(color, color, color);
            sourceImage.SetPixel(x, y, resultColor);
            return resultColor;
        }
    }
}
