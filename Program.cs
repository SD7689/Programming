// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Programming.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------

using BasicProgramming;
using System;

namespace Programmings
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" 1. Replace String \n 2. FlipCoin \n 3. LeapYear \n 4. PowerOf2 \n 5. HarmonicNo." +
              " \n 6. PrimeFactor \n 7. WindChill Temperature \n 8. Euclidean distance \n 9. QuadraticEquation " +
              "\n 10. FindTriplets \n 11. Gambler \n 12. 2DArray \n 13. CouponNumber \n 14. StopWatch \n 15. TicTaeToe" +
              "\n 16. Vending Machine \n 17.Day of week \n 18.TemperatureConversion \n 19. MonthlyPayment \n 20. SquareRoot" +
              "\n 21. BinaryConversion \n 22.SwapNibbles \n 23.ResultantNo is Power of two \n 24.BinarySearch");
            int option = Utility.readInt();

            switch (option)
            {
                case 1:
                    ReplaceString.Replace();
                    break;

                case 2:
                    FlipCoin.flipCoin();
                    break;

                case 3:
                    LeapYear.leapYear();
                    break;

                case 4:
                    PowerOf2.printTable();
                    break;

                case 5:
                    Console.WriteLine("Enter a No.");
                    int N = Utility.readInt();
                    Harmonic.harmonic(N);
                    break;

                case 6:
                    Console.WriteLine("Enter a No.");
                    int n = Utility.readInt();
                    PrimeFactor.Primefactor(n);
                    break;

                case 7:
                    Console.WriteLine("Enter Temp in fahrenheit:");
                    double f = Utility.readDouble();
                    Console.WriteLine("Enter wind speed in miles per Hour:");
                    double ws = Utility.readDouble();
                    WindChill.Windchill(f, ws);
                    break;

                case 8:
                    Distance.EuclideanDistance();
                    break;

                case 9:
                    QuadraticEquation.Quadratic();
                    break;

                case 10:
                    int[] arr = { 0, -1, 2, -3, 1 };
                    n = arr.Length;
                    Sumof3No.FindTriplet(arr, n);
                    break;

                case 11:
                    Console.WriteLine("Enter No of times to Gamble:");
                    int NoOfTimes = Utility.readInt();
                    Console.WriteLine("Enter The Amount The Gamble Have:");
                    int Stake = Utility.readInt();
                    Console.WriteLine("Enter The desired Goal:");
                    int Goal = Utility.readInt();
                    Gambler.gamble(NoOfTimes, Stake, Goal);
                    break;

                case 12:
                    Console.WriteLine("\n  Integer 2D array");
                    Console.WriteLine("Enter no. of rows:");
                    int row1 = Utility.readInt();
                    Console.WriteLine("Enter no. of coloms:");
                    int col1 = Utility.readInt();
                    Console.WriteLine("Enter " + row1 * col1 + "values.");
                    Array2D.IntegerArray(row1, col1);
                    break;

                case 13:
                    CouponNumber.couponNumber();
                    break;

                case 14:
                    StopWatch.StopMain();
                    break;

                case 15:
                    TicTacToe.play();
                    break;

                case 16:
                    int amount = Utility.readInt();
                    VendingMachine.countCurrency(amount);
                    break;

                   case 17:
                    DayOfWeek.checkday();
                   break;

                case 18:
                    TemperatureConversion.Conversion();
                    break;

                case 19:
                    MonthlyPayment.Payment();
                    break;

                case 20:
                    Sqrt.Root();
                    break;

                case 21:
                    Console.WriteLine("Enter a Number to Convert: ");
                    n = Utility.readInt();
                    Binary.DecToBinary(n);
                    break;

                case 22:
                    int x = 100;
                    BinarySwaapNibble.SwapNibble(x);
                    break;

                case 23:
                    Console.WriteLine("Enter a number: ");
                    n = Utility.readInt();
                    Console.WriteLine("Resultant no is Power of two :");
                    Console.WriteLine(ResultantPower2.isPowerOfTwo(n) ? "Yes" : "No");
                    break;

                case 24:
                                 
                    break;

                case 25:
                    BubbleSort.Bubblesort();
                    break;

                case 26:
                    Insertion.InsertionSort();
                    break;

                case 27:
                    int[] arreee = { 76, 89, 23, 1, 55, 78, 99, 12, 65, 100 };
                    n = 10;
                    int i = 0;
                    Console.WriteLine("Merge Sort");
                    Console.Write("Initial array is: ");
                    for (i = 0; i < n; i++)
                    {
                        Console.Write(arreee[i] + " ");
                    }
                    MergeSort.mergeSort(arreee, 0, n - 1);
                    Console.Write("\nSorted Array is: ");
                    for (i = 0; i < n; i++)
                    {
                        Console.Write(arreee[i] + " ");
                    }
                    break;

                case 28:
                    Anagram.AnagramString();
                    break;

                case 29:
                    PrimeNoRange.Range();
                    break;

                case 30:
                    String str = "ABC";
                    int z = str.Length;
                    Permutation.permute(str, 0, z - 1);
                    break;

                case 31:
                    String str2 = "DEF";
                    int len = str2.Length;
                    Console.WriteLine("All the permutations of the string are: ");
                    permutationIterative.generatePermutation(str2, 0, len);
                    break;
            }
        }

       
    }
}

