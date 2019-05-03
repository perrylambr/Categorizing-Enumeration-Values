namespace Demo3
{
    internal static partial class Enums
    {
        internal enum Food
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

        internal enum Car
        {
            [Supercar]
            Ferrari,

            [Supercar]
            Lamborghini,

            Toyota,

            Hyundai
        }
    }
}