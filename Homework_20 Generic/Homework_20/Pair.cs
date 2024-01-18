namespace Homework_20
{
    internal class Pair<S,T>
    {
        public S? FirstValue { get; }
        public T? SecondValue { get; }

        public Pair(S? first, T? second)
        { 
            FirstValue = first;
            SecondValue = second;
        }
    }    
}
