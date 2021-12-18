using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace async_practice.task_examples
{
    internal class Basic
    {
        public async static void Main()
        {
            var task1 = new Task(() =>
            {
                Console.WriteLine("Starting task 1");
                Thread.Sleep(1000);
                Console.WriteLine("Task 1 done");
            });

            var task2 = new Task(() =>
            {
                Console.WriteLine("Starting task 2");
                Thread.Sleep(2000);
                Console.WriteLine("Task 2 done");
            });

            Console.WriteLine("Starting all tasks");
            task1.Start();
            task2.Start();
            Console.WriteLine("------------------------------------");

            Console.WriteLine("Begin awaiting");
            await task1;
            await task2;
            Console.WriteLine("------------------------------------");

            Console.WriteLine("All tasks have finished");
            Console.ReadKey();
        }
    }
}
