using System;
using System.Globalization;

namespace usingtypes
{
	public static class IFormatableExmample
	{
		public static void example()
		{
			Console.WriteLine("IFormattable example");
			formatingExamples();
			Console.WriteLine();
		}

		public static void formatingExamples()
		{
			Length length = new Length(1000000);
			CultureInfo english = new CultureInfo("en-GB");
			CultureInfo polish = new CultureInfo("pl-PL");

			Console.WriteLine(String.Format("Meters, English: {0}", length.ToString("Me", english)));
			Console.WriteLine(String.Format("Meters, Polish: {0}", length.ToString("Me", polish)));
			Console.WriteLine(String.Format("Miles, English: {0}", length.ToString("Mi", english)));
			Console.WriteLine(String.Format("Miles, Polish: {0}", length.ToString("Mi", polish)));
		}
	}

	public class A : IFormattable
	{
		string IFormattable.ToString(string format, IFormatProvider formatProvider)
		{
			throw new NotImplementedException();
		}
	}

	public class Length : IFormattable
	{
		private double value;

		public Length(double meters)
		{
			this.value = meters;
		}

		public double Meters
		{
			get;
		}

		public double Miles
		{
			get
			{
				return value * 0.000621371d;
			}
		}

		public override string ToString()
		{
			return ToString("g", CultureInfo.CurrentCulture);
		}

		public string ToString(string format)
		{
			return ToString(format, CultureInfo.CurrentCulture);
		}

		public string ToString(string format, IFormatProvider formatProvider)
		{
			if (String.IsNullOrEmpty(format))
			{
				format = "G";
			}
			if (formatProvider == null)
			{
				formatProvider = CultureInfo.CurrentCulture;
			}

			switch (format.ToUpperInvariant())
			{
				case "G":
				case "ME":
					return value.ToString("F4", formatProvider) + " meters";
				case "MI":
					return value.ToString("F4", formatProvider) + " miles";
				default:
					throw new FormatException(String.Format("Format {0} is not supported", format));
			}

		}
	}
}
