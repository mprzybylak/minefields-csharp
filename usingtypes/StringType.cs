using System;
namespace UsingTypes.StringType
{
	public static class StringType
	{
		public static void example()
		{
			Console.WriteLine("Using string");
			stringEquality();
			stringLiterals();
			stringConstructors();
			usefulPropertiesAndFields();
			usefulStaticMethods();
			Console.WriteLine();
		}

		private static void stringLiterals()
		{
			// regular string literal - "quoted string"
			string quotedString = "I'm regular quoted String. I can contain escape characters like \\";
			string verbatimString = @"I'm verbatim string. I don't need to escape characters like \ \ \ ";
			int a = 10;
			string interpolatedString = $"I'm interpolated string, i can have interpolated exceptions like= {a}";

			Console.WriteLine(quotedString);
			Console.WriteLine(verbatimString);
			Console.WriteLine(interpolatedString);
		}

		private static void stringEquality()
		{
			string firstString = "first string";
			string theSameString = "f";
			theSameString += "irst string";

			if (firstString.Equals(theSameString))
			{
				Console.WriteLine("Java-like comaprison shows that both strings are equals");
			}

			if (firstString == theSameString)
			{
				Console.WriteLine("C# overrides == and != operators for strings - shows if two strings are equals");
			}

			if (((object)firstString).Equals((object)theSameString))
			{
				Console.WriteLine("Both strings are equals from the object point of view");
			}

			if ( (object)firstString == (object)theSameString )
			{
				Console.WriteLine("Both strings are NOT referencing the same string literal");
			}
		}

		private static void stringConstructors()
		{
			string stringFromRepeatedSingleChar = new string('s', 3);
			string stringFromCharArray = new string(new char[]{ 'a', 'b', 'b' });
			string stringFromPartOfCharArray = new string(new char[] { 'a', 'b', 'c', 'd', 'e', 'f'}, 2, 3);

			Console.WriteLine(stringFromRepeatedSingleChar);
			Console.WriteLine(stringFromCharArray);
			Console.WriteLine(stringFromPartOfCharArray);
		}

		private static void usefulPropertiesAndFields()
		{
			string someString = "some string";

			Console.WriteLine("Length property of string: {0}", someString.Length);
			Console.WriteLine("With indexer we can read character under index n for example index = 4: {0}", someString[4]);
			Console.WriteLine("String have read only static field that represents empty string: '{0}'", string.Empty);
		}

		private static void usefulStaticMethods()
		{

			string first = "asadsa";
			string second = "ryryrr";

			Console.WriteLine("string.Compare returns -1, 0 or 1 - so if first string is 'lower', 'equal' or 'higher': {0}", string.Compare(first, second));
			Console.WriteLine("string.Concat concatenates strings: {0}", string.Concat(first, second));
			Console.WriteLine("string.Joions concatenates strings with additional separator between: {0}", string.Join(";", first, second));
			Console.WriteLine("string.Copy creates copy of string: {0} object equals to copy of {0} = {1}", first, (object)first == ((object)string.Copy(first)));
			Console.WriteLine("string.Equals compares strings: {0} and {1} == {2}", first, second, string.Equals(first, second));
			Console.WriteLine("string.IsNullOrEmpty: {0}", string.IsNullOrEmpty(first));
			Console.WriteLine("string.isNullOrWhiteSpace: {0}", string.IsNullOrWhiteSpace(first));

		}
	}
}
