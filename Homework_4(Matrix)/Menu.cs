namespace Matrix
{
    internal class Menu
    {
        public static void MatrixImput(out Matrix matrix)
        {
            var rows = 0;
            var columns = 0;
            var value = 0;

            Console.WriteLine("Введи размерность матрицы." +
                            "\nСтроки:");
            while (!InputHandler.CorrectInput(ref columns));

            Console.WriteLine("Столбцы:");
            while (!InputHandler.CorrectInput(ref rows));

            Console.WriteLine("Введи любой символ для последующего ручного ввода значений. " +
                            "\nНажми Enter для случайного автоматического заполнения");

            bool result = Console.ReadLine() == "" ? true : false;

            if (result)
            {
                matrix = new Matrix(columns, rows);
            }
            else
            {
                var values = new List<int>();

                for (int i = 0; i < columns * rows; i++)
                {
                    while (!InputHandler.CorrectInput(ref value));
                    values.Add(value);
                }

                matrix = new Matrix(columns, rows, values);
            }
        }

        public static int SelectOperation()
        {
            var index = 0;

            Console.WriteLine("Введи номер операции." +
                "\n1. Показать положительные числа" +
                "\n2. Показать отрицательные числа" +
                "\n3. Построчная сортировка по возрастанию" +
                "\n4. Построчная сортировка по убыванию" +
                "\n5. Построчная инверсия элементов");
            Console.WriteLine();
            while (!InputHandler.CorrectInput(ref index));
            Console.WriteLine();

            return index;
        }
    }
}
