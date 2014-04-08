using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TVPIS
{
    class MultiThread
    {
        public static Semaphore s;
        public static List<int> results;

        static Random rand = new Random();
        public static int taskCount = 0;

        public static void InitSemaphore(int start, int max)
        {
            s = new Semaphore(start, max);
            results = new List<int>();
            taskCount = max;
        }

        public static Thread[] CreateThreads(int quantity)
        {
            Thread[] threads = new Thread[quantity];
            for (int i = 0; i < quantity; i++)
            {
                threads[i] = new Thread(Run);
                threads[i].Start(i);
            }
            return threads;
        }

        public static List<int> ReleaseSemaphore(int n)
        {
            s.Release(n);
            while (true)
            {
                if (results.Count == taskCount)
                {
                    break;
                }
            }
            return results;
        }

        public static void Run(object obj)
        {
            s.WaitOne();
            int r = rand.Next(20);
            results.Add(r);
            s.Release();
        }
    }
}
