using System.Drawing;

namespace ImageColorAnalysis.ImplementationModels
{
    public class BuckwheatMaterial : IRawMaterial
    {
        public string Name { get; }
        public (int LowerDev, int UpperDev) PermissibleDeviations { get; }

        public byte[] LowerSuccessDiapasonArray { get; }
        public Color LowerSuccessDiapason { get; }
        
        public byte[] UpperSuccessDiapasonArray { get; }
        public Color UpperSuccessDiapason { get; }

        public BuckwheatMaterial()
        {
            Name = "Гречка";
            PermissibleDeviations = (10, 70);

            LowerSuccessDiapasonArray = new byte[] { 70, 40, 20 };
            LowerSuccessDiapason = Color.FromArgb(LowerSuccessDiapasonArray[0]
                , LowerSuccessDiapasonArray[1], LowerSuccessDiapasonArray[2]);

            UpperSuccessDiapasonArray = new byte[] { 255, 255, 255 };
            UpperSuccessDiapason = Color.FromArgb(UpperSuccessDiapasonArray[0]
                , UpperSuccessDiapasonArray[1], UpperSuccessDiapasonArray[2]);
        }

        public static BuckwheatMaterial Instance
            => new BuckwheatMaterial();
    }
}
