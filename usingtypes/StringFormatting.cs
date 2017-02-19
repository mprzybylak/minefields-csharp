using System;
namespace usingtypes
{
	public static class StringFormatting
	{
		public static void example()
		{
			Console.WriteLine("String formatting examples");
			toStringHelloWorld();
			formatHelloWorld();
			dateFormatting();
			enumFormating();
			integerFormatting();
			Console.WriteLine();
		}

		private static void toStringHelloWorld()
		{
			decimal value = 10.3M;
			Console.WriteLine(value.ToString("G")); // general format
			Console.WriteLine(value.ToString("C")); // currency
			Console.WriteLine(value.ToString("P")); // percent
		}

		private static void formatHelloWorld()
		{
			char c = 'c';
			int i = 1;
			float f = 1.4f;

			Console.WriteLine(String.Format("Example of using String.Format: {0}, {1}, {2}", c, i, f));

			string indexExample = String.Format("{0}, {1}, {2}", c, i, f);
			string alignmentExample = String.Format("'{0,5}', '{1,5}', '{2,-5}'", c, i, f);

			Console.WriteLine(indexExample);
			Console.WriteLine(alignmentExample);
		}

		public static void dateFormatting()
		{
			DateTime dt = new DateTime(2017, 2, 19, 21, 7, 5, 123);

			// standard formatting
			Console.WriteLine(String.Format("short date {0:d}", dt));
			Console.WriteLine(String.Format("long date {0:D}", dt));
			Console.WriteLine(String.Format("short time {0:t}", dt));
			Console.WriteLine(String.Format("long time {0:T}", dt));
			Console.WriteLine(String.Format("long date, short time {0:f}", dt));
			Console.WriteLine(String.Format("long date, long time {0:F}", dt));

			// custom formating
			// yyyy - long year,
			// MMMM - month name
			// dd - long day number
			Console.WriteLine(String.Format("{0:yyyy MMMM dd}", dt));

			// custom formating
			// HH - long hour
			// mm - long minute
			// ss - long seconds
			Console.WriteLine(String.Format("{0:HH mm ss}", dt));
		}

		public static void enumFormating()
		{
			Season season = Season.Winter;

			Console.WriteLine(String.Format("try to show name if possible: {0:g}", season));
			Console.WriteLine(String.Format("allways show value: {0:d}", season));
		}

		public static void integerFormatting()
		{
			int integerValue = 10;
			float floatingPointValue = 16.4f;

			// standard formatting
			Console.WriteLine(String.Format("currency: {0:c}", integerValue));
			Console.WriteLine(String.Format("decimal: {0:d}", integerValue));
			Console.WriteLine(String.Format("locale-aware: {0:N}", integerValue));
			Console.WriteLine(String.Format("percent: {0:P}", integerValue));
			Console.WriteLine(String.Format("hexadecimal: {0:X}", integerValue));

			Console.WriteLine(String.Format("scientific notation: {0:e}", floatingPointValue));
			Console.WriteLine(String.Format("integral and decimal: {0:F}", floatingPointValue));
		}
	}

	public enum Season
	{
		Winter, Spring, Summer, Autumn
	}

}
