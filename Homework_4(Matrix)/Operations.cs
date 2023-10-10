namespace Matrix
{
    internal class Operations
    {
        private Matrix _matrix;

        public Operations(Matrix matrix)
        {
            _matrix = matrix;
        }

        private bool IsNegative(int value) => value < 0;
        private bool IsPositive(int value) => value > 0;

        private void ShowNegative()
        {
            PrintColored(IsNegative);
        }

        private void ShowPositive()
        {
            PrintColored(IsPositive);
        }

        public void SortColumnsAscending()
        {
            SortColumns();
        }

        public void SortColumnsDecreasing()
        {
            SortColumns(false);
        }

        public void Inversion()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Я не понял этот пункт задания. " +
                            "\nЕсли нужно просто инвертировать элементы, то почему построчно и что под этим подразумевается? Умножить на -1? :)" +
                            "\nЕсли же нужно построить обратную матрицу, то опять же, почему построчно?");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public Operation StartOperation(int index) => index switch
        {
            1 => ShowPositive,
            2 => ShowNegative,
            3 => SortColumnsAscending,
            4 => SortColumnsDecreasing,
            5 => Inversion,
            _ => InputHandler.CrutchError
        };

        public void Print()
        {
            for (int i = 0; i < _matrix.MatrixValues.GetLength(0); i++)
            {
                for (int j = 0; j < _matrix.MatrixValues.GetLength(1); j++)
                {
                    Console.Write(_matrix.MatrixValues[i, j] + "\t");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public void PrintColored(ZeroComparison func)
        {
            for (int i = 0; i < _matrix.MatrixValues.GetLength(0); i++)
            {
                for (int j = 0; j < _matrix.MatrixValues.GetLength(1); j++)
                {
                    if (func(_matrix.MatrixValues[i, j]))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(_matrix.MatrixValues[i, j] + "\t");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write(_matrix.MatrixValues[i, j] + "\t");
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public void SortColumns(bool ascending = true)
        {
            if (ascending)
            {
                for (int i = 0; i < _matrix.MatrixValues.GetLength(0); i++)
                {
                    for (int j = 0; j < _matrix.MatrixValues.GetLength(1); j++)
                    {
                        for (int k = 0; k < _matrix.MatrixValues.GetLength(1) - 1; k++)
                        {
                            if (_matrix.MatrixValues[j, k] > _matrix.MatrixValues[j, k + 1])
                            {
                                var temp = _matrix.MatrixValues[j, k];
                                _matrix.MatrixValues[j, k] = _matrix.MatrixValues[j, k + 1];
                                _matrix.MatrixValues[j, k + 1] = temp;
                            }
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < _matrix.MatrixValues.GetLength(0); i++)
                {
                    for (int j = 0; j < _matrix.MatrixValues.GetLength(1); j++)
                    {
                        for (int k = 0; k < _matrix.MatrixValues.GetLength(1) - 1; k++)
                        {
                            if (_matrix.MatrixValues[j, k] <= _matrix.MatrixValues[j, k + 1])
                            {
                                var temp = _matrix.MatrixValues[j, k];
                                _matrix.MatrixValues[j, k] = _matrix.MatrixValues[j, k + 1];
                                _matrix.MatrixValues[j, k + 1] = temp;
                            }
                        }
                    }
                }
            }

            Print();
        }

        public delegate bool ZeroComparison(int value);
        public delegate void Operation();
    }
}
