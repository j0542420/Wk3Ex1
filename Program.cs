﻿using System;
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

            //keep asking them for a value until a valid value is a input
            do
            {
                try
                {
                    //ask the user for the input of the score
                    Console.WriteLine("What is a numeric score (0 to 100)?");
                    //user inputs their score
                    score = Convert.ToDouble(Console.ReadLine());// score will throw a exception if the wrong format number is put
                    if (score < 0 || score > 100)
                    {
                        Console.WriteLine("Invalid input");// this is a custom exception is thrown when number is out of range
                        score = -1;
                    }
                }
                catch (Exception e)
                {
                    //console.writeline($"Error: (e.message)");
                    Console.WriteLine("Invalid input.Please input a valid number");
                }
            } while (score == -1);


            //96.7
            int roundedScore = Convert.ToInt32(Math.Round(score));

            Console.WriteLine(roundedScore);
            int grade = roundedScore / 10;

            //users score is divided by 10 to match with the cases
            switch (grade) 
            {
                //from case 0 to 5 is given a grade of F based on the score


                //gives a grade of D based on the score
                case 10:
                case 9:
                    Console.WriteLine($"The letter grade for score {score} is : A");
                    break;
                //gives a grade of C based on the score
                case 8:
                    Console.WriteLine($"The letter grade for score {score} is : B");
                    break;
                //gives a grade of B based on the score
                case 7:
                    Console.WriteLine($"The letter grade for score {score} is : C");
                    break;
                //gives a grade of A based on the score
                case 6:
                    Console.WriteLine($"The letter grade for score {score} is : D");
                    break;
                //gives a grade of A based on the score
                default:
                    Console.WriteLine($"The letter grade for score {score} is : F");
                    break;
            }
        }
    }
}
