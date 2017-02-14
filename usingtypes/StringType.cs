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
			usefulMethods();
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

		private static void usefulMethods()
		{
			string first = "asada";
			string second = "rryryr";

			Console.WriteLine("CompareTo returns -1, 0 or 1 - so if string is 'lower', 'equal' or 'higher' than passed one: {0}", first.CompareTo(second));
			Console.WriteLine("Contains returns true if string contains passed substring: {0}", first.Contains(second));
			Console.WriteLine("EndsWIth checks if string ends with given substring: {0}", first.EndsWith(second));
			Console.WriteLine("IndexOf returns index of first occurence of pased char: {0}", first.IndexOf('a'));
			Console.WriteLine("IndexOfAny returns index of first occurence of one of passed chars: {0}", first.IndexOfAny(new char[] { 's', 'd' }));
			Console.WriteLine("Insert inserts substring into string at given index: {0}", first.Insert(2, second));
			Console.WriteLine("LastIndexOf works like IndexOf but checks for last occurence: {0}", first.LastIndexOf('a'));
			Console.WriteLine("LastIndexOfAny works like IndexOfAny but checks for last occurence: {0}", first.LastIndexOfAny(new char[] { 's', 'd' }));
			Console.WriteLine("PadLeft adds given amount of spaces before string: '{0}'", first.PadLeft(3));
			Console.WriteLine("PadRight adds given anount of spaces after string:D '{0}'", first.PadRight(3));
			Console.WriteLine("Remove removes substring at given index", first.Remove(2));
			Console.WriteLine("Replace replaces some character to other", first.Replace('a', 'z'));
			Console.WriteLine("StartsWith checks if strings starts with given substring: {0}", first.StartsWith("as"));
			Console.WriteLine("Substring returns substring within given indexes: {0}", first.Substring(2,2));
			Console.WriteLine("ToLower converts all characters to lower cases: {0}", first.ToLower());
			Console.WriteLine("ToUpper converts all characters to upper cases: {0}", first.ToUpper());
			Console.WriteLine("Trim removes leading and trailing spaces: {0}", first.PadLeft(10).PadRight(10).Trim());

			Console.WriteLine("Split, splits string with given delimeter");
			foreach (string s in first.Split('a'))
			{
				Console.WriteLine(s);
			}

		}
	}
}
