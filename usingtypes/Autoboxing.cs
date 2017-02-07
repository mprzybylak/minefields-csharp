using System;
namespace UsingTypes.Conversions
{
	public static class Autoboxing
	{
		public static void example()
		{
			Console.WriteLine("Boxing and Unboxing exapmle");

			boxingAndUnboxing();


			Console.WriteLine();
		}

		private static void boxingAndUnboxing()
		{
			// boxing
			int i = 10;
			object boxedI = i;
			Console.WriteLine("value type {0} with value {1} boxed to object (type {2}) with value {3}", i.GetType(), i, boxedI.GetType(), boxedI);

			// unboxing
			int j = (int)boxedI;
			Console.WriteLine("object (of type {0}) with value {1} unboxed to value type {2} with value {3}", boxedI.GetType(), boxedI, j.GetType(), j);

			object obj = new object();

			// invalid cast exception - only values boxed to object can be unboxed again
			// int k = (int)obj;

		}

	}
}
