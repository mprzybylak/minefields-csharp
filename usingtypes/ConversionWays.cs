using System;
using System.Globalization;
using System.Text;

namespace UsingTypes.Conversions
{
	public static class ConversionWays
	{
		public static void example()
		{
			Console.WriteLine("Many ways to convert types");
			parse();
			systemConvert();
			bitConverter();
			dynamicType();
			Console.WriteLine();
		}

		private static void parse()
		{
			// bascially all primitives have Parse method that allows to convert from  string
			int oneHundred = int.Parse("100");
			Console.WriteLine("int parsed from string = {0}", oneHundred);

			// it will throw format exception if don't understand string
			try
			{
				int ten = int.Parse("ten");
			}
			catch(Exception e)
			{
				Console.WriteLine("Cannot parse string {0}", e);
			}

			// it can case overflow
			try
			{
				byte twoHundred = byte.Parse("1000");
			}
			catch (Exception e)
			{
				Console.WriteLine("Number is to big {0}", e);
			}

			// one way of defense is to use TryParse that returns true if parse was successful 
			byte letsTryParseWithSuccess;
			bool successResultOfParsing = byte.TryParse("10", out letsTryParseWithSuccess);

			byte lestTryParseWithFailure;
			bool failResultOfPrasing = byte.TryParse("1000", out lestTryParseWithFailure);

			Console.WriteLine("Result of first attempt = {0}, result of seccond attempt = {1}", successResultOfParsing, failResultOfPrasing);

			// besides correct format
			// the ONLY ONE THING that is ok for parsing methods are leading and trailing spaces
			byte leadingSpaces = byte.Parse("     10");
			//byte spacesInside = byte.Parse("1 000"); // not ok

			// decimal can parse money
			NumberFormatInfo format = new NumberFormatInfo();
			format.CurrencySymbol = "$";
			decimal oneHundredBucks = decimal.Parse("$100.00", NumberStyles.Currency, format);
			Console.WriteLine("Parsed dolars = {0}", oneHundredBucks);

			// dates can parse many date formats
			DateTime date = DateTime.Parse("2017.02.06");
			Console.WriteLine("Parsed date {0}", date);
		}

		private static void systemConvert()
		{
			// System.Convert contains lots of methods to convert one type into another
			byte b = System.Convert.ToByte(10);
			Console.WriteLine("covnerted to byte {0}", b);

			string hexadecimal = System.Convert.ToString(100, 16);
			Console.WriteLine("converted to hexadecimal {0}", hexadecimal);

			TheLonelinessNumber one = new TheLonelinessNumber();
			int oneInt = Convert.ToInt32(one);

			try
			{
				// if we don't support some conversion - we should throw InvalidCastException
				bool boolOne = Convert.ToBoolean(one);
			}
			catch (InvalidCastException e)
			{
				Console.WriteLine("Cannot parse the loneliness number to bool {0}", e);
			}

			// probably the most general convert method
			byte result = (byte)Convert.ChangeType(100, typeof(byte));
		}

		private static void bitConverter()
		{
			// converts data to raw implementation - byte array
			int intToConvert = 100; // int has 4 bytes
			byte[] intAsAnBytArray = BitConverter.GetBytes(intToConvert);
			int reconstructedInt = BitConverter.ToInt32(intAsAnBytArray, 0);

			Console.WriteLine("int = {0} after converting to array = {1} and re-converted to int again = {2}", intToConvert, toString(intAsAnBytArray), reconstructedInt);

			double doubleToConvert = 10.0;
			long rawDoubleAsAnByteArray = BitConverter.DoubleToInt64Bits(doubleToConvert);
			double reconstructedDouble = BitConverter.Int64BitsToDouble(rawDoubleAsAnByteArray);
			Console.WriteLine("double = {0} after converting to array = {1} and re-converted to int again = {2}", doubleToConvert, rawDoubleAsAnByteArray, reconstructedDouble);

			Console.WriteLine("is this machine use little endian? {0}", BitConverter.IsLittleEndian);
		}

		private static string toString(byte[] arr)
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < arr.Length; ++i)
			{
				sb.Append(Convert.ToString(arr[i]));
				sb.Append(" ");
			}
			return sb.ToString();
		}

		private static void conversionOperators()
		{
			// we can define implict operator (alwyas safe)
			int two = new TwoCanBeAsBadAsOne();

			// if there is a risk of any kind of error we should define explicit operator
			TwoCanBeAsBadAsOne success = (TwoCanBeAsBadAsOne)2;
			// TwoCanBeAsBadAsOne failure = (TwoCanBeAsBadAsOne)3; // Argument Exception
		}

		private static void dynamicType()
		{
			dynamic i = 2;

			if (false)
			{
				// this is not compile failure we can call whatever we want
				i.LubieBudyń();
			}
		}

	}


	class TwoCanBeAsBadAsOne
	{
		public static explicit operator TwoCanBeAsBadAsOne(int i)
		{
			if (i != 2)
			{
				throw new ArgumentException();
			}
			return new TwoCanBeAsBadAsOne();
		}

		public static implicit operator int(TwoCanBeAsBadAsOne two)
		{
			return 2;
		}
	}

	class TheLonelinessNumber : IConvertible
	{
		public TypeCode GetTypeCode()
		{
			return this.GetTypeCode();
		}

		public bool ToBoolean(IFormatProvider provider)
		{
			throw new InvalidCastException();
		}

		public byte ToByte(IFormatProvider provider)
		{
			return 1;
		}

		public char ToChar(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public DateTime ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException();
		}

		public decimal ToDecimal(IFormatProvider provider)
		{
			return 1;
		}

		public double ToDouble(IFormatProvider provider)
		{
			return 1;
		}

		public short ToInt16(IFormatProvider provider)
		{
			return 1;
		}

		public int ToInt32(IFormatProvider provider)
		{
			return 1;
		}

		public long ToInt64(IFormatProvider provider)
		{
			return 1;
		}

		public sbyte ToSByte(IFormatProvider provider)
		{
			return 1;
		}

		public float ToSingle(IFormatProvider provider)
		{
			return 1;
		}

		public string ToString(IFormatProvider provider)
		{
			return "1";
		}

		public object ToType(Type conversionType, IFormatProvider provider)
		{
			throw new InvalidCastException();
		}

		public ushort ToUInt16(IFormatProvider provider)
		{
			return 1;
		}

		public uint ToUInt32(IFormatProvider provider)
		{
			return 1;
		}

		public ulong ToUInt64(IFormatProvider provider)
		{
			return 1;
		}
	}



}
