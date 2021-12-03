namespace ImageColorAnalysis
{
    public class CompareDiapasonParameters
    {
        public readonly double[] RGBCoefficients;
        public readonly int[] PermissibleDeviations;

        public CompareDiapasonParameters(double[] rgbCoefficients, int[] permissibleDeviations)
        {
            RGBCoefficients = rgbCoefficients;
            PermissibleDeviations = permissibleDeviations;
        }
    }
}
