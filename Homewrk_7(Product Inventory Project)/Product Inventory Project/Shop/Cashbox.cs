namespace ProductInventoryProject.Shop
{
    internal class Cashbox
    {
        public static float Proceeds = 0;

        public void Add(float value)
        {
            if(value < 0)
            {
                Console.WriteLine("Отрицательная стоимость!!!");
                return;
            }

            Proceeds += value;
        }
    }
}
