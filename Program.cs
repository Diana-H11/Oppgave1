using System;
using System.Runtime.CompilerServices;

namespace Oppgave1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbOfProducts = 0;
            Console.WriteLine("Input number of products:"); 
            numbOfProducts = int.Parse(Console.ReadLine());
        
            if (numbOfProducts <= 0)
            {
                Console.WriteLine("Incorrect value.");
            }
            else if (numbOfProducts <= 10)
            {
                Console.WriteLine("You have 5% discount.");
            }
            else if (numbOfProducts <= 20)
            {
                Console.WriteLine("You have 10% discount.");
            }
            else if (numbOfProducts <= 30)
            {
                Console.WriteLine("You have 15% discount.");
            }
            else
            {
                Console.WriteLine("You have 20% discount.");
            }   
        }
    }
}