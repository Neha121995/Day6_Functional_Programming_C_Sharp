using System;

namespace NumberEvenOrOdd
{
    class NumberEvenOrOdd
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter a number : ");
            i = int.Parse(Console.ReadLine());
            if (i%2 == 0)
            {
                Console.WriteLine("This is an even number");
                Console.Read();
            }
            else
            {
                Console.WriteLine("This is an odd number");
                Console.Read();
            }
        }
    }
}
