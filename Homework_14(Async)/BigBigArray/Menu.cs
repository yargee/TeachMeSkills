namespace BigBigArray
{
    internal class Menu
    {
        private int[] _array = new int[10_000_000];

        public void InitArray()
        {
            var rnd = new Random();

            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = rnd.Next(-100,101);
            }
        }

        public void Start()
        {
            Console.WriteLine("Введите количество потоков");
            var input = Console.ReadLine();

            if(int.TryParse(input, out var index))
            {
                var handler = new ArrayHandler(_array, index);

                var sum = handler.SumAllAsync();

                Console.WriteLine($"Total sum: {sum.Result}");
            }
        }
    }
}
