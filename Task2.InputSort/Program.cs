using System;

namespace Task2.InputSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            // Запрашиваем размер массива, пока пользователь не введет положительное число.
            while (true)
            {
                Console.Write("Введите кол-во элементов: ");
                try
                {
                    n = int.Parse(Console.ReadLine());

                    if (n > 0)
                    {
                        break;
                    }

                    Console.WriteLine("Ошибка: количество элементов должно быть больше нуля.");
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

            int[] numbers = new int[n];

            // Заполняем массив, повторяя ввод текущего элемента при ошибке.
            for (int i = 0; i < n; i++)
            {
                while (true)
                {
                    Console.Write($"Элемент [{i}]: ");
                    try
                    {
                        numbers[i] = int.Parse(Console.ReadLine());
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

            Console.WriteLine();
            Console.WriteLine($"Исходный массив: {string.Join(", ", numbers)}");

            // Создаем копию и разворачиваем ее, чтобы сохранить исходный массив.
            int[] reversed = (int[])numbers.Clone();
            Array.Reverse(reversed);
            Console.WriteLine($"Обратный порядок: {string.Join(", ", reversed)}");

            // Сортируем исходный массив по возрастанию.
            Array.Sort(numbers);
            Console.WriteLine($"Отсортированный массив: {string.Join(", ", numbers)}");

            // Находим минимум и максимум без LINQ.
            int max = numbers[0];
            int min = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }

                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine($"Максимум: {max}");
            Console.WriteLine($"Минимум: {min}");
        }
    }
}
