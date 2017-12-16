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
		private int increaseAmount;
		public double Health;
		public string Weapons;
		public int Age;
		public string Name;
		public string nemesis;
		

		public Hero()
		{
		}

		public Hero(string name, string nemesis, string race, string power, int powerlevel)
		{
			this.Name = name;
			this.nemesis = nemesis;
			this.Race = race;
			this.Power = power;
			this.PowerLevel = powerlevel;

		}

		public Hero(string name, string nemesis, string race, string power, bool antihero, int powerlevel)
		{
			this.Name = name;
			this.nemesis = nemesis;
			this.Race = race;
			this.Power = power;
			this.Antihero = antihero;
			this.PowerLevel = powerlevel;
			
		}

		public Hero(string name, string race, string weakness, string power, string gender, int powerlevel)
		{
			this.Name = name;
			this.Race = race;
			this.Weakness = weakness;
			this.Power = power;
			this.Gender = gender;
			this.PowerLevel = powerlevel;
		}


		public void FightCrime(string address) 

		{
			if (this.PowerLevel > 49)
			{
				Console.WriteLine("Successfully Fought Crime at" + address);
			}
			
		}

		private bool Investigate()
		{
			bool returnValue = true;
			if (returnValue == true)
			{
				Console.WriteLine("Investigated Crime");
			}
			else
			{
				Console.WriteLine("Did not Investigate Crime");
			}
			return returnValue;
		}

		public void Fly()
		{
			
			if (this.Power.Contains("Fly"))
			{
				Console.WriteLine(Name + "is flying!");
			}

			else
			{
				Console.WriteLine(Name + "can't fly!");
			}
		}

		public void Craft(string material, int numMaterials)
		{
			Console.WriteLine("Crafting with " + material);
		}

		public void Climb(int height)
		{
			Console.WriteLine(this.Name + "is climbing");
		}

		public int ChargePower(int powerlevel)
		{
			this.PowerLevel =+ 1;
			return PowerLevel;
		}

		public int ChargePower(int powerlevel, int increaseamount)
		{
			this.PowerLevel = +1;
			increaseAmount = +1;
			return PowerLevel;
		}

	}
}