using System;

internal class Program
{
    public struct Car
    {
        public string Model;
        public string Brand;
        public int Year;
        public string Configuration;
        public decimal Price;

        public void DisplayInfo() => Console.WriteLine(
            $"Модель: {Model}\nФирма: {Brand}\n" +
            $"Год выпуска: {Year}\nКомплектация: {Configuration}\nЦена: {Price}");
    }

    public class DealerCenter
    {
        public static void Main()
        {
            Console.WriteLine("Добро пожаловать в дилерский центр!");
            Car[] cars = InputCars();

            Array.Sort(cars, (c1, c2) => c1.Year.CompareTo(c2.Year));
            DisplaySortedCars(cars);

            SearchCar(cars);
            DisplayMostExpensiveCar(cars);

            Console.WriteLine("\nПрограмма завершена.");
        }

        private static Car[] InputCars()
        {
            int count = ReadPositiveInt("Введите количество автомобилей: ");
            var cars = new Car[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nАвтомобиль #{i + 1}:");
                cars[i] = new Car
                {
                    Model = ReadString("  Модель: "),
                    Brand = ReadString("  Фирма: "),
                    Year = ReadYear("  Год выпуска: "),
                    Configuration = ReadString("  Комплектация: "),
                    Price = ReadPositiveDecimal("  Цена: ")
                };
            }
            return cars;
        }

        private static int ReadPositiveInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int result) && result > 0)
                    return result;
                Console.WriteLine("Ошибка: введите положительное целое число");
            }
        }

        private static int ReadYear(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int year) &&
                    year > 1885 && year <= DateTime.Now.Year)
                    return year;
                Console.WriteLine($"Ошибка: год должен быть между 1886 и {DateTime.Now.Year}");
            }
        }

        private static decimal ReadPositiveDecimal(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (decimal.TryParse(Console.ReadLine(), out decimal result) && result >= 0)
                    return result;
                Console.WriteLine("Ошибка: введите неотрицательное число");
            }
        }

        private static string ReadString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        private static void DisplaySortedCars(Car[] cars)
        {
            Console.WriteLine("\nАвтомобили по году выпуска:");
            foreach (var car in cars)
            {
                car.DisplayInfo();
                Console.WriteLine();
            }
        }

        private static void SearchCar(Car[] cars)
        {
            string model = ReadString("\nВведите модель для поиска: ");
            var foundCar = Array.Find(cars, c => c.Model.Equals(model, StringComparison.OrdinalIgnoreCase));

            if (foundCar.Model != null)
            {
                Console.WriteLine("\nНайденный автомобиль:");
                foundCar.DisplayInfo();
            }
            else
            {
                Console.WriteLine($"Автомобиль '{model}' не найден");
            }
        }

        private static void DisplayMostExpensiveCar(Car[] cars)
        {
            if (cars.Length == 0) return;

            var mostExpensive = cars[0];
            foreach (var car in cars)
            {
                if (car.Price > mostExpensive.Price)
                    mostExpensive = car;
            }

            Console.WriteLine("\nСамый дорогой автомобиль:");
            mostExpensive.DisplayInfo();
        }
    }
}