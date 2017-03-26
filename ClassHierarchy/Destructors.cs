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
			// destructor will be called when gc cleans this object
			// that means it might be not called at all
			new ClassWithDestructor();
		}
	}

	public class ClassWithDestructor
	{
		~ClassWithDestructor()
		{
			// it will be called when gc remove this object 
			Console.WriteLine("Destructor");
		}
	}
}
