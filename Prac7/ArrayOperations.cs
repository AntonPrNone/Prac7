namespace Prac7
{
    public static class ArrayOperations
    {
        public static int[] NumbersArray { get; set; } = NumbersFrom1To10();

        public static int[] SimpleNumber { get; set; } = [];

        public static int NumberMultiple { get; set; } = 1;

        public static string[] DaysOfWeek { get; } = ["Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"];

        public static string[] Months { get; } = ["Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"];

        public static int[,] Matrix { get; } = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public static int SumArray(int[]? array = null) => (array ?? NumbersArray).Sum();

        public static int MinElArray(int[]? array = null) => (array ?? NumbersArray).Min();

        public static int MaxElArray(int[]? array = null) => (array ?? NumbersArray).Max();

        public static int[] MultiplyByNumberArray(int[]? array = null) => (array ?? NumbersArray).Select(x => x * NumberMultiple).ToArray();

        public static double AverageElArray(int[]? array = null) => (array ?? NumbersArray).Average();

        public static int[] RandomArray() => Enumerable.Range(1, 10).Select(_ => new Random().Next(1, 100)).ToArray();

        public static int[] NumbersFrom1To10() => Enumerable.Range(1, 10).ToArray();

        public static int[] GetSimpleNumbersArray(int lowerBound = 0, int upperBound = 100) => Enumerable.Range(lowerBound, upperBound - lowerBound + 1).Where(IsSimple).ToArray();

        static bool IsSimple(int number) => number > 1 && Enumerable.Range(2, (int)Math.Sqrt(number) - 1).All(i => number % i != 0);

        public static int[] ReverseArray(int[]? array = null) => (array ?? NumbersArray).Reverse().ToArray();

        public static int[] SortArray(int[]? array = null) => (array ?? NumbersArray).OrderByDescending(x => x).ToArray();

        public static int ScalarMultiplyTwoArrays() => RandomArray().Zip(RandomArray(), (a, b) => a * b).Sum();

        public static bool ContainsElArray(int[]? array = null, int targetNumber = 1) => (array ?? NumbersArray).Contains(targetNumber);

        public static int CalculateDiagonalSumArray(int[,]? matrix = null) => Enumerable.Range(0, (matrix ?? Matrix).GetLength(0)).Sum(i => (matrix ?? Matrix)[i, i]);

        public static int[] FindUniqueElementsArray(int[]? array = null) => (array ?? NumbersArray).Distinct().ToArray();
    }
}
