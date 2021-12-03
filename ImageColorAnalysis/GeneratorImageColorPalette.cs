using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace ImageColorAnalysis
{
    public static class GeneratorImageColorPalette
    {
        public static Dictionary<RGB, int> GetImageColor(Bitmap bitmap, int step = 5, int scale = 4)
        {
            var colors = new Dictionary<RGB, int>(new RGB(Color.White, scale));

            for (var x = 0; x < bitmap.Width; x += step)
            {
                for (var y = 0; y < bitmap.Height; y += step)
                {
                    var thisColor = new RGB(bitmap.GetPixel(x, y), scale);

                    if (colors.TryGetValue(thisColor, out var value))
                        colors[thisColor] = value + 1;
                    else
                        colors.Add(thisColor, 1);
                }
            }

            return colors;
        }
    }

    public struct RGB : IEqualityComparer<RGB>
    {
        public double Similarity { get; }
        public int ScaleSize { get; }

        public double R { get; set; }
        public double G { get; set; }
        public double B { get; set; }

        public RGB(Color color, int scale)
        {
            ScaleSize = scale;
            R = Math.Round(((double)color.R / 256) * ScaleSize);
            G = Math.Round(((double)color.G / 256) * ScaleSize);
            B = Math.Round(((double)color.B / 256) * ScaleSize);
            Similarity = color.R * 1.5 + color.G + color.B;
        }

        public new bool Equals(object x, object y)
        {
            if (x is RGB xrgb)
            {
                if (y is RGB yrgb)
                    return xrgb.R == yrgb.R && xrgb.G == yrgb.G && xrgb.B == yrgb.B;
                else
                    return false;
            }
            else if (y is RGB)
                return false;
            else
                return x == y;
        }

        private double FormatFunction(double rorgorb)
            => Math.Round((rorgorb / ScaleSize) * 256);

        public int GetHashCode(object obj)
        {
            if (obj is RGB rgb)
                return Convert.ToInt32((rgb.R * -5) + (rgb.G * 32) + (rgb.B * 16));
            else
                return obj.GetHashCode();
        }

        public override string ToString()
        {
            return $"R={FormatFunction(R)};G={FormatFunction(G)};B={FormatFunction(B)}";
        }

        public bool Equals(RGB x, RGB y)
        {
            return Equals(x as object, y as object);
        }

        public int GetHashCode(RGB obj)
        {
            return GetHashCode(obj as object);
        }
    }
}

//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Linq;
//using System.Threading.Tasks;

//namespace ImageColorAnalysis
//{
//    public class GeneratorImageColorPalette
//    {
//        public static Dictionary<RGB, int> GetImageColor(Bitmap bitmap, int step = 1, int threadCount = 32)
//        {
//            var obj = new object();
//            var colors = new Dictionary<RGB, int>();
//            var widthForThread = bitmap.Width / threadCount;

//            var tasks = new Task[threadCount];
//            for (int i = 0; i < threadCount; i++)
//            {
//                var startIndex = widthForThread * i;
//                var maxWidth = widthForThread * i + widthForThread;
//                tasks[i] = Task.Run(() => GetImageColor(bitmap, step, obj, colors, widthForThread, i, maxWidth));
//            }

//            var tasksComleted = false;
//            do
//            {
//                tasksComleted = tasks.All(x => x.IsCompleted);
//                Task.Delay(4000).Wait();
//            }
//            while (tasksComleted);

//            return colors;
//        }

//        private static void GetImageColor(Bitmap bitmap, int step, object obj, Dictionary<RGB, int> colors
//            , int widthForThread, int i, int maxWidth)
//        {
//            for (var x = widthForThread * i; x < maxWidth; x++)
//            {
//                for (var y = 0; y < bitmap.Height; y += step)
//                {
//                    var thisColor = new RGB(bitmap.GetPixel(x, y));

//                    if (colors.TryGetValue(thisColor, out var value))
//                        lock (obj)
//                            colors[thisColor] = value + 1;
//                    else
//                        lock (obj)
//                            colors.Add(thisColor, 1);
//                }
//            }
//        }

//        public struct RGB : IEqualityComparer
//        {
//            public int ScaleSize;

//            public double R { get; set; }
//            public double G { get; set; }
//            public double B { get; set; }

//            public RGB(Color color, int scale = 16)
//            {
//                ScaleSize = scale;
//                R = Math.Ceiling(((double)color.R / 256) * ScaleSize);
//                G = Math.Ceiling(((double)color.G / 256) * ScaleSize);
//                B = Math.Ceiling(((double)color.B / 256) * ScaleSize);
//            }

//            public new bool Equals(object x, object y)
//            {
//                if (x is RGB xrgb)
//                {
//                    if (y is RGB yrgb)
//                        return xrgb.R == yrgb.R && xrgb.G == yrgb.G && xrgb.B == yrgb.B;
//                    else
//                        return false;
//                }
//                else if (y is RGB yrgb)
//                    return false;
//                else
//                    return x == y;
//            }

//            public int GetHashCode(object obj)
//            {
//                return Convert.ToInt32((R * R) + (G * 32) + (B * 16));
//            }

//            public override string ToString()
//            {
//                return base.ToString();
//            }
//        }
//    }
//}
