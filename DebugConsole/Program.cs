using ImageColorAnalysis;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DebugConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var similarityTransition = 256;
            var bitmap = new Bitmap(@"D:\РАБОЧИЙ СТОЛ\photo_2021-12-03_02-43-28 (2).jpg"); // "D:\РАБОЧИЙ СТОЛ\Картинки\11Hvl06T_WE.jpg" 

            var colors = GeneratorImageColorPalette.GetImageColor(bitmap);
            foreach (var color in colors.OrderByDescending(x => x.Value))
                Console.WriteLine($"{color.Key} Count={color.Value}");

            Console.WriteLine();

            // Не работает
            var percent = Analyzer.GetPercentOfNormalGrains(similarityTransition, colors
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
