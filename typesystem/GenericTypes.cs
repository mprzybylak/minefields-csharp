using System;
using System.Collections.Generic;

namespace Typesystem.ReferenceTypes
{
	public static class GenericTypes
	{
		public static void example()
		{
			Console.WriteLine("Generic Types");
			genericClass();
			genericMethods();
			genericConstraints();
			genericDefaultValues();
			Console.WriteLine();
		}

		public static void genericClass()
		{
			// creation of generic classes with different parameters
			MyGenericType<int> genericWithInt = new MyGenericType<int>(10);
			MyGenericType<string> genericWithString = new MyGenericType<string>("test");
		}

		public static void genericMethods()
		{
			// execute generic methods with different parameters
			GenericMethod<int>(10);
			GenericMethod<string>("test");
			GenericMethod(10M); // type inference
		}

		public static void genericConstraints()
		{
			StructConstraints<int>(10);
			//StructConstraints<object>(new object());

			ClassConstraints<object>(new object());
			//ClassConstraints<int>(10);

			DefaultConstructorConstraint<int>(10);
			DefaultConstructorConstraint<object>(new object());
			//DefaultConstructorConstraint<TypeWithoutDefaultConstructor>(new TypeWithoutDefaultConstructor(1));

			IList<int> list = new List<int> { 1, 2, 3 };
			ImplementsIEnumerable<IEnumerable<int>,int>(list);
			//ImplementsIEnumerable<object>(new object());
		}

		public static void genericDefaultValues()
		{
			genericDefault<int>();
			genericDefault<object>();
		}

		public static void genericDefault<T>()
		{
			T t = default(T);
			Console.WriteLine("Default value = {0} ", t);
		}

		private static void GenericMethod<T>(T t)
		{
			Console.WriteLine("generic method executed: {0}", t);
		}

		private static void StructConstraints<T>(T t) where T : struct
		{
			Console.WriteLine("You can pass only value type: {0}", t);
		}

		private static void ClassConstraints<T>(T t) where T : class
		{
			Console.WriteLine("You can pass only reference type: {0}", t);
		}

		private static void DefaultConstructorConstraint<T>(T t) where T : new()
		{
			Console.WriteLine("You can pass only types with default constructor {0}", t);
		}

		private static void ImplementsIEnumerable<T,U>(T t) where T : IEnumerable<U>
		{
			foreach (U element in t)
			{
				Console.WriteLine("Element from enumerator {0}", element);
			}

		}

	}

	// generic class
	public class MyGenericType<T>
	{
		private T t;

		public MyGenericType(T t)
		{
			this.t = t;
			Console.WriteLine("Generic class parametrized with {0}", t.GetType());
		}

	}

	public class GenericHiding<T>
	{
		// T in method hides T from class
		public void GenericMethod<T>(T t)
		{
			// ...
		}
	}

	public interface GenericInterface<T>
	{
		void GenericMethod(T t);
	}

	public class MultipleGenericInheritance : GenericInterface<int>, GenericInterface<object>
	{
		public void GenericMethod(object t)
		{
			throw new NotImplementedException();
		}

		public void GenericMethod(int t)
		{
			throw new NotImplementedException();
		}
	}


	public class TypeWithoutDefaultConstructor
	{
		int param;

		TypeWithoutDefaultConstructor(int param)
		{
			this.param = param;
		}
	}
}
