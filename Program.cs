using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number");
            int x = Convert.ToInt32(Console.ReadLine());
            MultiplicationTable(x);
        
        }


       public static void MultiplicationTable(int x)
        {
            //initialize I as 2 and increment the number until it reaches 11 so the answer can be given for multiplying the input number with all numbers until 10
            for (int i = 2; i < 11; i++)
            {
                int answer = x * i;
                Console.WriteLine("{0} * {1} =  {2}", x, i, answer);
            }

        }


    }
}