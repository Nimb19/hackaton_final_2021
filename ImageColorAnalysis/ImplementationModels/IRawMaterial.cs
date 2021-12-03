using System.Drawing;

namespace ImageColorAnalysis.ImplementationModels
{
    public interface IRawMaterial
    {
        string Name { get; }

        /// <summary> Допустимый диапазон </summary>
        (int LowerDev, int UpperDev) PermissibleDeviations { get; }

        byte[] LowerSuccessDiapasonArray { get; } 
        Color LowerSuccessDiapason { get; }

        byte[] UpperSuccessDiapasonArray { get; }
        Color UpperSuccessDiapason { get; }
    }
}
