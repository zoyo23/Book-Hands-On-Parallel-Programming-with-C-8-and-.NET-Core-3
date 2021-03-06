﻿using System;
using System.Threading.Tasks;

namespace Ch01
{
    class Program
    {
        private static readonly TimeSpan WaitingTimeAfterExecution = TimeSpan.FromSeconds(5);
        static void Main(string[] args)
        {
            //new _1Synchronous().Run();

            //new _2ThreadStart().Run();

            //new _3ParameterizedThreadStart().Run();

            //new _4ThreadPool().Run();

            //new _5BackgroundWorker().Run();

            Task.Delay(WaitingTimeAfterExecution).Wait();
        }
    }
}
