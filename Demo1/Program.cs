using System;

namespace Demo1
{
    class Program
    {
        enum Food
        {
            PizzaMargherita,
            LasagnaBolognese,
            TacoSalad,
            ChickenFajitas
        }

        static void Main(string[] args)
        {
            foreach (Food foodValue in Enum.GetValues(typeof(Food)))
                Console.WriteLine($"- Food: {foodValue}");
        }
    }
}