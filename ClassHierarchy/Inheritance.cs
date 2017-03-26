using System;
namespace ClassHierarchy
{
	public static class Inheritance
	{
		public static void example()
		{
			Console.WriteLine("Inheritance example");
			methodFromBaseClass();
			initalizationOrder();
		}

		private static void methodFromBaseClass()
		{
			DerivedClass derived = new DerivedClass();
			derived.baseClassMethod();
		}

		private static void initalizationOrder()
		{
			new C();
		}

	}

	public class BaseClass
	{
		public void baseClassMethod()
		{
			Console.WriteLine("method from base class");
		}
	}

	public class DerivedClass : BaseClass
	{
	}

	public static class StaticClass
	{
	}

	// static class must derive from object and also static class is sealed
	// public static class DerivedStaticClass : StaticClass { }

	public class Foo
	{
		public Foo(string s)
		{
			Console.WriteLine(s);
		}
	}

	public class A
	{
		private Foo aFoo = new Foo("A: Foo");
		public A()
		{
			Console.WriteLine("A: Constructor");
		}
	}

	public class B : A
	{
		private Foo bFoo = new Foo("B: Foo");
		public B()
		{
			Console.WriteLine("B: Constructor");
		}
	}

	public class C : B
	{
		private Foo cFoo = new Foo("C: Foo");
		public C()
		{
			Console.WriteLine("C: Constructor");
		}
	}
}
