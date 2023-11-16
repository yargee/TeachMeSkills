using System.Diagnostics;
using System.Threading.Tasks;

namespace BigBigArray
{
    internal class ArrayHandler
    {
        private int[] _array;
        private int _threads;

        public ArrayHandler(int[] array, int threads)
        {
            _array = array;
            _threads = threads;
        }

        public async Task<int> SumAllAsync()
        {
            int sum = 0;
            var tasks = new List<Task<int>>();

            for (int i = 0; i < _threads; i++)
            {
                tasks.Add(SumAsync(i, _threads));
            }


            await Task.WhenAll(tasks);
            for (int i = 0; i < _threads; i++)
            {
                sum += tasks[i].Result;
            }

            return sum;
        }

        private async Task<int> SumAsync(int startIndex, int delta)
        {
            var tempList = new List<int>();
            var sum = 0;
            var sw = new Stopwatch();

            sw.Start();

            for (int i = startIndex; i < _array.Length; i += delta)
            {
                tempList.Add(_array[i]);
            }

            await Task.Run(() =>
            {
            for (int i = 0; i < tempList.Count; i++)
            {
                sum += tempList[i];
            }
            });

            sw.Stop();

            Console.WriteLine($"Thread {startIndex + 1} completed in {sw.ElapsedMilliseconds} ms. Sum: {sum}");

            return sum;
        }
    }
}
