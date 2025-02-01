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
            double score = 0;
            

            //ask the user for the input of the score
            Console.WriteLine("What is a numeric score (0 to 100)?");
            //user inputs their score
            score = Convert.ToDouble(Console.ReadLine());

            //users score is divided by 10 to 
            switch (score / 10) 
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine($"The letter grade for score {score} is : F");
                    break;
                case 6:
                    Console.WriteLine($"The letter grade for score {score} is : D");
                    break;
                case 7:
                    Console.WriteLine($"The letter grade for score {score} is : C");
                    break;
                case 8:
                    Console.WriteLine($"The letter grade for score {score} is : B");
                    break;
                case 9:
                    Console.WriteLine($"The letter grade for score {score} is : A");
                    break;
                case 10:
                    Console.WriteLine($"The letter grade for score {score} is : A");
                    break;
            }
        }
    }
}
