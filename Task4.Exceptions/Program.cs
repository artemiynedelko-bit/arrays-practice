using System;

namespace Task4.Exceptions
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[5];

            // Заполняем массив и повторяем ввод при ошибке.
            for (int i = 0; i < numbers.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Введите элемент [{i}]: ");

                    try
                    {
                        numbers[i] = int.Parse(Console.ReadLine() ?? "");
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка: введите целое число.");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Ошибка: число слишком большое или маленькое.");
                    }
                }
            }

            Console.WriteLine($"Массив: {string.Join(", ", numbers)}");

            Console.Write("Введите индекс элемента: ");

            try
            {
                // Получаем индекс и обращаемся к элементу массива.
                int index = int.Parse(Console.ReadLine() ?? "");
                Console.WriteLine($"Элемент с индексом {index}: {numbers[index]}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: индекс должен быть целым числом.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: индекс слишком большой или маленький.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Ошибка: такого индекса нет в массиве.");
            }
        }
    }
}
