using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace Programmings
{
    class Utility
    {
        public static int readInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public static string readString(string v)
        {
            string s = Console.ReadLine();
            return s;
        }

        public static String readString()
        {
            String s = Console.ReadLine();
            return s;
        }
        public static double readDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        public static bool readBool()
        {
            return Convert.ToBoolean(Console.ReadLine());
        }

        /// <summary>
        /// Power2s the specified pow.
        /// </summary>
        /// <param name="pow">The pow.</param>
        /// <param name="val">The value.</param>
        public static void Power2(int pow, int val)
        {
            if (pow < 32)
            {
                for (int i = 1; i <= pow; i++)
                {
                    val = val * 2;
                    Console.WriteLine(val);
                }
            }
            else
            {
                Console.WriteLine("Enter the correct input");
            }
        }

        /// <summary>
        /// Factors the specified n.
        /// </summary>
        /// <param name="n">The n.</param>
        public static void Factor(int n)
        {
            while (n % 2 == 0)
            {
                Console.Write(2 + " ");
                n /= 2;
            }

            //For odd No.
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                while (n % i == 0)
                {
                    Console.Write(i + " ");
                    n /= 2;
                }
            }
            if (n > 2)
                Console.Write(n);
        }

        /// <summary>
        /// Integerarrays the specified row.
        /// </summary>
        /// <param 2D Array="row">The row.</param>
        /// <param 2D array="col">The col.</param>
        public static void integerarray(int row , int col)
        {
            int[,] arr = new int[row, col];

            for(int i = 0; i< row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                   
                    arr[i, j] = Utility.readInt();

                }
            }
            for(int i = 0; i < row; i++)
            {
                for(int j=0; j<col; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }

        /// <summary>
        /// Anagrams the strings.
        /// </summary>
        /// <param name="str1">The STR1.</param>
        /// <param name="str2">The STR2.</param>
        public static bool AnagramStrings(string str1, string str2)
        {
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1 == val2)
            {
                return true;
                //Console.WriteLine("Both strings Are Anagram.");
            }
            else
            {
                return false;
                //Console.WriteLine("Both the strings are not Anagrams.");
            }
        }

        /// <summary>
        /// Binaries to decimal.
        /// </summary>
        /// <param name="n">The n.</param>
        public static void BinaryToDec(int n)
        {
            int[] binaryNum = new int[32];
            int i = 0;
            while (n > 0)
            {
                binaryNum[i] = n % 2;
                n = n / 2;
                i++;
            }
            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write(binaryNum[j]);
            }
        }

        public static void Bubblesorting()
        {
            int[] arr = { 67, 58, 45, 36, 13 };
            int temp;
            for (int j = 0; j < arr.Length - 1; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted array:");
            foreach (int p in arr)
            {
                Console.WriteLine(p + " ");
            }
        }

        /// <summary>
        /// Randoms the number generator.
        /// </summary>
        /// <param name="N">The n.</param>
        public static void RandomNumberGenerator(int N)
        {
            //Created a Random object
            Random r = new Random();
            string couponNo = "";
            int Count = 0;
            for (int i = 0; i < N; i++)
            {
                int ran = r.Next(0, 10);
                Count += 1;
                if (couponNo.Contains(ran.ToString()))
                {
                    i -= 1;
                }
                else
                {
                    couponNo += ran;
                }
                Console.WriteLine("Total Randoms needed:" + Count);
                Console.WriteLine("Coupon Code: " + couponNo);
            }
        }

        /// <summary>
        /// Days the of week.
        /// </summary>
        /// <param name="y">The y.</param>
        /// <param name="m">The m.</param>
        /// <param name="d">The d.</param>
        public static void DayOfWeek(int y, int m, int d)
        {
            string[] month = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            string[] Day = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thrusday", "Friday", "Saturday" };
            int y0 = y - (14 - m) / 12;
            int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;
            Console.WriteLine("It's " + Day[d0] + " on " + d + " " + month[m - 1] + ", " + y);
        }

        /// <summary>
        /// Distances the eucldiean.
        /// </summary>
        /// <param name="x1">The x1.</param>
        /// <param name="x2">The x2.</param>
        /// <param name="y1">The y1.</param>
        /// <param name="y2">The y2.</param>
        public static void DistanceEucldiean(int x1, int x2, int y1, int y2)
        {
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Sqrt(Math.Pow(y2 - y1, 2)));
            Console.WriteLine("Euclidean Distance" + distance);
        }
        /// <summary>
        /// Flips the specified n.
        /// </summary>
        /// <param name="n">The n.</param>
        public static void flip(int n)
        {
             int head = 0;
             int Tail = 0;
            //Random Object Created
            Random r = new Random();          
            for (int i = 0; i < n; i++)
            {
                int num = r.Next(1, 10);
                if (num > 5)
                {
                    head++;
                }
                else
                {
                    Tail++;
                }
            }
            Console.WriteLine($"The percentage of Head is : {(double)head * 100 / n}");
            Console.WriteLine($"The percentage of Tail is : {(double)Tail * 100 / n}");
        }


        /// <VendingMachine>
        /// Counts the currency.
        /// </summary>
        /// <param name="amount">The amount.</param>
        public static void countCurrency(int amount)
        {
            int[] notes = new int[] { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
            int[] noteCounter = new int[9];

            //Count notes using greedy approach
            for (int i = 0; i < 9; i++)
            {
                if (amount >= notes[i])
                {
                    noteCounter[i] = amount / notes[i];
                    amount = amount - noteCounter[i] * notes[i];
                }
            }
            //Print Notes
            Console.WriteLine("Currency Count -->");
            for (int i = 0; i < 9; i++)
            {
                if (noteCounter[i] != 0)
                {
                    Console.WriteLine(notes[i] + " : " + noteCounter[i]);
                }
            }
        }


        /// <summary>
        /// Windchills the specified f.
        /// </summary>
        /// <param name="f">The f.</param>
        /// <param name="ws">The ws.</param>
        public static void Windchill(double f, double ws)
        {
            double w = 35.74 + 0.62158 * f + (0.4275 * f - 35.75) * Math.Pow(ws, 0.16);
            Console.WriteLine(w);

            try
            {
                if (Math.Abs(f) > 50 || ws > 120 || ws < 3)
                {
                    Console.WriteLine("Enter Correct Output");
                }
                else
                {
                    Windchill(f, ws);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("enter proper output");
            }
        }


        /// <summary>
        /// Gambles the specified no of times.
        /// </summary>
        /// <param name="NoOfTimes">The no of times.</param>
        /// <param name="Stake">The stake.</param>
        /// <param name="Goal">The goal.</param>
        public static void gamble(int NoOfTimes, int Stake, int Goal)
        {
            int bets = 0;
            int wins = 0;
            Random r = new Random();

            for (int i = 0; i < NoOfTimes; i++)
            {
                int cash = Stake;
                int random = r.Next(0, 10);
                while (cash > 0 && cash < Goal)
                {
                    bets++;
                    if (random < 5)
                        cash++;
                    else
                        cash--;
                }
                if (cash == Goal)
                    wins++;
            }
            Console.WriteLine();
            Console.WriteLine(wins + "Wins out of :" + NoOfTimes);
            Console.WriteLine("Percentage of games won = " + 100 * wins / NoOfTimes);
            Console.WriteLine("Total no of bets : " + NoOfTimes + " Games = " + bets);
        }
        /// <summary>
        /// Harmonics the specified n.
        /// </summary>
        /// <param name="N">The n.</param>
        public static void Harmonic(int N)
        {
            double i, h = 0;
            for (i = 1; i <= N; i++)
                h = h + 1 / i;

            Console.WriteLine("HArmonic no is : " + h);
        }

        /// <summary>
        /// Insertions   sort.
        /// </summary>
        public static void InsertionSort()
        {
            int[] arr = new int[10] { 23, 9, 56, 86, 78, 45, 3, 45, 32, 23 };
            int n = 10, j, i, val, flag;
            Console.WriteLine("Insertion Sort -");
            Console.WriteLine("Intial Array is: ");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i] + "");
            }
            for (i = 1; i < n; i++)
            {
                val = arr[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else
                    {
                        flag = 1;
                    }
                }
                Console.WriteLine(" Sorted array is :");
                for (i = 0; i < n; i++)
                {
                    Console.WriteLine(arr[i] + "");
                }
            }
        }

        /// <summary>
        /// Merge Sort
        /// Merges the specified arr.
        /// </summary>
        /// <param name="arr">The arr.</param>
        /// <param name="p">The p.</param>
        /// <param name="q">The q.</param>
        /// <param name="r">The r.</param>
        static public void merge(int[] arr, int p, int q, int r)
        {
            int i, j, k;
            int n1 = q - p + 1;
            int n2 = r - q;
            int[] L = new int[n1];
            int[] R = new int[n2];
            for (i = 0; i < n1; i++)
            {
                L[i] = arr[p + i];
            }
            for (j = 0; j < n2; j++)
            {
                R[j] = arr[q + 1 + j];
            }
            i = 0;
            j = 0;
            k = p;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
        static public void mergeSort(int[] arr, int p, int r)
        {
            if (p < r)
            {
                int q = (p + r) / 2;
                mergeSort(arr, p, q);
                mergeSort(arr, q + 1, r);
                merge(arr, p, q, r);
            }
        }

        /// <summary>
        /// Take a range of 0 - 1000 Numbers and find the Prime numbers in that range.
        /// </summary>
        /// <param name="num">The number.</param>
        /// <param name="i">The i.</param>
        /// <param name="ctr">The CTR.</param>
        /// <param name="stno">The stno.</param>
        /// <param name="enno">The enno.</param>
        public static string PrimeRange()
        {
            string s = "";
            int num, i,  ctr , stno=1 , enno=1000;
            Console.Write("The prime numbers between {0} and {1} are : \n", stno, enno);
            for (num = stno; num <= enno; num++)
            {
                ctr = 0;
                for (i = 2; i <= num/2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }
                if (ctr == 0 && num != 1)
                {
                    s = s+ num + " ";
                }
                
            }
            Console.WriteLine(s);
            return s;
        }

        /// <summary>
        /// Leap Year
        /// </summary>
        /// <param name="n">The n.</param>
        public static void Leap(int n)
        {
            if (n < 3)
                Console.WriteLine("Enter a Valid Year:");
            else
                Console.WriteLine("Valid Year" + n);
            Boolean leap = false;
            if (n % 4 == 0)
            {
                if (n % 100 == 0)
                {
                    if (n % 400 == 0)
                        leap = true;
                    else
                        leap = false;
                }
                else
                    leap = true;
            }
            else
                leap = false;

            if (leap)
                Console.WriteLine("The Given Year is Leap Year:" + n);
            else
                Console.WriteLine("The Given Year is Not a Leap Year:" + n);
        }

        /// <summary>
        /// Write a program Quadratic.java to find the roots of the equation a*x*x + b*x + c.
        /// Since the equation is x*x, hence there are 2 roots.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <param name="c">The c.</param>
        public static void Quad(double a, double b, double c)
        {
            double D, X1, X2;

            if (a != 0)
            {
                D = b * b - 4 * a * c;
            }
            else
            {
                Console.WriteLine("Quadratic Eq not Possible.");
            }
            D = b * b - 4 * a * c;
            if (D >= 0)
            {
                D = Math.Sqrt(D);
                X1 = (-b + D) / (2 * a);
                X2 = (-b - D) / (2 * a);
                Console.WriteLine("Root X1 = " + X1);
                Console.WriteLine("Root X2 = " + X2);
            }
            else
            {
                Console.WriteLine("Roots are not Possible.");
            }
        }

        /// <summary>
        /// Determines whether [is power of two] [the specified n].
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns>
        ///   <c>true</c> if [is power of two] [the specified n]; otherwise, <c>false</c>.
        /// </returns>
        public static bool isPowerOfTwo(int n)
        {

            if (n == 0)
                return false;

            while (n != 1)
            {
                if (n % 2 != 0)
                    return false;

                n = n / 2;
            }
            return true;
        }

        /// <StopWatch_Program>
        /// Stops the main.
        /// </summary>
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

        /// <summary>
        /// Write a Util Static Function to calculate monthlyPayment that reads in three command-line arguments P, Y, 
        /// and R and calculates the monthly payments you would have to make over Y years to pay off a P principal loan amount at R per cent interest compounded monthly.
        /// </summary>
        /// <param name="R">The r.</param>
        /// <param name="P">The p.</param>
        /// <param name="Y">The y.</param>
        public static void Payment(double R, double P, double Y)
        {
            double n = 12 * Y;
            double r = R / (12 * 100);

            double payments = (P * r) / (1 - Math.Pow(1 + r, -n));
            double interest = payments * n - P;

            Console.WriteLine("Monthly payment is: " + payments);
            Console.WriteLine("Intrest rate is: " + interest);
        }

        

        /// <summary>
        /// static functions to return all permutations of a String using Recursive metho
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="l">The l.</param>
        /// <param name="r">The r.</param>
        public static void permute(String str,
                                int l, int r)
        {
            if (l == r)
                Console.WriteLine(str);
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = swap(str, l, i);
                    permute(str, l + 1, r);
                    str = swap(str, l, i);
                }
            }
        }

        /// <summary>
        /// Binary Search
        /// </summary>
        /// <param name="arr"></param>
        public static void Binarysearch(int[] arr, int v)
        {
            int n = arr.Length;
            int low = 0;
            int high = n;          
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if ( arr[mid] == v)
                {
                    Console.WriteLine();
                    Console.WriteLine("Element found in:" +mid);
                    break;
                }
                else if (v < arr[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
        }
            /** 
            * Swap Characters at position 
            * @param a string value 
            * @param i position 1 
            * @param j position 2 
            * @return swapped string 
            */
            public static String swap(String a,
                                  int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }



        /// <summary>
        ///static functions to return all permutations of a String using iterative metho
        /// </summary>
        /// <param name="sequence">The sequence.</param>
        /// <param name="count">The count.</param>
        public static void RotateRight(IList sequence, int count)
        {
            object tmp = sequence[count - 1];
            sequence.RemoveAt(count - 1);
            sequence.Insert(0, tmp);
        }

        public static IEnumerable<IList> Permutate(IList sequence, int count)
        {
            if (count == 1) yield return sequence;
            else
            {
                for (int i = 0; i < count; i++)
                {
                    foreach (var perm in Permutate(sequence, count - 1))
                        yield return perm;
                    RotateRight(sequence, count);
                }
            }
        }
        public static void PermutateStringTest(string a)
        {
            
            foreach (List<char> perm in Permutate(a.ToCharArray().ToList(), a.Length))
            {
                string s = new string(perm.ToArray());
                Console.Write(s + "\t");
            }
            Console.WriteLine();
        }
    }
}
