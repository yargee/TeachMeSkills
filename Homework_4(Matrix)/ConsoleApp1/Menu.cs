using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Menu
    {
        public static void MatrixImput(out Matrix matrix)
        {
            int rows = 0;
            int columns = 0;
            int value = 0;
            string input;

            Console.WriteLine("Введите размерность матрицы." +
                "\nСтолбцы:");
            do
            {
                input = Console.ReadLine();
            }
            while (!InputHandler.InputCorrect(input, ref columns));

            Console.WriteLine("Строки:");
            do
            {
                input = Console.ReadLine();
            }
            while (!InputHandler.InputCorrect(input, ref rows));

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
                    do
                    {
                        input = Console.ReadLine();
                    }
                    while (!InputHandler.InputCorrect(input, ref value));
                    values.Add(value);
                }

                matrix = new Matrix(columns, rows, values);
            }
        }
    }
}
