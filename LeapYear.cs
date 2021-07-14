using System;

namespace LeapYearProblem
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            //int year = 2020;
            Console.WriteLine("Enter Year (YYYY) :: ");
            int year = int.Parse(Console.ReadLine());
            if ((year % 4) == 0)
            {
                if ((year % 100) == 0)
                {
                    if ((year % 400) == 0)
                    {
                        Console.WriteLine("This is a leap year");
                    }
                    else
                    {
                        Console.WriteLine("This is not leap year");
                    }
                    
                }
                else
                {
                    Console.WriteLine("This is a leap year");
                }
                
            }
            else
            {
                Console.WriteLine("This is not leap year");
            }
            
        }

    }
}
