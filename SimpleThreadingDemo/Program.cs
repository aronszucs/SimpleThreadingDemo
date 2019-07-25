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
            ThreadStart st = new ThreadStart(Counting);
            Thread t1 = new Thread(st);
            Thread t2 = new Thread(st);


            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            Console.WriteLine("End reached in Main");
            Console.Read();
        }

        static void Counting()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine
                    ("Count: {0}, Thread id: {1}", i, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            }
        }
    }
}
