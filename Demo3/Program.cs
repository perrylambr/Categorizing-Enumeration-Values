using System;
using static Demo3.Enums;

namespace Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (Food italianFood in Utils.GetEnumValues<Food, Italian>())
                Console.WriteLine($"- Italian: {italianFood}");

            foreach (Food vegetarianFood in Utils.GetEnumValues<Food, Vegetarian>())
                Console.WriteLine($"- Vegetarian: {vegetarianFood}");

            foreach (Car superCar in Utils.GetEnumValues<Car, Supercar>())
                Console.WriteLine($"- SuperCar: {superCar}");
        }
    }
}
