using System;
using System.Collections;
using System.Collections.Generic;

namespace ClassHierarchy
{
	public static class UsefulInterfaces
	{
		public static void example()
		{
			Console.WriteLine("useful interfaces examples");
			iDisposableExapmle();
			iComparableExample();
			iComparerExample();
			iEquatableExample();
			iClonableExample();
			iEnumerableExample();
		}

		public static void iDisposableExapmle()
		{
			using (var a = new DisposeExample())
			{
				a.method();
			}
		}

		public static void iComparableExample()
		{
			ComparableExapmle a = new ComparableExapmle(1);
			ComparableExapmle b = new ComparableExapmle(2);

			Console.WriteLine("compare of {0} with {1} = {2}", a, b, a.CompareTo(b));
		}

		public static void iComparerExample()
		{
			ComparableExapmle a = new ComparableExapmle(1);
			ComparableExapmle b = new ComparableExapmle(2);
			ComparerExample comparer = new ComparerExample();

			Console.WriteLine("compare of {0} with {1} = {2}", a, b, comparer.Compare(a, b));
		}

		public static void iEquatableExample()
		{
			ClassWithEquals first = new ClassWithEquals(1);
			ClassWithEquals second = new ClassWithEquals(1);

			Console.WriteLine("Equality of objects {0} and {1} = {2}", first, second, first.Equals(second));
		}

		public static void iClonableExample()
		{
			ClonableClass c = new ClonableClass(2);
			ClonableClass cloneOfObject = (ClonableClass)c.Clone();

			Console.WriteLine("object: {0} and clone {1}", c, cloneOfObject);
			c.Value = 100;
			Console.WriteLine("object after change: {0} and unchanged clone {1}", c, cloneOfObject);
		}

		public static void iEnumerableExample()
		{
			SomeRange range = new SomeRange(1, 100);

			foreach (int i in range)
			{
				Console.Write(i);
			}
			Console.WriteLine();
		}

	}

	class DisposeExample : IDisposable
	{
		public void method()
		{
			Console.WriteLine("regular method");
		}

		public void Dispose()
		{
			Console.WriteLine("clean managed resources here...");
		}
	}

	class ComparableExapmle : IComparable<ComparableExapmle>
	{
		int value;

		public ComparableExapmle(int value)
		{
			this.value = value;
		}

		public int CompareTo(ComparableExapmle obj)
		{
			return value.CompareTo(obj.value);
		}

		public override string ToString()
		{
			return string.Format("[ComparableExapmle]={0}", value);
		}
	}

	class ComparerExample : IComparer<ComparableExapmle>
	{
		public int Compare(ComparableExapmle x, ComparableExapmle y)
		{
			return x.CompareTo(y);
		}
	}

	class ClassWithEquals : IEquatable<ClassWithEquals>
	{
		int value;

		public ClassWithEquals(int value)
		{
			this.value = value;
		}

		public bool Equals(ClassWithEquals other)
		{
			return value == other.value;
		}

		public override string ToString()
		{
			return string.Format("[ClassWithEquals]={0}", value);
		}
	}

	public class ClonableClass : ICloneable
	{
		private int value;

		public int Value
		{
			get
			{
				return value;
			}
			set
			{
				this.value = value;
			}
		}

		public ClonableClass(int value)
		{
			this.value = value;
		}

		public object Clone()
		{
			return new ClonableClass(value);
		}

		public override string ToString()
		{
			return string.Format("[ClonableClass]={0}", value);
		}
	}

	public class SomeRange : IEnumerable<int>
	{
		int min;
		int max;

		public SomeRange(int min, int max)
		{
			this.min = min;
			this.max = max;
		}

		public IEnumerator<int> GetEnumerator()
		{
			for (int i = min; i < max; ++i)
				yield return i;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}


}
