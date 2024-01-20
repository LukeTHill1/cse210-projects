using System;

class Program
{
    static void Main(string[] args)
    {
        // Part 1 & 2
        //Console.WriteLine("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;
        
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Try Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Try Lower");
            }
            else
            {
                Console.WriteLine("Congrats, you guessed it!");
            }
        }
    }
}