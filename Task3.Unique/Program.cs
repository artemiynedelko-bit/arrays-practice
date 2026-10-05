using System;

namespace Task3.Unique
{
    class Program
    {
        // Возвращает массив без повторяющихся элементов.
        public static int[] GetUnique(int[] source)
        {
            int[] unique = new int[source.Length];
            int uniqueCount = 0;

            // Проверяем каждый элемент исходного массива.
            for (int i = 0; i < source.Length; i++)
            {
                bool exists = false;

                // Ищем текущий элемент среди уже найденных уникальных элементов.
                for (int j = 0; j < uniqueCount; j++)
                {
                    if (unique[j] == source[i])
                    {
                        exists = true;
                        break;
                    }
                }

                // Если элемент еще не встречался, добавляем его.
                if (!exists)
                {
                    unique[uniqueCount] = source[i];
                    uniqueCount++;
                }
            }

            // Создаем массив нужного размера.
            int[] result = new int[uniqueCount];

            for (int i = 0; i < uniqueCount; i++)
            {
                result[i] = unique[i];
            }

            return result;
        }

        static void Main()
        {
            int[] numbers = new int[10];
            Random random = new Random();

            // Заполняем массив случайными числами от 1 до 5.
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 6);
            }

            Console.WriteLine($"Исходный массив: {string.Join(", ", numbers)}");

            int[] unique = GetUnique(numbers);
            Console.WriteLine($"Уникальные элементы: {string.Join(", ", unique)}");
        }
    }
}
