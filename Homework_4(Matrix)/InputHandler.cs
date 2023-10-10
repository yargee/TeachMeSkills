namespace Matrix
{
    internal static class InputHandler
    {
        public static bool CorrectInput(ref int intValue)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            var input = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

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
