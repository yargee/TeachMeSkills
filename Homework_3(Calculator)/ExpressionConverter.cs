namespace Calculator
{
    internal class ExpressionConverter
    {
        public IReadOnlyList<decimal> ConvertNumbers(List<char> expression)
        {
            var numbers = new List<decimal>();
            var number = "";

            for(int i = 0; i < expression.Count; i++)
            {
                if (!SymbolIdentifier.IsOperationSymbol(expression[i]))
                {
                    number+= expression[i];
                }
                else
                {
                    numbers.Add(Convert.ToDecimal(number));
                    number = "";
                }

                if(i ==  expression.Count - 1)
                {
                    numbers.Add(Convert.ToDecimal(number));
                    number = "";
                }
            }
            return numbers;
        }

        public IReadOnlyList<char> ConvertOperations(List<char> expression)
        {
            var operations = new List<char>();

            foreach (var c in expression)
            {
                if (SymbolIdentifier.IsOperationSymbol(c))
                {
                    operations.Add(c);
                }
            }

            return operations;
        }        
    }
}
