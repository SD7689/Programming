// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Array2D.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------
﻿
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming
{
    class Array2D
    {
        public static void IntegerArray(int row , int col)
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
        /// Double array print
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        public static void DoubleArray(int row, int col)
        {
            int[,] arr = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i, j] = Utility.readInt();
                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
        //Boolean array printing
        public static void BooleanArray(int row, int col)
        {

            int[,] arr = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i, j] = Utility.readInt();
                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
