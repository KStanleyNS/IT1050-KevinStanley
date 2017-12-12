using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
	class MyMath
	{

		public double result;
		public double operand1;
		public double operand2;


		public void Multiply(double operand1, double operand2)
		{
			this.operand1 = operand1;
			this.operand2 = operand2;
		}
		public void Divide(double operand1, double operand2)
		{
			this.operand1 = operand1;
			this.operand2 = operand2;
		}
		public void Subtract(double operand1, double operand2)
		{
			this.operand1 = operand1;
			this.operand2 = operand2;
		}
		public void Add(double operand1, double operand2)
		{
			this.operand1 = operand1;
			this.operand2 = operand2;
		}


		public double Result { get; }
	}
}
