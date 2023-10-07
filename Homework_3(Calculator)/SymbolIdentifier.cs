namespace Calculator
{
    internal static class SymbolIdentifier
    {
        public static bool IsOperationSymbol(char symbol) => symbol switch
        {
            Constants.Multiplication => true,
            Constants.Division => true,
            Constants.Addition => true,
            Constants.Subtraction => true,
            _ => false
        };

        public static bool IsSymbolCorrect(char symbol) => symbol switch
        {
            '0' => true,
            '1' => true,
            '2' => true,
            '3' => true,
            '4' => true,
            '5' => true,
            '6' => true,
            '7' => true,
            '8' => true,
            '9' => true,
            _ => false
        };
    }
}
