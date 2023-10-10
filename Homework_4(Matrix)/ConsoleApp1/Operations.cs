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
            _matrix.PrintColored(IsNegative);
        }

        private void ShowPositive()
        {
            _matrix.PrintColored(IsPositive);
        }

        public void SortColumnsAscending()
        {
            _matrix.SortColumns();
        }

        public void SortColumnsDecreasing()
        {
            _matrix.SortColumns(false);
        }



        public Operation SelectOperation(int index) => index switch
        {
            1 => ShowPositive,
            2 => ShowNegative,
            3 => SortColumnsAscending,
            4 => SortColumnsDecreasing,
            5 => ShowPositive,
        };

        public delegate bool ZeroComparison(int value);
        public delegate void Operation();
    }
}
