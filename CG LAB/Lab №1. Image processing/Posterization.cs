using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab__1.Image_processing
{
    class Posterization : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
        Color sourceColor = sourceImage.GetPixel(x, y);
        const int val = 6;
        Color resultColor = Color.FromArgb(((sourceColor.R >> val) << val) + 32, ((sourceColor.G >> val) << val) + 32, ((sourceColor.B >> val) << val) + 32);
        sourceImage.SetPixel(x, y, resultColor);
        return resultColor;
    }
}
}
