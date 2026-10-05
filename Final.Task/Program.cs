using System;

namespace FinalTask
{
    class Program
    {
        static void Main()
        {
            double[] temperatures = { 18.5, 21.0, 23.5, 19.0, 25.5, 22.0, 17.5 };

            // Находим сумму температур и среднее значение.
            double sum = 0;

            foreach (double temperature in temperatures)
            {
                sum += temperature;
            }

            double average = sum / temperatures.Length;

            // Находим минимальную и максимальную температуру.
            double min = temperatures[0];
            double max = temperatures[0];

            foreach (double temperature in temperatures)
            {
                if (temperature < min)
                {
                    min = temperature;
                }

                if (temperature > max)
                {
                    max = temperature;
                }
            }

            // Считаем количество дней с температурой выше 20 градусов.
            int aboveTwenty = 0;

            foreach (double temperature in temperatures)
            {
                if (temperature > 20)
                {
                    aboveTwenty++;
                }
            }

            Console.WriteLine($"Температуры: {string.Join(", ", temperatures)}");
            Console.WriteLine($"Средняя температура: {average:F1} °C");
            Console.WriteLine($"Минимальная температура: {min:F1} °C");
            Console.WriteLine($"Максимальная температура: {max:F1} °C");
            Console.WriteLine($"Дней выше 20 °C: {aboveTwenty}");
        }
    }
}
