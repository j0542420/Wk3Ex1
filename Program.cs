using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk3Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarations
            int score = 0;
            int A = 0;
            int B = 0;
            int C = 0;
            int D = 0;
            int F = 0;

            //ask the user for the input of the score
            Console.WriteLine("What is a numeric score (0 to 100)?");
            //user inputs their score
            score = Convert.ToInt32(Console.ReadLine());

            switch (score) 
            {
                case 1:
                    Console.WriteLine($"The letter grade for score {score} is : A");
                    break;
                case 2:
                    Console.WriteLine($"The letter grade for score {score} is : B");
                    break;
                case 3:
                    Console.WriteLine($"The letter grade for score {score} is : C");
                    break;
                case 4:
                    Console.WriteLine($"The letter grade for score {score} is : D");
                    break;
                case 5:
                    Console.WriteLine($"The letter grade for score {score} is : F");
                    break;





            }
        }
    }
}
