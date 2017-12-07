using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Hero
    {
        private string Alterego;
        private string Weakness;
        private bool Antihero;
        private string Gender;
        private string Race;

        public string Power;
        public int PowerLevel;
        public double Health;
        public string Weapons;
        public int Age;
        public string Name;
        public string nemesis;

        public Hero()
        {

        }

        public Hero(string name, string nemesis, string race, string power) //constructor method
        {
            this.Name = name;
            this.nemesis = nemesis; //this. defines the property, not the parameter.
            this.Race = race;
            this.Power = power;
        }

        public Hero(string name, string nemesis, string race, string power, bool antihero) //constructor method
        {
            this.Name = name;
            this.nemesis = nemesis;
            this.Race = race;
            this.Power = power;
            this.Antihero = antihero;

        }

        //TODO: Problem 1 - Add a constructor method with a different number and/or types of parameters.

        public void FightCrime(string address)
        {
            //TODO: Problem 2 - Output "Successfully fought crime at #address# if PowerLevel > 49.
        }

        private bool Investigate()
        {
            //TODO: Problem 3 - output "Investigated Crime" and return true
            bool returnValue = true;
            return returnValue;
        }

        public void Fly()
        {
            //TODO: Problem 4 - if Power contains Fly, then output "#Name# is flying", else output "#Name# can't fly!".

        }

        public void Craft(string material, int numMaterials)
        {
            Console.WriteLine("Text" +material);
        }

        public void Climb(int height)
        {
            Console.WriteLine(this.Name + "is climbing");
        }

        public void GetLoyalty()
        {

        }

        public void HeroStuff()
        {

        }

        public int ChargePower()
        {
            //TODO: Problem 4 - Increase this.Power by 1
            return PowerLevel;
        }

        // Add an overloaded method ChargePower that has a parameter for increaseAmount. 
        // Add IncreaseAmount to this.Power and return the new value for this.Power



    }
}