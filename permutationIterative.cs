// --------------------------------------------------------------------------------------------------------------------
// <copyright file=PermutationIterative.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Shivam Dewangan"/>
// 
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programmings
{
    class permutationIterative
    {
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
        public static void PermutateStringTest()
        {
            string a = "word";
            foreach (List<char> perm in Permutate(a.ToCharArray().ToList(), a.Length))
            {
                string s = new string(perm.ToArray());
                Console.Write(s + "\t");
            }
            Console.WriteLine();
        }
    }
}

