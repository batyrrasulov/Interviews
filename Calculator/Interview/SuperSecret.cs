using System;
using System.Collections.Generic;
using System.Linq;
using A = Interview.DistinctNumbersCalculator;
using B = Interview.MeanCalculator;
using C = Interview.RangeCalculator;
using D = Interview.MedianCalculator;

namespace Interview
{
    public class SuperSecret
    {
        private delegate double CalcDel(int[] inputs);

        public static double GetCorrectSolution(ICalculator c, int[] inputs)
        {
            return _r[c.GetType()](inputs);
        }

        private static readonly Dictionary<Type, CalcDel> _r = new Dictionary<Type, CalcDel>
        {
            { typeof(A), i => i.Distinct().Count() },
            { typeof(B), i => i.Average() },
            { typeof(C), i => { return (double)i.Max() - i.Min();} },
            { typeof(D), i =>
                {
                    var s = i.OrderBy(x => x).ToArray();
                    return (s.Length % 2 != 0) ? (double)s[(s.Length / 2)] : ((double)s[(s.Length / 2)] + (double)s[(s.Length / 2) - 1]) / 2;
                }
            }
        };
    }

    public static class X
    {
        public static double GetAnswer(this ICalculator c, int[] s)
        {
            return SuperSecret.GetCorrectSolution(c, s);
        }
    }
}
