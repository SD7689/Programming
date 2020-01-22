using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming
{
    class Distance
    {
        public static void EuclideanDistance()
        {
            int x1 = 0, y1 = 0, x2 = 5, y2 = 5;
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Sqrt(Math.Pow(y2 - y1, 2)));
            Console.WriteLine("Euclidean Distance" + distance);
        }
    }
}
