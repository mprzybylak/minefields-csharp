using System;
using System.IO;

namespace usingtypes
{
	public static class StringReaderType
	{
		public static void example()
		{
			Console.WriteLine("String reader example");
			usefulMethods();
			Console.WriteLine();
		}

		private static void usefulMethods()
		{
			String exampleString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.\n" +
				"Phasellus convallis tristique eleifend.\n" +
				"Interdum et malesuada fames ac ante ipsum primis in faucibus.";

			using (StringReader sr = new StringReader(exampleString))
			{
				for (int i = 0; i < 10; ++i)
				{
					Console.WriteLine("Peek will take one character but will not move cursor: {0}", (char)sr.Peek());
					Console.WriteLine("Read method will read one charcter: {0}", (char)sr.Read());
				}

				char[] blockBuffer = new char[10];
				sr.ReadBlock(blockBuffer, 0, 10);
				Console.WriteLine("ReadBlock will read given amount of characters: {0}", new string(blockBuffer));
				Console.WriteLine("ReadLine will read until end of line: {0}", sr.ReadLine());
				Console.WriteLine("ReadLine / ReadLineAsync will read until end of source: {0}", sr.ReadToEnd());
			}
		}
	}
}
