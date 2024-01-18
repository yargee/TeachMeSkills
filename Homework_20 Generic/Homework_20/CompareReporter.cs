using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_20
{
    internal class CompareReporter
    {
        public void Report<S,T>(ComparablePair<S,T> first, ComparablePair<S, T> second) where S : IComparable where T : IComparable
        {
            switch (first.CompareTo(second))
            {
                case -1:
                    Console.WriteLine($"pair {first.FirstValue};{first.SecondValue} < pair {second.FirstValue};{second.SecondValue}.");
                    break;
                case 0:
                    Console.WriteLine($"pair {first.FirstValue};{first.SecondValue} = pair {second.FirstValue};{second.SecondValue}.");
                    break;
                case 1:
                    Console.WriteLine($"pair {first.FirstValue};{first.SecondValue} > pair {second.FirstValue};{second.SecondValue}.");
                    break;
                default:
                    Console.WriteLine("Что-то пошло не так");
                    break;
            }
        }
    }
}
