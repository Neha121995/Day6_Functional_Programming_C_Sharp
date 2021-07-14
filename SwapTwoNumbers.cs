using System;

namespace SwapTwoNumbers
{
    class SwapTwoNumbers
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10;
            Console.WriteLine("Before swap a = " +a+ "b= "+b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("Afer swap a= "+a+"b= "+b);
        }
    }
}
