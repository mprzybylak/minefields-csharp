using System;
namespace Typesystem.ReferenceTypes
{
	using Typesystem.ReferenceTypes.Extensions;

	public static class ExtensionMethods
	{
		public static void example()
		{
			int i = 2;
			int isquare = i.square();

			Console.WriteLine("square of value {0} calculated by extension method is {1}", i, isquare);

			// we cannot use it beccause it is from other namespace
			// i.Power(2);
		}
	}


}

namespace Typesystem.ReferenceTypes.Extensions
{
	public static class MyIntExtension
	{
		public static int square(this int value)
		{
			return value * value;
		}
	}
}

// this name space is not included
namespace Typesystem.ReferenceTypes.OtherExtensions
{
	public static class MyIntOtherExtensions
	{
		public static int Power(this int value, int pow)
		{
			return (int)Math.Pow(value, pow);
		}
	}
}