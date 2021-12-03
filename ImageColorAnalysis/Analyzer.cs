using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageColorAnalysis
{
    public class Analyzer
    {
        public static double GetPercentOfNormalGrains(int similarityTransition
            , Dictionary<RGB, int> colors, out int notSuccessColor, out int successColor)
        {
            var colorGroups = colors.GroupBy(x => x.Key.Similarity < similarityTransition);

            notSuccessColor = GetSum(colorGroups.FirstOrDefault(x => x.Key));
            successColor = GetSum(colorGroups.FirstOrDefault(x => !x.Key));
            double all = successColor + notSuccessColor;

            return successColor / all * 100;
        }

        private static int GetSum(IGrouping<bool, KeyValuePair<RGB, int>> group)
        {
            var success = 0;
            
            if (group == null)
                return success;

            foreach (var nscolor in group)
                success = +nscolor.Value;
            return success;
        }
    }
}
