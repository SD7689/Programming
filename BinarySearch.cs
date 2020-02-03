using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Programmings
{
    class BinarySearch
    {
       public static void Search()
        {
           
            StreamReader reader = new StreamReader(@"C:\Users\Bridgelabz\Desktop\text.txt");
            string text = reader.ReadToEnd();
            string[] line = text.Split(" ");
            int[] arr = new int[line.Length];
            for(int i=0; i<line.Length; i++)
            {
                arr[i] = Convert.ToInt32(line[i]);
                Console.WriteLine(arr[i]);
            }
            Console.Write("Enter a element to search: ");
            int v = Utility.readInt();
            Array.Sort(arr);
            Utility.Binarysearch(arr, v);
        }
    }
}
