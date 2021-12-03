using System.Drawing;

namespace ImageColorAnalysis.ImplementationModels
{
    public interface IRawMaterial
    {
        string Name { get; }
        CompareDiapasonParameters CompareDiapasonParameters { get; }
        byte[] LowerSuccessDiapasonArray { get; } 
        Color LowerSuccessDiapason { get; }

        byte[] UpperSuccessDiapasonArray { get; }
        Color UpperSuccessDiapason { get; }
    }
}
