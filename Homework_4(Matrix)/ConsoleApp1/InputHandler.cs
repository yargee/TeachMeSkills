namespace ConsoleApp1
{
    internal static class InputHandler
    {
        public static bool InputCorrect(string s, ref int intValue)
        {
            if (!int.TryParse(s, out int value))
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
