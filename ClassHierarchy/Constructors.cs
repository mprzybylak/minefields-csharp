using System;
namespace ClassHierarchy
{
	public static class Constructors
	{
		public static void example()
		{
			Console.WriteLine("Constructor examples");
			callingOtherConstructors();
			staticConstructor();
		}

		public static void callingOtherConstructors()
		{
			new ConstructorDerived();
		}

		public static void staticConstructor()
		{
			new ClassWithStaticMembers();
		}
	}

	public class ConstructorBase
	{
		public ConstructorBase() : this("a")
		{
			Console.WriteLine("Base: Constructor");
		}

		public ConstructorBase(string a)
		{
			Console.WriteLine("Base: Other Constructor");
		}

	}

	public class ConstructorDerived : ConstructorBase
	{
		public ConstructorDerived() : base() // call to base class constructor
		{
			Console.WriteLine("Derived: Constructor");
		}
	}

	public class ParameterBase
	{
		public ParameterBase(string arg)
		{
			Console.WriteLine("base constructor with argument");
		}
	}

	public class ParameterFirstDerived : ParameterBase
	{
		// base class have non-default constructor - call to it is mandatory
		public ParameterFirstDerived() : base("a")
		{
			Console.WriteLine("derived constructor without arguments");
		}
	}

	public class ClassWithStaticMembers 
	{
		private static string a;
		private static string b;

		static ClassWithStaticMembers()
		{
			a = "a";
			b = "b";
		}

		public ClassWithStaticMembers()
		{
			Console.WriteLine("Fields values: a = {0}, b = {1}", a, b);
		}
	}

}
