using System;
using MontyHallProblem;

namespace Monty_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            MontyHall monty=new MontyHall();
            
            //Initiate a play 100 times

            //one with no switch
            Console.WriteLine("if you don't switch you have "+ monty.PlayNoSwitch(100)+"% probability of getting the GOLD");

            //one with switching
            Console.WriteLine("if you switch you have "+monty.PlaySwitch(100)+"% probability of getting the GOLD");

            //we should get a higer probability of getting the gold if we switched.
        }
    }
}
