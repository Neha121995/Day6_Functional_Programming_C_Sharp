using System;

namespace PowerOfTwo
{
    class PowerOfTwo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number :: ");
            int n = int.Parse(Console.ReadLine());
            int i;
            int power = 0;
            for (i = 0; i<=n; i++)
            {
                if(i == 0)
                {
                    power = 1;
                }
                else
                {
                    power = power * 2;
                }
                
            }
            Console.WriteLine(power);

        }
    }
}
