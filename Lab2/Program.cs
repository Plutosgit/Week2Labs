
/// Week No. 2		Exercise No. Lab2
/// Solution Name: Week2Labs
/// @author: Balaji Venkataraman
/// Date:  August 30, 2021
///
/// Problem Statement: Ask the user to enter a number, calculate the number of candies and gumballs
/// redeemable by the player. 
/// Rule #1) Redemption: 10 coupons/candy, 3 coupons/gumball #2) Candies preferred
/// 
/// Overall Plan:
/// 1) Print an initial welcoming message to the screen
/// 2) Prompt the user for an integer representing # of coupons won
/// 3) Calculate the max number of candies & gumballs redeemable
/// 4) Print the results to the screen
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab2
{

    class MyFirstProgram
    {
        // set constants based on the redemption criteria (10 coupons for each candy & 3 coupons for each gumball)
        public const int NUM_COUPONS_FOR_A_CANDY   = 10;
        public const int NUM_COUPONS_FOR_A_GUMBALL = 3;

        static void Main(string[] args)
        {
            // declare variables
            int nNumCouponsWon;
            int nNumCandies, nNumGumballs;
            int nRemainingCouponsAfterCandies, nRemainingCouponsAfterGumballs;

            // print a message to the screen
            Console.WriteLine("Week 2; Lab 2");
            Console.WriteLine("Hello there. I will calculate the number of candies and");
            Console.WriteLine("gumballs redeemable for a given number of coupons won!");
            Console.WriteLine("");
            Console.Write("Enter the number of coupons won: ");
            
            // read the Number of coupons the video game player has won at the arcade
            string userInput;
            userInput = Console.ReadLine();
            nNumCouponsWon = Int32.Parse(userInput);

            // calculate the number of candies & gumballs based on the redemption criteria
            nNumCandies = nNumCouponsWon / NUM_COUPONS_FOR_A_CANDY;
            nRemainingCouponsAfterCandies = nNumCouponsWon % NUM_COUPONS_FOR_A_CANDY;
            nNumGumballs = nRemainingCouponsAfterCandies / NUM_COUPONS_FOR_A_GUMBALL;
            nRemainingCouponsAfterGumballs = nRemainingCouponsAfterCandies % NUM_COUPONS_FOR_A_GUMBALL;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Here are the maximum number of rewards redeemable..");
            Console.WriteLine("===================================================");
            // print output based on calculations 
            Console.WriteLine("Number of Candies the player can redeem with " + nNumCouponsWon + " coupons           = " + nNumCandies);
            Console.WriteLine("Number of Gumballs the player can redeem with " + nNumCouponsWon + " coupons          = " + nNumGumballs);
            Console.WriteLine("Number of remaining coupons after fully redeeming with " + nNumCouponsWon + " coupons = " + nRemainingCouponsAfterGumballs);
            Console.WriteLine("");

        }
    }
}
