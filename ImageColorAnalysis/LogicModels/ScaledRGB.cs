using ImageColorAnalysis.ImplementationModels;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace ImageColorAnalysis
{
    public struct ScaledRGB : IEqualityComparer<ScaledRGB>
    {
        private const int MaximumDeviationForLightPixels = 25;
        private const int BorderOfLightPixels = 600;

        public int ScaleSize { get; }
        public CompareDiapasonParameters CompareParameters { get; }

        public double R { get; set; }
        public double G { get; set; }
        public double B { get; set; }

        public double OrigR { get; set; }
        public double OrigG { get; set; }
        public double OrigB { get; set; }

        public ScaledRGB(Color color, int scale, CompareDiapasonParameters compareParameters)
        {
            ScaleSize = scale;

            OrigR = color.R;
            OrigG = color.G;
            OrigB = color.B;

            R = Math.Round(((double)color.R / 256) * ScaleSize);
            G = Math.Round(((double)color.G / 256) * ScaleSize);
            B = Math.Round(((double)color.B / 256) * ScaleSize);

            CompareParameters = compareParameters;
        }

        public static ScaledRGB CreateComparerInstance
            => new ScaledRGB();

        public bool IsIncludedInTheRange(IRawMaterial materialParameters)
            => IsIncludedInTheRange(
                  materialParameters.LowerSuccessDiapason
                , materialParameters.UpperSuccessDiapason);

        public bool IsIncludedInTheRange(Color lowerDiapason, Color upperDiapason)
        {
            var cleanSum = OrigR + OrigG + OrigB;
            if (cleanSum > BorderOfLightPixels)
                return IsNormalParameters(true, cleanSum);
            else
            {
                if ((CheckLowerDiapason(lowerDiapason)
                    && CheckUpperDiapason(upperDiapason))
                    && IsNormalParameters())
                    return true;
                else
                    return false;
            }
        }

        private bool CheckLowerDiapason(Color lowerDiapason)
        {
            return (OrigR > lowerDiapason.R) && (OrigG > lowerDiapason.G) && (OrigB > lowerDiapason.B);
        }

        private bool CheckUpperDiapason(Color upperDiapason)
        {
            return (OrigR < upperDiapason.R) && (OrigG < upperDiapason.G) && OrigB < (upperDiapason.B);
        }

        public bool IsNormalParameters(bool checkAsLightColor = false, double? cleanSum = null)
        {
            if (checkAsLightColor)
            {
                var avg = cleanSum.Value / 3;

                if    (Math.Abs(avg - OrigR) < MaximumDeviationForLightPixels
                    && Math.Abs(avg - OrigG) < MaximumDeviationForLightPixels
                    && Math.Abs(avg - OrigB) < MaximumDeviationForLightPixels)
                    return true;
                else
                    return false;
            }
            else
            {
                var avg = (OrigR * CompareParameters.RGBCoefficients[0]
                         + OrigG * CompareParameters.RGBCoefficients[1]
                         + OrigB * CompareParameters.RGBCoefficients[2])
                         / 3;

                if (Math.Abs(avg - OrigR) < CompareParameters.PermissibleDeviations[0]
                    && Math.Abs(avg - OrigG) < CompareParameters.PermissibleDeviations[1]
                    && Math.Abs(avg - OrigB) < CompareParameters.PermissibleDeviations[2])
                    return true;
                else
                    return false;
            }
        }

        #region Redefined methods

        public new bool Equals(object x, object y)
        {
            if (x is ScaledRGB xrgb)
            {
                if (y is ScaledRGB yrgb)
                    return xrgb.R == yrgb.R && xrgb.G == yrgb.G && xrgb.B == yrgb.B;
                else
                    return false;
            }
            else if (y is ScaledRGB)
                return false;
            else
                return x == y;
        }

        public int GetHashCode(object obj)
        {
            if (obj is ScaledRGB rgb)
                return Convert.ToInt32((rgb.R * -5) + (rgb.G * 32) + (rgb.B * 16));
            else
                return obj.GetHashCode();
        }

        public override string ToString()
        {
            return $"R={OrigR};G={OrigG};B={OrigB}";
        }

        public bool Equals(ScaledRGB x, ScaledRGB y)
        {
            return Equals((object)x, (object)y);
        }

        public int GetHashCode(ScaledRGB obj)
        {
            return GetHashCode((object)obj);
        }

        #endregion Redefined methods
    }
}
