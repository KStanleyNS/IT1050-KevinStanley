using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_KevinStanley
{
	class Program
	{
		static void Main(string[] args)
		{

			//#1 Two inputs with sum

			int firstnum;
			int secondnum;
			int sum;

			firstnum = 10;
			secondnum = 15;
			sum = firstnum + secondnum;

			Console.WriteLine(sum);

			//#2 3 Variables with multiplication

			int x;
			int y;
			int z;
			int total;


			x = 15;
			y = 4;
			z = 7;
			total = (x + y) * (z + 10);

			Console.WriteLine(total);

			//#3, Hello 

			Console.WriteLine("Hello\tWorld!");

			Console.WriteLine("Hello\nWorld");

			Console.WriteLine("\"Hello World!\"");

			Console.WriteLine("Hello\\World!");
		}
	}
}
