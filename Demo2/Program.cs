using System;
using System.Collections.Generic;
using System.Reflection;

namespace Demo2
{
    class Program
    {
        class Italian : Attribute { }

        class Mexican : Attribute { }

        class Vegetarian : Attribute { }

        enum Food
        {
            [Italian]
            [Vegetarian]
            PizzaMargherita,

            [Italian]
            LasagnaBolognese,

            [Mexican]
            [Vegetarian]
            TacoSalad,

            [Mexican]
            ChickenFajitas
        }

        static void Main(string[] args)
        {
            foreach (Food foodValue in GetEnumValues(typeof(Italian)))
                Console.WriteLine($"- Italian: {foodValue}");

            foreach (Food foodValue in GetEnumValues(typeof(Mexican)))
                Console.WriteLine($"- Mexican: {foodValue}");

            foreach (Food foodValue in GetEnumValues(typeof(Vegetarian)))
                Console.WriteLine($"- Vegetarian: {foodValue}");
        }

        static List<Food> GetEnumValues(Type attributeType)
        {
            Type foodType = typeof(Food);

            List<Food> foodValues = new List<Food>();
            foreach (Food foodValue in Enum.GetValues(foodType))
            {
                MemberInfo foodValueMemberInfo = foodType.GetMember(foodValue.ToString())[0];
                if (Attribute.IsDefined(foodValueMemberInfo, attributeType))
                    foodValues.Add(foodValue);
            }

            return foodValues;
        }
    }
}
