namespace ProductInventoryProject.Customer
{
    internal class Wallet
    {
        public static float Balance { get; private set; } = 200;      

        public bool TrySpend(float value)
        {
            if(value > Balance || value <=0 )
            {
                Console.WriteLine("Недостаточно средств или сумма некорректна");
                return false;
            }

            Balance -= value;
            return true;
        }
    }
}
