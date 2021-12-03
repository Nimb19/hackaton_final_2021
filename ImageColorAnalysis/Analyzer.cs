using ImageColorAnalysis.ImplementationModels;
using System.Collections.Generic;
using System.Linq;

namespace ImageColorAnalysis
{
    public class Analyzer
    {
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
