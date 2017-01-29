using System;
namespace Typesystem.ValueTypes
{
	public static class ValueTypesInitialization
	{
		public static void example()
		{
			Console.WriteLine("Examples for values initialization");
			nonInitializedExample();
			initalizationExample();
			Console.WriteLine();
		}

		private static void nonInitializedExample()
		{
			Console.WriteLine("Nothing to show because we cannot use non-initalized value type");

			// this value is not initalized. 
			int nonInitializedValue;

			// if we will try to use this value we will get an error:
			// Error CS0165: Use of unassigned local variable `nonInitializedValue'

			// Console.WriteLine(nonInitializedValue);
		}

		private static void initalizationExample()
		{
			// initialization with int literal 
			int initalizationWithValue = 2;

			// initialization with default constructor of int type 
			// (default value = 0 will be assigned)
			int initializationWithDefaultConstructor = new int();

			Console.WriteLine("Variable initialized with literal: {0}, and Variable initialized with default constructor {1}", 
			                  initalizationWithValue, initializationWithDefaultConstructor);
		}
	}
}
