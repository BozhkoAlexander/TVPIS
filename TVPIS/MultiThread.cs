using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace TVPIS
{
    public class MultiThread
    {
        static object locker = new object();
        Semaphore s;
        Thread[] threads;
        List<long> results;
        public List<DateTime> startTimes;

        int taskCount = 0;
        int dimension = 0;

        public MultiThread(int threadCount, int _dimension)
        {
            taskCount = threadCount;
            s = new Semaphore(0, threadCount);
            results = new List<long>();
            startTimes = new List<DateTime>();
            taskCount = threadCount;
            dimension = _dimension;
        }

        public List<long> ReleaseSemaphore()
        {
            s.Release(taskCount);
            while (true)
            {
                if (results.Count == taskCount)
                {
                    break;
                }
            }
            return results;
        }

        public void Run(object obj)
        {
            s.WaitOne();
            lock (locker)
            {
                startTimes.Add(DateTime.Now);
            }
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int[,] res =  Matrix.CulcMatrix(dimension);
            stopWatch.Stop();
            results.Add(stopWatch.ElapsedMilliseconds);
            s.Release();
        }

        internal void CreateThreads()
        {
            threads = new Thread[taskCount];
            for (int i = 0; i < taskCount; i++)
            {
                threads[i] = new Thread(Run);
                threads[i].Start(i);
            }
        }
    }
}
