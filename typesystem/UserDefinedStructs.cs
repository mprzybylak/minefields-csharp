using System;
using System.Collections;
using System.Collections.Generic;

namespace Typesystem.ValueTypes
{
	public static class UserDefinedStructs
	{
		public static void example()
		{
			Console.WriteLine("User defined structs examples");
			passingByCopy();
			structInitalization();
			Console.WriteLine();
		}

		private static void passingByCopy()
		{
			RGBColor color = new RGBColor();
			color.Red = 10;
			Console.WriteLine("We've just created struct {0}", color);
			letsTryToMutate(color);
			Console.WriteLine("Do our initial struct changed after exiting mutating method? No! {0}", color);

		}

		private static void letsTryToMutate(RGBColor color)
		{
			color.Red = 255;
			Console.WriteLine("We've just changed member of passed structure inside mutating method: {0}", color);
		}

		private static void structInitalization()
		{
			// 1st approach - initalization with constructor
			RGBColor constructorInit = new RGBColor(10, 20, 30);

			// 2nd approach - initalization with default constructor
			RGBColor defaultConstructorInit = new RGBColor();

			// 3rd approach - manual initalization
			RGBColor manualInit;
			manualInit.Red = 100;
			manualInit.Green = 150;
			manualInit.Blue = 200;

			Console.WriteLine("Struct initalized with constructor {0}, Struct initalized with default constructor {1}, Struct initialized manualy {2}",
			                  constructorInit, defaultConstructorInit, manualInit);

		}
	}

	public struct RGBColor
	{
		public byte Red;
		public byte Green;
		public byte Blue;

		// it is forbidden to initalize member this way
		// public byte Alpha = 0;

		// since you cannot inherit from interface - you cannot declare protected members
		// protected string ColorNme;

		// you cannot declare default constructor for structs
		/*
		public RGBColor()
		{
		}
		*/

		// you cannot have constructor that does NOT initialize ALL fields
		/*
		public RGBColor(byte red)
		{
			Red = red;
		}
		*/

		public RGBColor(byte red, byte green, byte blue)
		{
			Red = red;
			Green = green;
			Blue = blue;
		}

		public override string ToString()
		{
			return "Color:[red=" + Red + ", green=" + Green + ", blue=" + Blue + "]";
		}
	}

	/*
	// you cannot inherit from other interface
	public struct RGBAColor : RGBColor
	{
		public byte Alpha;
	}
	*/

	// structs can implement interfaces
	public struct EnumerableStruct : IEnumerable<int>
	{
		public IEnumerator<int> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}
