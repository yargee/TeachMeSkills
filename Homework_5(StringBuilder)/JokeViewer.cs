using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokesParser
{
    internal class JokesViewer
    {
        public static void View(IReadOnlyList<string> jokes)
        {
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("\n" + jokes[i] + "\n");
            }
        }
    }
}
