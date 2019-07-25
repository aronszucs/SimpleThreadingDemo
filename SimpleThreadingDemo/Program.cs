using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SimpleThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Counting();
            Console.Read();
        }

        static void Counting()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine
                    (string.Format("Count: {0}, Thread id: {1}", i, Thread.CurrentThread.ManagedThreadId));
            }
        }
    }
}
