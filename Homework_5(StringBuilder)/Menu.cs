namespace JokesParser
{
    internal class Menu
    {
        public static void Start()
        {
            while (Joke.Value != null)
            {
                Console.WriteLine("Выберите действие: " +
                    "\n1.Найти самое длинное слово и определить сколько раз оно встречается в тексте." +
                    "\n2.Заменить цифры на соответствущие слова." +
                    "\n3.Вывести на экран сперва вопросительные, потом восклицательные предложения." +
                    "\n4.Вывести на экран предложения не содержащие запятых." +
                    "\n5.Найти слова, начинающиеся и заканчивающиеся на одну и ту же букву.");

                var index = Console.ReadLine();

                var action = new Action(Convert.ToInt16(index));                
            }
        }

        public static void ShowColoredResult(string message, string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
    }
}
