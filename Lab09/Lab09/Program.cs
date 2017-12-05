using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
	class MyMath
	{
		static void Main(string[] args)
		{ }
			
		public int operand1;
		public int operand2;
		public int result;

		public int Add(int i, int b)
		{
			operand1 = i;
			operand2 = b;
			result = i + b;
			return result;
		}

		public void int Multiply(int i, int b)
		{
			return i * b;
		}

		public void int Divide(int i, int b)
		{
			return i / b;
		}

		public void int Subtract(int i, int b)
		{
			return i - b;
		}

	}
}
}
