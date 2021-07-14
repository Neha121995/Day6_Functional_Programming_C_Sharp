using System;

namespace FlipCoin
{
    class FlipCoin
    {
        static void Main(string[] args)
        {
            int noOfTime;
            int noOfHeads = 0;
            int noOfTails = 0;
            int noOfItration = 0;

            Console.WriteLine("How many times you want to flip the coin :");
            noOfTime = int.Parse(Console.ReadLine());

            
            while (noOfItration <= noOfTime)
            {
                noOfItration++;
                Random random = new Random();
                double coinFlip = random.NextDouble();
                //Console.WriteLine("Check"+coinFlip);


                if (coinFlip < 0.5)
                {
                    Console.WriteLine("You got Tails.");
                    noOfTails++;
                }
                else
                {
                    Console.WriteLine("You got Heads.");
                    noOfHeads++;
                }

            }
            double pHead = noOfHeads * 100 / noOfTime;
            Console.WriteLine("Heads is " + pHead + " Percent ");
            double pTail = noOfTails * 100 / noOfTime;
            Console.WriteLine("Tails is " + pTail + " Percent ");

        }
    }
}
