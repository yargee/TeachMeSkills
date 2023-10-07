namespace Calculator
{
    internal static class Menu
    {
        public static void Start() 
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Введите выражение используя числа и знаки '+', '-', '*', '/'.\n" +
                "Для произведения расчета после ввода выражения нажмите Enter.");
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        public static void CorrectionAnnounce()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("В выражении были обнаружены недопустимые символы.Калькулятор удалил их.\n" +
                    "Проверьте отредактированное выражение: ");
        }

        public static bool CorrectionApproving()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nЕсли выражение верно, нажмите ENTER, если нет, введите любой символ.");
            var input = Console.ReadLine();
            var result = input == "" ? true : false;
            return result;
        }

        public static void WtfInput()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ну и что ты ввел, умник?");
        }
    }
}