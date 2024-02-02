using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac7
{
    public static class ArrayOperations
    {
        public static int[] arrayInt { get; set; } = Enumerable.Range(1, 10).ToArray();

        public static int SumArray()  => arrayInt.Sum();

        public static int MaxElArray() => arrayInt.Max();

        public static void MultiplyByNumberArray(int multiplier) => arrayInt = arrayInt.Select(x => x * multiplier).ToArray();

        public static double AverageElArray() => arrayInt.Average();

    }
}
