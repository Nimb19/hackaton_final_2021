using ImageColorAnalysis;
using ImageColorAnalysis.ImplementationModels;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DebugConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitmap = new Bitmap(@"D:\РАБОЧИЙ СТОЛ\photo_2021-12-03_02-25-01.jpg"); 

            var material = BuckwheatMaterial.Instance;
            var colors = GeneratorImageColorPalette.GetImageColor(bitmap, material);
            foreach (var color in colors.OrderByDescending(x => x.Value))
                Console.WriteLine($"{color.Key} Count={color.Value} {color.Key.IsIncludedInTheRange(material)}");

            Console.WriteLine();

            var percent = Analyzer.GetPercentOfNormalGrains(colors, material
                , out var notSuccessColor, out var successColor);
            Console.WriteLine($"Similarity relation (256) successPercent: {percent}%");
            Console.WriteLine($"[Success={successColor}; NotSuccessColor={notSuccessColor}]");

            Console.ReadLine();
        }

        private static string GetFile()
        {
            var filequery = new OpenFileDialog();
            if (filequery.ShowDialog() == DialogResult.OK)
                return filequery.FileName;
            else
                throw new Exception();
        }
    }
}
