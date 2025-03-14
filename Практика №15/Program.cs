using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика__15
{
    internal class Program
    {
        public struct Car
        {
            public string Model;
            public string Brand;
            public int Year;
            public string Configuration;
            public decimal Price;
            public void DisplayCarInfo()
            {
                Console.WriteLine($"Модель: {Model}");
                Console.WriteLine($"Фирма: {Brand}");
                Console.WriteLine($"Год выпуска: {Year}");
                Console.WriteLine($"Комплектация: {Configuration}");
                Console.WriteLine($"Цена: {Price}");
            }
           
        }
        public class DealerCenter
        {
            public static void Main(string[] args)
            {
                
                Console.WriteLine("Добро пожаловать в дилерский центр!");
                int n;
                while (true)
                {
                    Console.Write("Введите количество автомобилей в дилерском центре: ");
                    string nn= Console.ReadLine();
                    bool nIsNumber = int.TryParse(nn, out n);

                    if (nIsNumber)
                    {
                        if (n > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод. Пожалуйста, введите положительное целое число.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
                    }
                }

                Car[] cars = new Car[n];

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("\nВведите данные для автомобиля #" + (i + 1) + ":");
                    Console.Write("  Модель: ");
                    cars[i].Model = Console.ReadLine();
                    Console.Write("  Фирма: ");
                    cars[i].Brand = Console.ReadLine();
                    while (true)
                    {
                        Console.Write("  Год выпуска: ");
                        string year = Console.ReadLine();
                        int year2;
                        bool yearN = int.TryParse(year, out year2);
                        if (yearN)
                        {
                            if (year2 > 1885 && year2 <= DateTime.Now.Year)
                            {
                                cars[i].Year = year2;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("  Некорректный ввод года выпуска. Введите год в диапазоне от 1886 до текущего года.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("  Некорректный ввод года выпуска. Введите год цифрами.");
                        }
                    }
                    Console.Write("  Комплектация: ");
                    cars[i].Configuration = Console.ReadLine();
                    while (true)
                    {
                        Console.Write("  Цена: ");
                        string priceString = Console.ReadLine();
                        decimal price;
                        bool priceIsNumber = decimal.TryParse(priceString, out price);
                        if (priceIsNumber)
                        {
                            if (price >= 0)
                            {
                                cars[i].Price = price;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("  Некорректный ввод цены. Введите положительное число.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("  Некорректный ввод цены. Введите число.");
                        }
                    }
                }
                Array.Sort(cars, (c1, c2) => c1.Year.CompareTo(c2.Year));
                Console.WriteLine("\nАвтомобили, отсортированные по году выпуска:");
                for (int i = 0; i < cars.Length; i++)
                {
                    Console.WriteLine("Автомобиль #" + (i + 1) + ":");
                    cars[i].DisplayCarInfo();
                }
                Console.Write("\nВведите модель автомобиля, информацию о которой хотите получить: ");
                string searchModel = Console.ReadLine();
                bool found = false;
                for (int i = 0; i < cars.Length; i++)
                {
                    if (cars[i].Model.Equals(searchModel, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("\nИнформация о найденной модели:");
                        cars[i].DisplayCarInfo();
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("Автомобиль с моделью '" + searchModel + "' не найден.");
                }
                if (cars.Length > 0)
                {
                    Car mostExpensiveCar = cars[0];

                    for (int i = 1; i < cars.Length; i++)
                    {
                        if (cars[i].Price > mostExpensiveCar.Price)
                        {
                            mostExpensiveCar = cars[i];
                        }
                    }
                    Console.WriteLine("\nИнформация о наиболее дорогом автомобиле:");
                    mostExpensiveCar.DisplayCarInfo();
                }
                else
                {
                    Console.WriteLine("\nВ дилерском центре нет автомобилей.");
                }
                Console.WriteLine("\nПрограмма завершена.");
            }
        }
    }
}
