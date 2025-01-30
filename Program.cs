using System;
using System.Runtime.CompilerServices;

namespace Oppgave1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int productsQuantity = 0;
                Console.WriteLine("Input number of products:"); 
                string? numbOfProducts = Console.ReadLine();


            
                if (int.TryParse(numbOfProducts, out productsQuantity) && productsQuantity > 0)
                {
                    if (productsQuantity <= 10)
                    {
                        Console.WriteLine("You have 5% discount.");
                        break;
                    }
                    
                    else if (productsQuantity <= 20)
                    {
                        Console.WriteLine("You have 10% discount.");
                        break;
                    }
                    
                    else if (productsQuantity <= 30)
                    {
                        Console.WriteLine("You have 15% discount.");
                        break;
                    }
                    
                    else
                    {
                        Console.WriteLine("You have 20% discount.");
                        break;
                    }   
                } 

                else 
                {
                    Console.WriteLine("Incorrect value. Please try again!");
                }
            }
        }
    }
} 
