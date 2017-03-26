using System;
namespace ClassHierarchy
{
	public static class Destructors
	{
		public static void examples()
		{
			Console.WriteLine("Destructor examples");
		}

		public static void example()
		{
			new ClassWithDestructor();
		}
	}

	public class ClassWithDestructor
	{
		~ClassWithDestructor()
		{
			Console.WriteLine("Destructor");
		}
	}
}
