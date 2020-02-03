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
              "\n 16. Vending Machine \n 17. Day of week \n 18. TemperatureConversion \n 19. MonthlyPayment \n 20. SquareRoot" +
              "\n 21. BinaryConversion \n 22. SwapNibbles \n 23. ResultantNo is Power of two \n 24. BinarySearch \n 25. BubbleSort" +
              "\n 26. Insertion Sort \n 27. Merge Sort \n 28. Anagram \n 29. Prime btw 1-1000 \n 30. Permutation Recursive \n 31. Permutation Iterartion ");
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
                    LeapYear.LeapYears();
                    break;

                case 4:
                    PowerOf2.PrintTable();
                    break;

                case 5:                  
                    Harmonic.HarmonicNo();
                    break;

                case 6:                    
                    PrimeFactor.Primefactor();
                    break;

                case 7:
                    WindChill.Chill();
                    break;

                case 8:
                    Distance.EuclideanDistance();
                    break;

                case 9:
                    QuadraticEquation.Quadratic();
                    break;

                case 10:
                    Sumof3No.SumZero();
                    break;

                case 11:                   
                    Gambler.Gambling();
                    break;

                case 12:
                    Array2D.IntegerArray();
                    break;

                case 13:
                    CouponNumber.couponNumber();
                    break;

                case 14:
                    StopWatch.Watch();
                    break;

                case 15:
                    TicTacToe.TictaeToeGame();
                    break;

                case 16:
                    VendingMachine.Atm();
                    break;

                case 17:
                    DayOfWeek.checkday();
                    break;

                case 18:
                    TemperatureConversion.Conversion();
                    break;

                case 19:
                    MonthlyPayment.PaymentMonthly();
                    break;

                case 20:
                    Sqrt.Root();
                    break;

                case 21:                  
                    Binary.DecToBinary();
                    break;

                case 22:             
                    BinarySwaapNibble.SwapNibble();
                    break;

                case 23:
                    ResultantPower2.Resultant();
                    break;

                case 24:
                    BinarySearch.Search();
                    break;

                case 25:
                    BubbleSort.Bubblesort();
                    break;

                case 26:
                    Insertion.InsertionSorting();
                    break;

                case 27:
                    MergeSort.Mergesorting();
                    break;

                case 28:
                    Anagram.AnagramString();
                    break;

                case 29:
                    PrimeNoRange.Range();
                    break;

                case 30:
                    Permutation.Recursion();
                    break;

                case 31:
                    permutationIterative.Iterative();
                    break;

                case 32:
                    PlaindromePrimeNo.AnagramPrime();
                    //PlaindromePrimeNo.Palindrome();
                    break;
            }
        }


    }
}

