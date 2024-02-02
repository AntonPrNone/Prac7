namespace Prac7
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine($"Исходный массив: {string.Join(", ", ArrayOperations.NumbersArray)}\n");

            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
            Task7();
            Task8();
            Task9();
            Task10();
            Task11();
            Task12();
            Task13();
            Task14();
            Task15();
            Task16();
            Task17();
            Task18();
            Task19();
        }

        static void Task1()
        {
            PrintMessage("Сумма элементов целочисленного массива: ");
            Console.WriteLine(ArrayOperations.SumArray());
        }

        static void Task2()
        {
            PrintMessage("Максимальный элемент в целочисленном массиве: ");
            Console.WriteLine(ArrayOperations.MaxElArray());
        }

        static void Task3()
        {
            GetIntMultiple();
            PrintMessage($"Целочисленный массив, умноженный на {ArrayOperations.NumberMultiple}: ");
            Console.WriteLine(string.Join(" ", ArrayOperations.MultiplyByNumberArray()));
        }

        static void Task4()
        {
            PrintMessage("Среднее арифметическое значение элементов целочисленного массива: ");
            Console.WriteLine(ArrayOperations.AverageElArray());
        }

        static void Task5()
        {
            PrintMessage("Массив целых чисел от 1 до 10: ");
            Console.WriteLine(string.Join(", ", ArrayOperations.NumbersFrom1To10()));
        }

        static void Task6()
        {
            PrintMessage("Массив дней недели: ");
            Console.WriteLine(string.Join(", ", ArrayOperations.DaysOfWeek));
        }

        static void Task7()
        {
            int[] randomArray = ArrayOperations.RandomArray();
            PrintMessage("Случайный целочисленный массив: ");
            Console.Write($"[{JoinArray(randomArray)}]");
            PrintMessage(", его сумма: ");
            Console.WriteLine(ArrayOperations.SumArray(randomArray));
        }

        static void Task8()
        {
            PrintMessage("Минимальный элемент целочисленного массива: ");
            Console.Write(ArrayOperations.MinElArray());
            PrintMessage(", максимальный: ");
            Console.WriteLine(ArrayOperations.MaxElArray());
        }

        static void Task9() => Task4();

        static void Task10()
        {
            int[] userArray = GetIntArrayFromUser();
            PrintMessage("Минимальный элемент целочисленного массива: ");
            Console.Write(ArrayOperations.MinElArray(userArray));
            PrintMessage(", максимальный: ");
            Console.WriteLine(ArrayOperations.MaxElArray(userArray));
        }

        static void Task11()
        {
            ArrayOperations.SimpleNumber = ArrayOperations.GetSimpleNumbersArray();
            PrintMessage("Простые числа из выбранного диапозона: ");
            Console.WriteLine(JoinArray(ArrayOperations.SimpleNumber));
        }

        static void Task12()
        {
            PrintMessage("Названия месяцев с длиной более 5 символов: ");
            Console.WriteLine();
            foreach (var month in ArrayOperations.Months) if (month.Length > 5) Console.WriteLine(month);
        }

        static void Task13()
        {
            PrintMessage("Инвертированный целочисленный массив: ");
            Console.WriteLine(JoinArray(ArrayOperations.ReverseArray()));
        }

        static void Task14()
        {
            PrintMessage("Отсортированный по убыванию целочисленный массив: ");
            Console.WriteLine(JoinArray(ArrayOperations.SortArray()));
        }

        static void Task15()
        {
            PrintMessage("Скалярное произведение двух случайных целочисленных массивов: ");
            Console.WriteLine(ArrayOperations.ScalarMultiplyTwoArrays());
        }

        static void Task16()
        {
            int intContainsIsArray = GetIntContainsIsArray();
            PrintMessage("Имеется ли число ");
            Console.Write(intContainsIsArray);
            PrintMessage(" в заданном массиве: ");
            Console.WriteLine(ArrayOperations.ContainsElArray(targetNumber: intContainsIsArray) ? "Да" : "Нет");
        }

        static void Task17()
        {
            int rows = ArrayOperations.Matrix.GetLength(0);
            int cols = ArrayOperations.Matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++) Console.Write(ArrayOperations.Matrix[i, j] + "\t");
                Console.WriteLine();
            }
        }

        static void Task18()
        {
            PrintMessage("Сумма диагональных элементов квадратной матрицы: ");
            Console.WriteLine(ArrayOperations.CalculateDiagonalSumArray());
        }

        static void Task19()
        {
            PrintMessage("Целочисленный массив уникальных элементов: ");
            Console.WriteLine(JoinArray(ArrayOperations.FindUniqueElementsArray()));
        }

        // --------------------------------------------------------------------------------------------------

        static int[] GetIntArrayFromUser() // Ввод пользовательского целочисленного массива. Опционально для использования в тасках
        {
            PrintSystemMessage("Введите целые числа через запятую (10 элементов): ");

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

                    if (inputArray.Length != 10)
                    {
                        PrintErrorMessage("Введите ровно 10 элементов.");
                        continue;
                    }

                    return resultArray;
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

        static void GetIntMultiple() // Ввод пользовательского целого числа, которое умножит каждый элемент массива
        {
            PrintSystemMessage("Введите целое число, которое умножит каждый элемент массива: ");

            while (true)
            {
                try
                {
                    string? numberMultiple = Console.ReadLine();


                    if (string.IsNullOrWhiteSpace(numberMultiple))
                    {
                        PrintErrorMessage("Введена пустая строка. Пожалуйста, введите целое число");
                        continue;
                    }

                    ArrayOperations.NumberMultiple = int.Parse(numberMultiple);
                    break;
                }

                catch (FormatException)
                {
                    PrintErrorMessage("Ошибка ввода. Пожалуйста, введите корректное целое число");
                }

                catch (Exception ex)
                {
                    PrintErrorMessage($"Произошла ошибка: {ex.Message}");
                }
            }
        }

        static int GetIntContainsIsArray() // Ввод пользовательского целого числа на проверку наличия в целочисленном массиве
        {
            PrintSystemMessage("Введите целое число для проверки его наличия в массиве: ");

            while (true)
            {
                try
                {
                    string? numberMultiple = Console.ReadLine();


                    if (string.IsNullOrWhiteSpace(numberMultiple))
                    {
                        PrintErrorMessage("Введена пустая строка. Пожалуйста, введите целое число");
                        continue;
                    }

                    return int.Parse(numberMultiple);
                }

                catch (FormatException)
                {
                    PrintErrorMessage("Ошибка ввода. Пожалуйста, введите корректное целое число");
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

        static void PrintSystemMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(message);
            Console.ResetColor();
        }

        static void PrintMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(message);
            Console.ResetColor();
        }

        static string JoinArray(int[] array) => string.Join(", ", array);
    }
}
