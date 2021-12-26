using System;
using System. Collections. Generic;
using System.Linq;
namespace MontyHallProblem{
    public class MontyHall{
        //Represents The Three options behind the Doors
        List<string> BaseOptions=new List<string>{"Gold","Goat","Goat"};

        //The following method picks a door randomly and returns the value behind the door
        public string ChooseOne(List<string> Options){
            string choice=Options[new Random().Next(Options.Count)];
            //Console.WriteLine("My choice is : "+choice);
            return choice;
        }

        //The following method checks if our choice is Gold
        public bool IsGold(string choice){
            //Console.WriteLine("Is it Gold? : " + choice.ToLower().Equals("gold"));
            return choice.ToLower().Equals("gold");
        }

        //The following method mix up the initial baseOptions list: it will randomize the list every time
        //returns a new randomly placed BaseOptions
        public List<string> Mix(){
            return BaseOptions.OrderBy(x=>Guid.NewGuid()).ToList();
        }

        //The Switch method will swith our choice after the host show us the door
        public string Switch(string initialChoice){
            if(initialChoice.ToLower().Equals("gold"))
            return "goat";
            else return "gold";
        }

        //Initiates the game n times : we switch every time after the host showed us the door
        //returns the ratio we got gold right after switching
        public double PlaySwitch(double n){
            double right=0;
            for(int i=0;i<n;i++){

                string myChoice=ChooseOne(Mix());

                //check if we get Gold after switching
                if(IsGold(Switch(myChoice))) 
                right++;
            }
            return (Math.Round((right/n)*100,2));
        }

        //Initiates the game n times : we do NOT switch every time after the host showed us the door
        //returns the ratio we got gold right
        public double PlayNoSwitch(double n){
            double right=0;
            for(int i=0;i<n;i++){

                string myChoice=ChooseOne(Mix());

                //check if we get Gold on the first choice
                if(IsGold(myChoice))
                right++;
            }
            return (Math.Round((right/n)*100,2));
        }
    }
}