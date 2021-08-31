
/// Week No. 2		Exercise No. Lab1
/// Solution Name: Week2Labs
/// @author: Balaji Venkataraman
/// Date:  August 30, 2021
///
/// Problem Statement: Ask the user to enter three numbers, calculate the sum and product of
/// these 3 numbers; divide the product by the sum, and display results of division to the screen
/// 
/// 
/// Overall Plan:
/// 1) Print an initial welcoming message to the screen
/// 2) Prompt the user for 3 integers
/// 3) Calculate the sum and product of the integers, and divide the product by the sum
/// 4) Print the division of the product to sum to the screen
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class MyFirstProgram
    {
        static void Main(string[] args)
        {
            // print a message to the screen
            Console.WriteLine("Week 2; Lab 1");
            Console.WriteLine("Hello out there.");
            Console.WriteLine("I will show the importance of type casting datatypes for you.");
            Console.WriteLine("Enter a number, press [Enter], then repeat this twice more :");

            // declare two integer variables
            int n1, n2, n3, sum, prod, div;
            double div1, div2,div3;

            string userInput;
            userInput = Console.ReadLine();
            n1 = Int32.Parse(userInput);
            n2 = Int32.Parse(Console.ReadLine());
            n3 = Int32.Parse(Console.ReadLine());

            // calculate the sum of these two numbers
            sum  = n1 + n2 + n3;
            prod = n1 * n2 * n3;
            div  = prod / sum;
            div1 = (double)(prod / sum);
            div2 = prod / (double)sum;
            div3 = (double)prod / sum;

            // print a message along with the sum of the two numbers
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Output");
            Console.WriteLine("======");
            Console.WriteLine("Your 3 numbers are: " + n1 + ", " + n2 + ", and " + n3);

            Console.WriteLine("The sum of those three numbers       = " + sum);
            Console.WriteLine("The product of those 3 numbers       = " + prod);
            Console.WriteLine("");
            Console.WriteLine("The division of the prod/sum         = " + div);
            Console.WriteLine("The division of the (dbl)(prod/sum)  = " + div1);
            Console.WriteLine("The division of the prod/(dbl)sum    = " + div2);
            Console.WriteLine("The division of the (dbl)prod/sum    = " + div3);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ReadLine();

        }
    }
}