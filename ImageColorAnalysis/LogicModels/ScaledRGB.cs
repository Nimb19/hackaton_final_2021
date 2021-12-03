using ImageColorAnalysis.ImplementationModels;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace ImageColorAnalysis
{
    public struct ScaledRGB : IEqualityComparer<ScaledRGB>
    {
        public int ScaleSize { get; }

        public double R { get; set; }
        public double G { get; set; }
        public double B { get; set; }

        public double OrigR { get; set; }
        public double OrigG { get; set; }
        public double OrigB { get; set; }

        public ScaledRGB(Color color, int scale)
        {
            ScaleSize = scale;

            OrigR = color.R;
            OrigG = color.G;
            OrigB = color.B;

            R = Math.Round(((double)color.R / 256) * ScaleSize);
            G = Math.Round(((double)color.G / 256) * ScaleSize);
            B = Math.Round(((double)color.B / 256) * ScaleSize);
        }

        public static ScaledRGB CreateComparerInstance
            => new ScaledRGB();

        public bool IsIncludedInTheRange(IRawMaterial materialParameters)
            => IsIncludedInTheRange(
                  materialParameters.LowerSuccessDiapason
                , materialParameters.UpperSuccessDiapason
                , materialParameters.PermissibleDeviations);

        public bool IsIncludedInTheRange(Color lowerDiapason, Color upperDiapason
            , (int LowerDev, int UpperDev) permissibleDeviations)
        {
            if ((CheckLowerDiapason(lowerDiapason)
                && CheckUpperDiapason(upperDiapason))
                && IsNormalParameters(permissibleDeviations))
                return true;
            else
                return false;
        }

        private bool CheckLowerDiapason(Color lowerDiapason)
        {
            return (OrigR > lowerDiapason.R) && (OrigG > lowerDiapason.G) && (OrigB > lowerDiapason.B);
        }

        private bool CheckUpperDiapason(Color upperDiapason)
        {
            return (OrigR < upperDiapason.R) && (OrigG < upperDiapason.G) && OrigB < (upperDiapason.B);
        }

        public bool IsNormalParameters((int LowerDev, int UpperDev) permissibleDeviations)
        {
            var avg = (OrigR + OrigG + OrigB) / 3;

            Func<double, double> getDevelation = (double origValue) => Math.Abs(avg - origValue);

            var develationR = getDevelation(OrigR);
            var develationG = getDevelation(OrigG);
            var develationB = getDevelation(OrigB);

            if (avg > 200)
            {
                if    (isContainsInRange(develationR, 0, 80)
                    && isContainsInRange(develationG, 0, 70) 
                    && isContainsInRange(develationB, 0, 80))
                    return true;
                else
                    return false;
            }
            else
            {
                if    (isContainsInRange(develationR)
                    && isContainsInRange(develationG
                        , 0, permissibleDeviations.LowerDev) 
                    && isContainsInRange(develationB))
                    return true;
                else
                    return false;
            }

            bool isContainsInRange(double develation, int? lowerDev = null, int? upperDev = null)
                => (develation >= (lowerDev ?? permissibleDeviations.LowerDev))
                && (develation <= (upperDev ?? permissibleDeviations.UpperDev));
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
