using ImageColorAnalysis.ImplementationModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Tesseract;

namespace ImageColorAnalysis
{
    public class Analyzer
    {
        public static void OutputNumInfo(string fileName, string pathToLangFolder)
        {
            using (var engine = new TesseractEngine(pathToLangFolder, "eng", EngineMode.Default))
            {
                // have to load Pix via a bitmap since Pix doesn't support loading a stream.
                using (var image = new Bitmap(fileName))
                {
                    using (var pix = PixConverter.ToPix(image))
                    {
                        using (var page = engine.Process(pix))
                        {
                            Console.WriteLine(page.GetMeanConfidence() + " : " + page.GetText());
                        }
                    }
                }
            }
        }

        public static double GetPercentOfNormalGrains(Dictionary<ScaledRGB, int> colors
            , IRawMaterial materialParameters
            , out int notSuccessColor, out int successColor)
        {
            var colorGroups = colors.GroupBy(x 
                => x.Key.IsIncludedInTheRange(materialParameters)).ToArray();

            notSuccessColor = GetSum(colorGroups.FirstOrDefault(x => !x.Key));
            successColor = GetSum(colorGroups.FirstOrDefault(x => x.Key));
            double all = successColor + notSuccessColor;

            return (successColor / all) * 100;
        }

        private static int GetSum(IGrouping<bool, KeyValuePair<ScaledRGB, int>> group)
        {
            var success = 0;
            
            if (group == null)
                return success;

            foreach (var nscolor in group)
                success += nscolor.Value;
            return success;
        }
    }
}
