using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = true ;
            int n ;
            Console.WriteLine("Enter the number of prime numbers you want");

            int[] marks;

            n = Convert.ToInt16(Console.ReadLine());
            Random rnd = new Random();
            marks = new int[n];
            int j = 1;
           for (j =0; j< n; j++)
            {
               int card = rnd.Next(n);
              
               if (card > 2)
               {
                   marks[j] = card;
                    isPrime = true;
                   for (int i = 3; i < card; i++)
                   {
                       if (card % i == 0)
                       {
                           
                           isPrime = false;
                           break;
                       }
                   }

               }
               else
               {
                   card = rnd.Next(n);
               }
            //checking isprime is not true
            if (isPrime)
            {
                Console.WriteLine("Number " + card + " is not prime");
            }
            else
            {
                Console.WriteLine("Number " + card + " is  prime");
            }
            }
           for (j = 0; j < n; j++)
           { 
           Console.WriteLine(marks[j]);
           }
        } 
    }
}
