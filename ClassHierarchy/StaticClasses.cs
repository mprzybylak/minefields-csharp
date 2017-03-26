using System;
namespace ClassHierarchy
{
	public static class StaticClasses
	{
		public static void example()
		{
			Console.WriteLine("Static classes");
			Console.WriteLine();
		}
	}

	public static class ConstInsideStaticClass
	{
		const string constValue = "aaa";
	}



}
