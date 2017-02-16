using System;
using System.IO;

namespace usingtypes
{
	public static class StringWriterType
	{
		public static void example()
		{
			Console.WriteLine("StringWriter example");
			usefulMethods();
			Console.WriteLine();
		}

		private static void usefulMethods()
		{
			StringWriter sw = new StringWriter();
			sw.Write("Writes some text");
			sw.WriteAsync("Writes some text async");
			sw.WriteLine("Writes line (with end line character at the end)");
			sw.WriteLineAsync("Writes line (with end line character at the end) async");
			sw.Flush(); // flushes buffer. There is also FlushAsync
			Console.WriteLine("ToString method converts StringWriter into string {0}", sw.ToString());
		}
	}
}
