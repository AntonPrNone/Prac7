namespace Prac7
{
    internal class Program
    {
        static void Main()
        {
            GetIntArrayFromUser();
            Console.WriteLine(String.Join(" ", ArrayOperations.arrayInt));
            Console.WriteLine(ArrayOperations.SumArray());
            Console.WriteLine(ArrayOperations.MaxElArray());
            //Console.WriteLine(ArrayOperations.MultiplyByNumberArray());
            Console.WriteLine(ArrayOperations.AverageElArray());
        }

        static void GetIntArrayFromUser()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Введите целые числа через запятую:");
            Console.ResetColor();

            while (true)
            {
                try
                {
                    string? input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        PrintErrorMessage("Введена пустая строка. Пожалуйста, введите целые числа.");
                        continue;
                    }

                    string[] inputArray = input.Replace(" ", "").Split(',');

                    int[] resultArray = new int[inputArray.Length];

                    for (int i = 0; i < inputArray.Length; i++)
                    {
                        resultArray[i] = int.Parse(inputArray[i]);
                    }

                    ArrayOperations.arrayInt = resultArray;
                    break;
                }

                catch (FormatException)
                {
                    PrintErrorMessage("Ошибка ввода. Пожалуйста, введите корректные целые числа.");
                }

                catch (Exception ex)
                {
                    PrintErrorMessage($"Произошла ошибка: {ex.Message}");
                }
            }
        }

        static void PrintErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
