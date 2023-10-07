using System.Linq.Expressions;

namespace Calculator
{
    internal class InputCorrector
    {
        private List<char> _expression = new List<char>();

        public void GetExpression()
        {
            _expression = Console.ReadLine().ToList();

            if(_expression.Count == 0 )
            {
                return;
            }

            InputCorrection();
        }

        private void InputCorrection()
        {
            var correction = false;

            for(int i = 0; i < _expression.Count; i++)
            {
                if (!SymbolIdentifier.IsSymbolCorrect(_expression[i]) && !SymbolIdentifier.IsOperationSymbol(_expression[i]))
                {
                    _expression.Remove(_expression[i]);
                    i--;
                    correction = true;
                }

                if (SymbolIdentifier.IsOperationSymbol(_expression[i]) && SymbolIdentifier.IsOperationSymbol(_expression[i+1]))
                {
                    _expression.Remove(_expression[i+1]);
                    i--;
                    correction = true;
                }
            }

            if (_expression.Count < 3)
            {
                Menu.WtfInput();
                return;
            }

            if (SymbolIdentifier.IsOperationSymbol(_expression[0]))
            {
                _expression.RemoveAt(0);
                correction = true;
            }

            if (SymbolIdentifier.IsOperationSymbol(_expression[_expression.Count - 1]))
            {
                _expression.RemoveAt(_expression[_expression[_expression.Count - 1]]);
                correction = true;
            }

            if (correction)
            {
                Menu.CorrectionAnnounce();
                foreach (char c in _expression)
                {
                    Console.Write(c);
                }
                
                if(Menu.CorrectionApproving())
                {
                    Calculate();
                }
                else
                {
                    Console.Clear();
                    Menu.Start();
                    GetExpression();
                }

                return;
            }
                        
            Calculate();
        }

        private void Calculate()
        {
            var converter = new ExpressionConverter();
            var numbers = converter.ConvertNumbers(_expression);
            var operations = converter.ConvertOperations(_expression);
            var calculator = new Calculator(numbers, operations);

            calculator.Calculate();
        }
    }
}
