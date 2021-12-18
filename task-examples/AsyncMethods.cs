using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace async_practice.task_examples
{
    internal class AsyncMethods
    {
        public async static void Main()
        {
            Console.WriteLine($"Random int: {await randomAsync(1, 100)}");
            Console.WriteLine();

            runSomethingAsync(() => Console.WriteLine("Running something..."), 1000);
        }

        static void runSomethingAsync(Action action, int delay)
        {
            var something = new Task(() =>
            {
                Thread.Sleep(delay);
                action();
            });

            something.Start();
        }

        static async Task<int> randomAsync(int min, int max)
        {
            var taskRandom = new Task<int>(() => 
            {
                Thread.Sleep(500);
                return new Random().Next(min, max);
            });

            taskRandom.Start();

            return await taskRandom;
        }


    }
}
