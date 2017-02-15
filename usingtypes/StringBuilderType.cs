using System;
using System.Text;

namespace usingtypes
{
	public static class StringBuilderType
	{
		public static void example()
		{
			Console.WriteLine("StringBuilder example");
			usefulProperties();
			usefulMethods();
			Console.WriteLine();
		}

		private static void usefulProperties()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("Hello, World!");

			Console.WriteLine("Current String Builder capacity {0}", sb.Capacity);
			Console.WriteLine("Current String Builder capacity {0}", sb.MaxCapacity);
			Console.WriteLine("Length of current string inside String Builder {0}", sb.Length);

			Console.WriteLine("iterate over String Builder using indexer");
			for (int i = 0; i < sb.Length; ++i)
			{
				Console.Write(sb[i]);
			}
		}

		private static void usefulMethods()
		{
			StringBuilder sb = new StringBuilder();

			sb.Append("Hello, World"); // appends "something" to String Builder
			sb.AppendFormat("Some value: {0}", 2); // appends using composite format
			sb.AppendLine(); // appends end of line character
			sb.Insert(4, "!"); // inserts given stiring on given index
			sb.Remove(sb.Length - 5, 2); // removes n characters starting from given index
			sb.Replace("e", "o"); // replaces all occurences of one character with another

			string iDontEvenWantToKnowWhatsInside = sb.ToString(); // converts String Builder to string
			Console.WriteLine(iDontEvenWantToKnowWhatsInside);
		}
	}
}
