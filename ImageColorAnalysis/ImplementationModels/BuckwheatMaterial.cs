using System.Drawing;

namespace ImageColorAnalysis.ImplementationModels
{
    public class BuckwheatMaterial : IRawMaterial
    {
        public string Name { get; }

        public CompareDiapasonParameters CompareDiapasonParameters { get; }

        public byte[] LowerSuccessDiapasonArray { get; }
        public Color LowerSuccessDiapason { get; }
        
        public byte[] UpperSuccessDiapasonArray { get; }
        public Color UpperSuccessDiapason { get; }

        public BuckwheatMaterial()
        {
            Name = "Гречка";
            CompareDiapasonParameters = new CompareDiapasonParameters(
                  rgbCoefficients: new double[3] { 1, 1.5, 3.2 }
                , permissibleDeviations: new int[3] { 60, 60, 60 });

            LowerSuccessDiapasonArray = new byte[] { 80, 50, 20 };
            LowerSuccessDiapason = Color.FromArgb(LowerSuccessDiapasonArray[0]
                , LowerSuccessDiapasonArray[1], LowerSuccessDiapasonArray[2]);

            UpperSuccessDiapasonArray = new byte[] { 220, 190, 150 };
            UpperSuccessDiapason = Color.FromArgb(UpperSuccessDiapasonArray[0]
                , UpperSuccessDiapasonArray[1], UpperSuccessDiapasonArray[2]);
        }

        public static BuckwheatMaterial Instance
            => new BuckwheatMaterial();
    }
}
