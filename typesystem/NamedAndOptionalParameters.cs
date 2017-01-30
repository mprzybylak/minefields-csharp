using System;
namespace Typesystem.ReferenceTypes
{
	public static class NamedAndOptionalParameters
	{
		public static void example()
		{
			Console.WriteLine("Example of using named and optional parameters");
			namedArguments();
			optionalArguments();
			namedAndOptional();
			Console.WriteLine();
		}

		private static void namedArguments()
		{
			// regular call - each argument in order of method signature
			// we call it "positional arguments"
			printThreeNumbers(1, 2, 3);

			// we can call method and use name of arguments from method signature
			// we call it "named parameters"
			printThreeNumbers(first: 1, second: 2, third: 3);

			// in case of named arguments we can mix order
			printThreeNumbers(second: 2, third: 3, first: 1);

			// we can use both types of argument in single method call, but named arguments HAVE TO be last
			printThreeNumbers(1, third: 3, second: 2);
			//printThreeNumbers(first: 1, 2, third: 3); // - illegal
		}

		private static void printThreeNumbers(int first, int second, int third)
		{
			Console.WriteLine("Printing three numbers: 1st: {0}, 2nd: {1}, 3rd {2}", first, second, third);
		}

		private static void optionalArguments()
		{
			// regular call with all arguments
			printThreeStrings("first", "second", "third");

			// omitting all optional arguments
			printThreeStrings("first");

			// we cannot ommit optional positional argument in the middle
			// printThreeStrings("first", ,"second");
		}

		// first argument is required
		// second and third id optional because there is default value in method signature for each of them
		private static void printThreeStrings(string first, string second = "default second", string third = "default third")
		{
			Console.WriteLine("Printing three strings: first {0}, second {1}, third {2}", first, second, third);
		}

		private static void namedAndOptional()
		{
			// if we are using positional arguments, than we can use ANY combination of optional arguments in any order
			summingBunchOfIntegers(first: 10, fourth: 4);
			summingBunchOfIntegers();
			summingBunchOfIntegers(fourth: 100, second: 2, first: 3);
		}

		private static void summingBunchOfIntegers(int first = 0, int second = 0, int third = 0, int fourth = 0)
		{
			Console.WriteLine("Pring sum of those integers: {0}, {1}, {2}, {3} = {4}", first, second, third, fourth, first + second + third + fourth);
		}

	}
}
