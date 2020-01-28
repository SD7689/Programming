using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming.JUnitTesting
{
    class DayOfWeek
    {
        public class Calender2DArray
        {
            static int[,] Calender = new int[5, 7];
            static int[] month = {31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}; 

            public static void initCal()
            {
                for(int i =0; i<Calender.Length; i++)
                {
                    for (int j = 0; j < Calender.Length-1; j++)
                    {
                        Calender[i, j] = -10;
                    }
                }
            }
            public static void display(int m)
            {
                Console.WriteLine("Sun Mon Tue Wed Thru Fri Sat");
                for(int i = 0; i<Calender.Length; i++)
                {
                    for(int j =0; j<Calender.Length-1; j++)
                    {
                        if(Calender[i, j] < 0 || Calender[i, j] > month[m - 1])
                        {
                            Console.WriteLine(" \t ");
                        }
                    }
                }
            }
            public static void putCalender(int day)
            {
                int d1 = 1;
                for(int i =d1; i<Calender.Length; i++)
                {
                    Calender[0, i] = d1++;
                }
                for(int i =1; i<Calender.Length; i++)
                {
                    for(int j = 0; j<Calender.Length-1; j++)
                    {
                        Calender[i, j] = d1++;
                    }
                }
            }
           
        }
        public static int dayOfWeek(int month, int day, int year)
        {
            int d = 1;
            int y = year - (14 - month) / 12;
            int x = y + y / 4 - y / 100 + y / 400;
            int m = month + 12 * ((14 - month) / 12) - 2;
            int d1 = (day + x + (31 * m) / 12) % 7;
            return d1;
        }       
    }
}
