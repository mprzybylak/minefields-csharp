using System;
namespace ClassHierarchy
{
	public static class Polymorphism
	{
		public static void example()
		{
			Console.WriteLine("Polymorphism examples");
			virtualNonVirtual();

		}

		public static void virtualNonVirtual()
		{
			Console.WriteLine("BaseClass = new BaseClass");
			PolyBaseClass a = new PolyBaseClass();
			a.regularMethod();
			a.firstVirtualMethod();
			a.secondVirtualMethod();

			Console.WriteLine("BaseClass = new DerivedClass");
			PolyBaseClass b = new PolyFirstDerived();
			b.regularMethod();
			b.firstVirtualMethod();
			b.secondVirtualMethod();

			Console.WriteLine("DerivedClass = new DerivedClass");
			PolyFirstDerived c = new PolyFirstDerived();
			c.regularMethod();
			c.firstVirtualMethod();
			c.secondVirtualMethod();

		}
	}

	public class PolyBaseClass
	{
		public void regularMethod()
		{
			Console.WriteLine("BaseClass: regular method");
		}

		public virtual void firstVirtualMethod()
		{
			Console.WriteLine("BaseClass: first virtual method");
		}

		public virtual void secondVirtualMethod()
		{
			Console.WriteLine("BaseClass: second virtual method");
		}

		public virtual void thirdVirtualMethod()
		{
			Console.WriteLine("BaseClass: third virtual method");
		}
	}

	public class PolyFirstDerived : PolyBaseClass
	{
		public override void firstVirtualMethod()
		{
			Console.WriteLine("First Derived: first virtual method (override)");
		}

		public new void secondVirtualMethod()
		{
			Console.WriteLine("First Derived: second virtual method (new)");
		}

		public override sealed void thirdVirtualMethod()
		{
			Console.WriteLine("First Derived: third virtual method (sealed)");
		}
	}

	public class PolySecondDerived : PolyFirstDerived
	{
		// CANNOT OVERRIDE SEALEAD METHOD
		// public override void thirdVirtualMethod() {}
	}
}
