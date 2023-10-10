using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class Menu
    {
        public static void MatrixImput(out Matrix matrix)
        {
            int rows = 0;
            int columns = 0;
            int value = 0;
            string? input;

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
    }
}
