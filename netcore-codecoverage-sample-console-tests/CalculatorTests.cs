using netcore_codecoverage_sample_console;
using Xunit;

namespace NetCore.CodeCoverage.Sample.Console.Tests
{
	public class CalculatorTests
	{
		[Theory]
		[InlineData(1, 2, 3)]
		[InlineData(3, 2, 5)]
		[InlineData(100, 43, 143)]
		[InlineData(-43, 65, 22)]
		[InlineData(-431, 76, -355)]
		public void Sum_SumTwoNumbers_SumSuccess(double firstNumber, double secondNumber, double exceptedResult)
		{
			var calculator = new Calculator();
			var result = calculator.Sum(firstNumber, secondNumber);

			Assert.Equal(exceptedResult, result);
		}

		[Theory]
		[InlineData(1, 2, -1)]
		[InlineData(3, 2, 1)]
		[InlineData(100, 43, 57)]
		[InlineData(-43, 65, -108)]
		[InlineData(431, 76, 355)]
		public void Substract_SubstractTwoNumbers_SubstractSuccess(double firstNumber, double secondNumber, double exceptedResult)
		{
			var calculator = new Calculator();
			var result = calculator.Substract(firstNumber, secondNumber);

			Assert.Equal(exceptedResult, result);
		}

		[Theory]
		[InlineData(1, 2, 2)]
		[InlineData(3, 2, 6)]
		[InlineData(100, 43, 4300)]
		[InlineData(-43, 65, -2795)]
		[InlineData(431, 76, 32756)]
		public void Multiply_MultiplyTwoNumbers_MultiplySuccess(double firstNumber, double secondNumber, double exceptedResult)
		{
			var calculator = new Calculator();
			var result = calculator.Multiply(firstNumber, secondNumber);

			Assert.Equal(exceptedResult, result);
		}

		[Theory]
		[InlineData(1, 2, 0.5)]
		[InlineData(3, 2, 1.5)]
		[InlineData(200, 5, 40)]
		[InlineData(-60, 3, -20)]
		public void Divide_DivideTwoNumbers_DivideSuccess(double firstNumber, double secondNumber, double exceptedResult)
		{
			var calculator = new Calculator();
			var result = calculator.Divide(firstNumber, secondNumber);

			Assert.Equal(exceptedResult, result);
		}
	}
}