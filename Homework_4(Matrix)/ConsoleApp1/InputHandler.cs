namespace Matrix
{
    internal static class InputHandler
    {
        public static bool CorrectInput(ref int intValue)
        {
            var input = Console.ReadLine();

            if (!int.TryParse(input, out int value))
            {
                Console.WriteLine("Введи нормально, у меня не парсится в инт");

                intValue = default;
                return false;
            }
            else
            {
                intValue = value;
                return true;
            }
        }
    }
}
