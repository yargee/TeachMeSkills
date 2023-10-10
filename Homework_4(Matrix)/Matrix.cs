namespace Matrix
{
    internal class Matrix
    {
        private int _columns;
        private int _rows;
        private int[,] _matrix;

        public int[,] MatrixValues => _matrix;

        public Matrix(int columns, int rows, List<int> manualImputValues = null)
        {
            _columns = columns;
            _rows = rows;

            var matrix = new int[columns, rows];
            var random = new Random();

            if (manualImputValues == null)
            {
                for (int i = 0; i < columns; i++)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        matrix[i, j] = random.Next(-99, 100);
                    }
                }
            }
            else
            {
                var i = 0;

                for (int c = 0; c < columns; c++)
                {
                    for (int r = 0; r < rows; r++)
                    {
                        matrix[c, r] = manualImputValues[i];
                        i++;
                    }
                }
            }

            _matrix = matrix;
        }
    }
}
