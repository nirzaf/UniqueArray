using System;
using System.Collections.Generic;
using System.Linq;

namespace UniqueArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = { 4, 5, 3, 1, 6, 4, 2, 4, 5, 1, 2, 4, 5, 7, 8, 3 };

            IEnumerable<int> uniqueItems = Numbers.Distinct<int>();
            Console.WriteLine("Unique array elements using LINQ: " + string.Join(",", uniqueItems));

            Console.ReadLine();
        }
    }
}
