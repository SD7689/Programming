// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TictaeToe.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming
{
	class TicTacToe
	{
	
			static int player = 0;
			static int[,] BOARD = new int[3, 3];
			static Boolean isEmpty = true;

			public static void initBoard()
			{
				Console.WriteLine("TIC TAC TOE GAME\nComputer is o\nPlayer  is x ");
				for (int i = 0; i <3; i++)
				{
					for (int j = 0; j <3; j++)
					{
						BOARD[i, j] = -10;
					}
				}
			Console.WriteLine("Board is this :");
				dispBoard();
			}

			public static void dispBoard()
			{
				int count = 0;
				for (int i = 0; i < 3; i++)
				{
				Console.WriteLine("---------------");
				Console.WriteLine("||");
					for (int j = 0; j < 3; j++)
					{
						if (BOARD[i, j] == 0)
						{
							count++;
						Console.WriteLine(" o |");
						}
						else if (BOARD[i, j] == 1)
						{
							count++;
						Console.WriteLine(" x |");
						}
						else
						Console.WriteLine("   |");
					}
				Console.WriteLine("|");
				}
				if (count == 9)
				{
					isEmpty = false;
				}
			Console.WriteLine("---------------");
			}
			/*
			 * static void putVal(int i, int j, int player) { if if (player % 2 == 0) {
			 * BOARD[i][j] = 0; } else BOARD[i][j] = 1; }
			 */

			public static void putVal()
			{
				int i;
				int j;
			Random random = new Random();
				if (player % 2 == 1)

				{
					i = (int)(random.Next() * 10) % 3;
					j = (int)(random.Next() * 10) % 3;
				}
				else
				{

				Console.WriteLine("enter value of x and y by space");
					
				i = Utility.readInt();
				j = Utility.readInt();
				}
				if (BOARD[i, j] == -10)
				{
					if (player % 2 == 0)
					{
						BOARD[i, j] = 0;
					}
					else
					{
						BOARD[i, j] = 1;
					Console.WriteLine("Coumputer Choosing " + i + " " + j);
					}
				}
				else
					putVal();

			}

			public static Boolean win()
			{
				return ((BOARD[0, 0] + BOARD[0, 1] + BOARD[0, 2] == player * 3)
						|| (BOARD[1, 0] + BOARD[1, 1] + BOARD[1, 2] == player * 3)
						|| (BOARD[2, 0] + BOARD[2, 1] + BOARD[2, 2] == player * 3)
						|| (BOARD[0, 0] + BOARD[1, 0] + BOARD[2, 0] == player * 3)
						|| (BOARD[0, 1] + BOARD[1, 1] + BOARD[2, 1] == player * 3)
						|| (BOARD[0, 2] + BOARD[1, 2] + BOARD[2, 2] == player * 3)
						|| (BOARD[0, 0] + BOARD[1, 1] + BOARD[2, 2] == player * 3)
						|| (BOARD[2, 0] + BOARD[1, 1] + BOARD[0, 2] == player * 3));
			}

			public static void play()
			{
				initBoard();
				while (isEmpty)
				{
				Console.WriteLine("Players turn");
					putVal();
					dispBoard();
					if (win())
					{
					Console.WriteLine("Player won");
						return;
					}
					player = 1;
				Console.WriteLine("Computers turn");
					putVal();
					dispBoard();
					if (win())
					{
					Console.WriteLine("Computer won");
						return;
					}
					player = 0;
				}
			}
		}
	}

	
