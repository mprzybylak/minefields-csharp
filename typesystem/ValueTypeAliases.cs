using System;

namespace Typesystem.ValueTypes
{
	public static class ValueTypeAliases
	{
		public static void example() 
		{
			Console.WriteLine("Examples of using type aliases");
			compareBetweenTypeAndItsAlias();
			someDifferencesBetweenJavaTypesAndCshOnes();
			checkingSizeOfType();
			Console.WriteLine();
		}

		private static void compareBetweenTypeAndItsAlias()
		{
			Boolean booleanType = true;
			bool booleanTypeAlias = true;

			Console.WriteLine("System.Boolean type GetType() = {0} and boolean alias GetType() = {1}", booleanType.GetType(), booleanTypeAlias.GetType());

			// names of aliases are not always so similar to underlying type
			Single singleType = 1.0f;
			float singleTypeAlias = 1.0f;

			Console.WriteLine("System.Single type GetType() = {0} and float alias GetType() = {1}", singleType.GetType(), singleTypeAlias.GetType());
		}

		private static void someDifferencesBetweenJavaTypesAndCshOnes()
		{
			// in java byte is signed, but in c# is not
			byte byteIsUnsigned = 1;

			// illegal value for byte
			// byte byteCannotBeNegative = -10;

			// if we want use byte like in java we need to use sbyte instead
			sbyte sbyteIsSigned = -1;

			Console.WriteLine("byte in C# can be only positive, like = {0}", byteIsUnsigned);
			Console.WriteLine("sbyte in C# can be both positive and negative, like = {0}", sbyteIsSigned);

			// there is no similar primitive type in java like decimal
			decimal decimalFloatingPoint = 0.3m;
			decimal decimalFloatingPointInDifferentFormat = 0.30000m;
			float binaryFloatingPoint = 0.3f;

			Console.WriteLine("decimal type can be used for things that are 'natural' decimal fractions (like money). binary decimal types are not so good in storing such things");
			Console.WriteLine("decimal value = {0} and the same float value = {1}", decimalFloatingPoint, binaryFloatingPoint);
			Console.WriteLine("if both values are 'natural' decimal fractions it is safe to compare even if format is different {0} == {1} = {2}", decimalFloatingPoint, decimalFloatingPointInDifferentFormat, decimalFloatingPoint == decimalFloatingPointInDifferentFormat);

			// lots of types comes in signed and unsigned flavor
			uint unsignedIntValue = 100;
			int signedIntValue = -100;
			Console.WriteLine("Unsigned int takes only positive vales, like {0}", unsignedIntValue);
			Console.WriteLine("Signed int takes both positive and negative values, like {0}", signedIntValue);
		}

		private static void checkingSizeOfType()
		{
			Console.WriteLine("We can use sizeof() operator to check size of type, for example unit have size {0} and decimal {1}", sizeof(uint), sizeof(decimal));
		}
	}
}
