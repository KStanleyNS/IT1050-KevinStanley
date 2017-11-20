using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050_Midterm
{
	class Program
	{
		static void Main(string[] args)

		// 1.)

		{
			while (true)
			{
				bool keepLooping = true;
				while (keepLooping == true)
				{
					Console.WriteLine("Loop");
				}
			}
		}




		// 2.)

		{
			int i = 2;

			while (i < 128)
			{

				Console.WriteLine("[" + i + "]");


				i += 2;


			}
		}




		// 3.)

		{

			for (int i = 49; i >= 1; i--)
			{
				Console.Write(i + (i != 1 ? "," : ""));
			}

			Console.WriteLine();
		}




		//  4.)
		{
			int i = -1;
			while (i <= 20)
			{
				i = i + 2;
				Console.Write(i + (i != -1 ? "   " : ""));
			}

			Console.Read();


		}



		// 5.) // Do-While Loop will print a single asterisk. The normal While Loop does not print anything.
		{
			int n = 8;
			int i = 10;
			while (i < n)
			{

				Console.WriteLine("*");


				i++;
			}
		}






		// 6.)

		{

			bool icyRain = true;
			bool tornadoWarning = true;
			string name = "Let's go outside";

			if ((icyRain) & (tornadoWarning))
			{
				Console.WriteLine("{0}", name);
			}
		}




	}
}