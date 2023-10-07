namespace Calculator
{
    internal class Calculator
    {
        private List<decimal> _numbers = new List<decimal>();
        private List<char> _operations = new List<char>();

        //Хз, может тут нет смысла заморачиваться и просто передавать листы по ссылке? Но ведь за такое бьют?
        public Calculator(IReadOnlyList<decimal> numbers, IReadOnlyList<char> operations)
        {
            foreach (var n in numbers)
            {
                _numbers.Add(n);
            }

            foreach (var c in operations)
            {
                _operations.Add(c);
            }
        }

        public void Calculate()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            CalculatePriorityOperations();
            CalculateOtherOperations();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Decimal.Round(_numbers[0], 5));
            Console.ForegroundColor = ConsoleColor.White;
        }

        private void CalculatePriorityOperations()
        {
            var breakingIndex = 0;

            while (ContainsPriorityOperations())
            {
                for (int i = 0; i < _operations.Count; i++)
                {
                    if (_operations[i] == Constants.Multiplication)
                    {
                        breakingIndex = i;
                        _numbers[i] = _numbers[i] * _numbers[i + 1];
                        _numbers.RemoveAt(i + 1);
                        break;
                    }
                    else if (_operations[i] == Constants.Division)
                    {
                        breakingIndex = i;
                        _numbers[i] = _numbers[i] / _numbers[i + 1];
                        _numbers.RemoveAt(i + 1);
                        break;
                    }
                }

                if (_operations.Count > 0)
                {
                    _operations.RemoveAt(breakingIndex);
                }

                ShowExpression();
            }
        }

        private void CalculateOtherOperations()
        {
            var breakingIndex = 0;

            while (_operations.Count > 0)
            {
                for (int i = 0; i < _operations.Count; i++)
                {
                    if (_operations[i] == Constants.Addition)
                    {
                        breakingIndex = i;
                        _numbers[i] = _numbers[i] + _numbers[i + 1];
                        _numbers.RemoveAt(i + 1);
                        break;
                    }
                    else if (_operations[i] == Constants.Subtraction)
                    {
                        breakingIndex = i;
                        _numbers[i] = _numbers[i] - _numbers[i + 1];
                        _numbers.RemoveAt(i + 1);
                        break;
                    }
                }

                if (_operations.Count > 0)
                {
                    _operations.RemoveAt(breakingIndex);
                }

                ShowExpression();
            }
        }

        private void ShowExpression()
        {
            Console.WriteLine("****** ПРОМЕЖУТОЧНЫЙ ЭТАП ВЫЧИСЛЕНИЙ ******");
            for (int i = 0; i < _operations.Count; i++)
            {
                Console.Write(_numbers[i] + " " + _operations[i] + " ");
            }

            Console.Write(_numbers[_numbers.Count - 1]);
            Console.WriteLine();
        }

        private bool ContainsPriorityOperations()
        {
            foreach (var operation in _operations)
            {
                if (operation == Constants.Multiplication || operation == Constants.Division)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
