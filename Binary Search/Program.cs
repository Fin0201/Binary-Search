using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> A = new List<int>() { 3, 5, 2, 1, 7, 4, 19, 4, 5, 9, 10, 11 }; //The list of items going to be searched through.
            int X = 19;

            A.Sort(); //This sorts the list, so the binary search will work with it.


            int itemFound = A.BinarySearch(X); //This will perform a binary search for x using a predefined function.
            Console.WriteLine($"The number {X} was found in position {itemFound}.");
        }
    }
}