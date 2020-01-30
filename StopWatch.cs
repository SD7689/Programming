// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StopWatch.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace Programmings
{
    class StopWatch
    {
        public static void StopMain()
        {
            // Create new stopwatch.
            Stopwatch stopwatch = new Stopwatch();

            // Begin timing.
            stopwatch.Start();

            // Do something.
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1);
            }

            // Stop timing.
            stopwatch.Stop();

            // Write result.
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
        }
    }
}
    

