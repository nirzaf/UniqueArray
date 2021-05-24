using System;

namespace UniqueArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = { 4, 5, 3, 1, 6, 4, 2, 4, 5, 1, 2, 4, 5, 7, 8, 3 };

            int[] Numbers2 = new int[10];

            Console.WriteLine("Numbers Array ");
            foreach (int num in Numbers)
            {
                Console.WriteLine(num.ToString());
            }

            foreach (int num in Numbers)
            {

                foreach (int num2 in Numbers2)
                {
                    if (num == num2)
                    { 
                       
                    }
                }           
            }
        }
    }
}
