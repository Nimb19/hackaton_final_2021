using AccentureClient.Kernel.ImplementationModels;
using System.Collections.Generic;
using System.Drawing;

namespace AccentureClient.Kernel
{
    public static class GeneratorImageColorPalette
    {
        public static Dictionary<ScaledRGB, int> GetImageColor(Bitmap bitmap
            , IRawMaterial materialParameters, int step = 5, int scale = 16)
        {
            var colors = new Dictionary<ScaledRGB, int>(ScaledRGB.CreateComparerInstance);

            for (var x = 0; x < bitmap.Width; x += step)
            {
                for (var y = 0; y < bitmap.Height; y += step)
                {
                    var thisColor = new ScaledRGB(bitmap.GetPixel(x, y), scale);

                    if (colors.TryGetValue(thisColor, out var value))
                        colors[thisColor] = value + 1;
                    else
                        colors.Add(thisColor, 1);
                }
            }

            return colors;
        }
    }
}
