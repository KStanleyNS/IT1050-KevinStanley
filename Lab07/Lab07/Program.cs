using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{

			//1.)

			loop control variable
			int i = 1;
			//loop terminator
			while (i < 9)
			{
				//Counter
				Console.Write("Count ");

				Console.WriteLine(i);

				i += 2; //modify loop control here
			}

			//2.)

			{

				int num1 = 45;
				for (int i = 30; i <= num1; i++)
				{
					if (i % 2 == 0)
					{
						Console.WriteLine("Number {0} is Even", i);
					}
					else
					{
						Console.WriteLine("Number {0} is odd", i);
					}
				}
				Console.ReadKey();

			}

			//3.)

			{
				DateTime CurTime = DateTime.Now;
				if (CurTime.Hour < 12)
				{
					Console.WriteLine("Good Morning");
				}
				else if (CurTime.Hour >= 12 && CurTime.Hour < 18)
				{
					Console.WriteLine("Good Afternoon");
				}
				else
				{
					Console.WriteLine("Good Evening");
				}
				Console.ReadKey();
			}

			//4.) The code is missing an increment varible, i++. I have added it in the correct line.

			int i = 10;
			while (i < 21)
			{
				Console.WriteLine(i);

				i++;
			}

			//5.) The code is missing brackets before and after the console.writeline statements. I have added them.

			for (int i = 0; i < 101; i++)
			{
				Console.WriteLine(i);
				Console.WriteLine("********");
			}

			//6.) 

			for (int i = 1; i <= 10; i++)
			{

				for (int j = i; j <= 10; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}


		}
	}
}