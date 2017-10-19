using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_KevinStanley
{
	class Program
	{
		static void Main(string[] args)
		{
			// 1.)

			//Similar in that they both operate using True/False conditions. 
			//However, the single statement will stop at the first result, whether it is true or false. 
			//The repetition statement will continue until a false statement is reached.


			
			
			// 2.)
			int speedLimit = 35;
			int speed = 42;

			if (speed > speedLimit)
			{
				Console.WriteLine("SLOW DOWN");
			}


			
			
			// 3.)

			//True Statement
			{

				bool isTrue = true;

				if (isTrue)
				{
					Console.WriteLine("It is True!");
				}
				else
				{
					Console.WriteLine("It is False!");
				}

				//False statement

				bool isTrue = false;

				if (isTrue)
				{
					Console.WriteLine("It is True!");
				}
				else
				{
					Console.WriteLine("It is False!");
				}
			}

			
			
			// 4.) 

			double celsius;

			Console.Write("Farenheit: ");

			double fahrenheit = Convert.ToDouble(Console.ReadLine());

			celsius = (fahrenheit - 32) * 5 / 9;

			Console.WriteLine("Celsius conversion:  " + celsius);

			Console.ReadLine();



			
			
			// 5.)

			int i = 1;
			while (i < 11)
			{
				Console.WriteLine(i);

				i++;
			}



			
			
			// 6.)

			int value = 60;
			int j;

			while ((j = value) >= 20)
			{
				Console.WriteLine(j);
				value--;
			}



			
			
			// 7.)

			int i = 10; while (i <= 20)
			{
				Console.WriteLine(i);
				i++;
			}
		}
	}
}
