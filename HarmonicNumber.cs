using System;

namespace HarmonicNumber
{
    class HarmonicNumber
    {
        static void Main(string[] args)
        {
            
            float i;
            float result = 0;
            Console.WriteLine("Enter the number : ");
            float n = int.Parse(Console.ReadLine());
            float div = 0;

            for (i=1; i<=n; i++)
            {
                
                div = 1 / i;
                result = result + div;
            }
            Console.WriteLine(result + " is HarmonicNumber number");
        }
    }
}
