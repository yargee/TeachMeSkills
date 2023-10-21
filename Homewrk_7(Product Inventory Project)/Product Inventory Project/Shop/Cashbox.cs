namespace ProductInventoryProject.Shop
{
    internal class Cashbox
    {
        public static float Balance = 0;

        public void Add(float value)
        {
            Balance += value;
        }
    }
}
