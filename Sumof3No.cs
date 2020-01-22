using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming
{
    class Sumof3No
    {
        public static void FindTriplet(int [] arr , int n)
        {
            bool found = false;

            for(int i = 0; i< n-1; i++)
            {
                //Find all pairs with sum equals to
                //"-arr[i]"
                HashSet<int> s = new HashSet<int>();
                for (int j = i + 1; j < n; j++)
                {
                    int x = -(arr[i] + arr[j]);
                    if(s.Contains(x))
                    {
                        Console.Write("{0} {1} {2} \n", x, arr[i], arr[j]);
                        found = true;
                    }
                    else
                    {
                        s.Add(arr[j]);
                    }
                }
            }
            if(found == false)
            {
                Console.Write("No tripplets Found\n");
            }
        }
    }
}
