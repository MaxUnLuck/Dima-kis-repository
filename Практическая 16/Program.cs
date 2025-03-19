using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_16
{
    using System;
    using System.IO;
    using System.Linq;

    public class RandomNum
    {
        private static readonly Random random = new Random();

        public static void Main(string[] args)
        {
            Console.Write("Введите имя файла для записи (например, рандомыч.txt): ");
            string filePath = Console.ReadLine();
            int n = GetNumberOfRandomNumbers();
            if (!WriteRandomNumbersToFile(filePath, n))
            {
                Console.WriteLine("Невезуха, не получилось в файл данные загнать");
                Console.ReadKey();
                return;
            }
            ProcessNumbersFromFile(filePath);

            Console.ReadKey();
        }
        static int GetNumberOfRandomNumbers()
        {
            int n;
            Console.Write("Введите положительное целое число пжлст: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Не так надо! Введите положительное целое число пжлст");
                Console.Write("Введите положительное целое число пжлст: ");
            }
            return n;
        }
        static bool WriteRandomNumbersToFile(string filePath, int numberOfNumbers)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    for (int i = 0; i < numberOfNumbers; i++)
                    {
                        int randomNumber = random.Next(-42, 18);
                        writer.WriteLine(randomNumber); // Запись в файл
                    }
                }
                Console.WriteLine($"Файл '{filePath}' с кайфом создался и с кайфом заполнился.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при записи в файл: {ex.Message}");
                return false;
            }
        }
        static void ProcessNumbersFromFile(string filePath)
        {
            try
            {
                int[] num = File.ReadAllLines(filePath).Select(int.Parse).ToArray();
                Console.WriteLine("\nСодержимое файла:");
                foreach (int number in num)
                {
                    Console.WriteLine(number);
                }
                int minValue = num.Min();
                int maxValue = num.Max();
                int range = maxValue - minValue;
                Console.WriteLine($"\nМинималочка: {minValue}");
                Console.WriteLine($"Максималочка: {maxValue}");
                Console.WriteLine($"Размах (макс - мин): {range}");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Файл '{filePath}' не найден.");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Ошибка: Файл '{filePath}' содержит некорректные данные (не числа).");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
