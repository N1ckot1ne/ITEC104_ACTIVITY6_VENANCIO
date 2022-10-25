using System;
using System.Collections.Generic;
using System.Linq;

namespace ITEC104_ACTIVITY6_VENANCIO
{
    internal class Program
    {


        public static void Main(string[] args)
        {
                      
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("~ HashSet1 ~");
            hash(out HashSet<int> hash1);

          
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("~ HashSet2 ~");
            hash(out HashSet<int> hash2);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nUNION: {string.Join(" ", hash1.Union(hash2).ToArray())}");
            Console.WriteLine($"\nINTERSECTION: {string.Join(" ", hash1.Intersect(hash2).ToArray())}");
            Console.WriteLine($"\nSET DIFFERENCE: {string.Join(" ", hash1.Except(hash2).ToArray())}");
            Console.ReadLine();
        }

        public static void hash(out HashSet<int> HashSets)
        {
            HashSets = new HashSet<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Element {i + 0} : ");

                HashSets.Add(int.Parse(Console.ReadLine()));

            }
        }
    }
}