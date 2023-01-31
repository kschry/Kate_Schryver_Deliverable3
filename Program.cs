/*
Author: Kate Schryver
Date: 1/31/2023
Description: Use a loop statement to ask for an integer between 1 and 100, ask for even or odd, 
and then display the output
*/

using System; 

namespace Kate_Schryver_Deliverable3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer number between 1 and 100"); 
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("Specify the series type: Even or Odd");
            string series = Console.ReadLine();

            if (series == "Odd")
            {
                Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + " are: ");
                for (int i = 1; i < input; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }
            if (series == "Even")
            {
                Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + " are: ");
                for (int i = 0; i < input; i = i+2)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}