using System;


namespace A
{
	public partial class A
	{
	}
}

namespace B
{
	public partial class A
	{
	}
}



namespace typesystem
{
	public class TypeSystem
	{

		public static void Main()
		{
			System.Console.WriteLine("Type system");

			// value type: alias
			int integerAlias = 12;
			// corresponding .net type
			System.Int32 integerType = 12;

			System.Console.WriteLine(integerType == integerAlias);


			// you cannot use unasigned alias type
			int unasignedAlias = new int();
			System.Console.WriteLine(unasignedAlias);
			// you can use unasigned .net type beacuse it is reference type
			System.Int32 unasignedType = new System.Int32();
			System.Console.WriteLine(unasignedType.GetTypeCode());

			Student stud = new Student();
			System.Console.WriteLine(stud);


			System.Console.WriteLine(Enum.GetName(typeof(Dummy), 2));

			Console.WriteLine((12.1).GetType());

			Student s;
			s.firstName = "a";
			s.lastName = "b";
			Console.WriteLine(s);

			WithClass aaa = new WithClass();
			WithClass bbb = new WithClass(1, new Empty());
			WithClass ccc;
			ccc.foo = 1;
			ccc.empty = new Empty();

			System.Console.WriteLine(aaa);
			System.Console.WriteLine(bbb);
			System.Console.WriteLine(ccc);

			Dummy a = (Dummy)17;
			Console.WriteLine(a);

			Movable movable = new Movable(1);
			Console.WriteLine("Movable initial id=" + movable.getId());
			Switcher switcher = new Switcher();
			switcher.switchMovable(movable);
			Console.WriteLine("Movable initial id=" + movable.getId());

			// all positional args
			methodCall(1, 2, 3, 4);

			// all named args
			methodCall(a: 1, c: 3, b: 2, d: 1);

			// mixed positional with namedd
			methodCall(1, 2, d: 3, c: 4);

			int aaaa = 1;
			int bbbb = 2;
			Console.WriteLine("aaaa = " + aaaa);
			passByReference<int>(ref aaaa, bbbb);
			Console.WriteLine("aaaa= " + aaaa);

			// casting between int and object
			object o;
			int i = 1;
			o = i;
			object oo = 1;


			IndexedClass ic = new IndexedClass();
			int iaaaa = ic[1, 2, 3];

			bool result = 2 == null;
		}



		public static void methodCall(int a, int b, int c, int d)
		{
		}

		public static void passByReference<T>(ref T a, T b)
		{
			a = b;
		}
	}

	public class GenType<T> where T : propsClass, new()
	{
	}

	public class propsClass
	{
		private int a;

		public int ValueA
		{
			get
			{
				bar();
				return foo();
			}
		}

		private void bar()
		{
		}

		private int foo()
		{
			return 1;
		}

	}

	public class IdCls {
	
		public string this[int i] => "aa";
	public int this[string i] => 2;

}

	public class IndexedClass
	{
		//public int this[OuterForStatic o] => 1;
		//public int this[int i] => 2;
		public int this[int arg1, int arg2, int arg3] => 1;

	}

	public class OuterForStatic
	{
		public static class ImplictStatic
		{
			public static void foo()
			{
			}
		}
	}


	public class OuterClass
	{
		private int privateField = 1;

		public class InnerClass
		{
			private OuterClass outer; 

			public InnerClass(OuterClass outer)
			{
				this.outer = outer;
			}

			public void printPrivateField()
			{
				Console.WriteLine(outer.privateField);
			}
		}
	}

	public enum Dummy
	{
		A = 10, B, C
	}; 

	public struct Student
	{
		public string firstName;
		public string lastName;

		public Student(string firstName)
		{
			this.firstName = firstName;
			this.lastName = "";
		}
	}

	public class Movable
	{
		private int id;

		public Movable(int id)
		{
			this.id = id;
		}

		public int getId()
		{
			return id;

		}
	}

	public class Switcher
	{
		public void switchMovable( Movable movable) {
			movable = new Movable(100);
			Console.WriteLine("Internal movable id=" + movable.getId());
		}
	}




	public class Empty {


	}

	public struct WithClass
	{
		public int foo;
		public Empty empty;

		public WithClass(int foo, Empty empty)
		{
			this.foo = foo;
			this.empty = empty;
		}
	}

}
