using System;
namespace Typesystem.ValueTypes
{
	public struct RGBColor
	{
		public byte red;
		public byte green;
		public byte blue;

		public override string ToString()
		{
			return "Color:[red=" + red + ", green=" + green + ", blue=" + blue + "]";
		}
	}


	public static class UserDefinedStructs
	{
		public static void example()
		{
			Console.WriteLine("User defined structs examples");
			passingByCopy();
			Console.WriteLine();
		}

		private static void passingByCopy()
		{
			RGBColor color = new RGBColor();
			color.red = 10;
			Console.WriteLine("We've just created struct {0}", color);
			letsTryToMutate(color);
			Console.WriteLine("Do our initial struct changed after exiting mutating method? No! {0}", color);

		}

		private static void letsTryToMutate(RGBColor color)
		{
			color.red = 255;
			Console.WriteLine("We've just changed member of passed structure inside mutating method: {0}", color);
		}
	}

}
