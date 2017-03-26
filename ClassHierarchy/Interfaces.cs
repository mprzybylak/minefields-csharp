using System;
namespace ClassHierarchy
{
	public static class Interfaces
	{
		public static void example()
		{
			Console.WriteLine("Interfaces examples");
			implementationStrategies();
		}

		public static void implementationStrategies()
		{
			ImplicitImplementation a = new ImplicitImplementation();
			a.method();

			ExplicitImmplementation b = new ExplicitImmplementation();
			((IFirst)b).method();

			BothImplicit c = new BothImplicit();
			c.method();

			BothExplicit d = new BothExplicit();
			((IFirst)d).method();
			((ISecond)d).method();
		}
	}

	public interface IFirst
	{
		void method();
	}

	public interface ISecond
	{
		void method();
	}

	public class ImplicitImplementation : IFirst
	{
		public void method()
		{
			Console.WriteLine("implicit implementation one method");
		}
	}

	public class ExplicitImmplementation : IFirst
	{
		void IFirst.method()
		{
			Console.WriteLine("explicit implementation one method");
		}
	}

	public class BothImplicit : IFirst, ISecond
	{
		public void method()
		{
			Console.WriteLine("implicit implementation two methods");
		}
	}

	public class BothExplicit : IFirst, ISecond
	{
		void ISecond.method()
		{
			Console.WriteLine("explicit implementation two methods: ISecond ");
		}

		void IFirst.method()
		{
			Console.WriteLine("explicit implementation two methods: IFirst");
		}
	}
}
