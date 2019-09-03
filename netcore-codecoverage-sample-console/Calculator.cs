using System;

namespace netcore_codecoverage_sample_console
{
	public class Calculator
	{
		public double Sum(double a, double b)
		{
			return a + b;
		}

		public double Substract(double a, double b)
		{
			return a - b;
		}

		public double Multiply(double a, double b)
		{
			return a * b;
		}

		public double Divide(double a, double b)
		{
			if (b == 0)
			{
				throw new DivideByZeroException();
			}

			return a / b;
		}
	}
}