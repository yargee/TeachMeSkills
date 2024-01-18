namespace Homework_20
{
    internal class ComparablePair<S, T> : IComparable<ComparablePair<S, T>> where S : IComparable where T : IComparable
    {
        public S? FirstValue { get; }
        public T? SecondValue { get; }

        public ComparablePair(S? first, T? second)
        {
            FirstValue = first;
            SecondValue = second;
        }

        public int CompareTo(ComparablePair<S, T>? pair)
        {
            if (FirstValue.CompareTo(pair.FirstValue) < 0)
            {
                return -1;
            }
            else if (FirstValue.CompareTo(pair.FirstValue) == 0)
            {
                return SecondValue.CompareTo(pair.SecondValue);
            }
            else
            {
                return 1;
            }
        }
    }
}
