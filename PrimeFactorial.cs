using System;

namespace PrimeFactors
{
    class PrimeFactorial
    {
        public static void primeFactors(int n)
        {
            while (n%2 == 0)
            {
                Console.WriteLine(2 + " ");
                n /= 2;
            }
            for (int i=3; i<=Math.Sqrt(n); i+=2)
            {
                while (n%i==0)
                {
                    Console.WriteLine(i + " ");
                    n /= i;
                }
            }
            if (n>2)
            {
                Console.WriteLine(n);
            }
        }
        static void Main(string[] args)
        {
            int n = 315;
            primeFactors(n);
        }
    }
}
