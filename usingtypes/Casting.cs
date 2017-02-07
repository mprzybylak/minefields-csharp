using System;
namespace UsingTypes.Conversions
{
	public static class Casting
	{
		public static void example()
		{
			Console.WriteLine("Casting examples");
			wrongCastingArrays();
			isOperator();
			isOperatorArrays();
			asOperator();
			asOperatorArray();
			Console.WriteLine();
		}

		private static void wrongCasting()
		{
			// error - both there are no relationship between those classes
			// FirstClass first = (FirstClass)new SecondClass();

			try
			{
				// not a compile time error but exception will be thrown
				// because it is possible that there is some class that extends FirstClass
				// and implements SomeInterface
				SomeInterface firstInterface = (SomeInterface)new FirstClass();
			}
			catch
			{
			}

			// error - SealedClass is sealed and not implementing interface 
			// so for sure there is no subclass of SealedClass that might implement interface
			// SomeInterface secondInterface = (SomeInterface)new SealedClass();
		}

		private static void wrongCastingArrays()
		{
			// error - both there are no relationship between those classes
			// FirstClass[] first = (FirstClass[])new SecondClass[10];

			try
			{
				// not a compile time error but exception will be thrown
				// because it is possible that there is some class that extends FirstClass[]
				// and implements SomeInterface[]
				SomeInterface[] firstInterface = (SomeInterface[])new FirstClass[10];
			}
			catch
			{
			}

			// error - SealedClass[] is sealed and not implementing interface 
			// so for sure there is no subclass of SealedClass that might implement interface
			// SomeInterface[] secondInterface = (SomeInterface[])new SealedClass[10];
		}

		public static void isOperator()
		{
			// we can check if object is instance of other class
			FirstClass first = new FirstClass();
			SecondClass second = new SecondClass();
			DerivedFromSecond derivedFromSecond = new DerivedFromSecond();

			if (derivedFromSecond is FirstClass)
			{
			}
			else
			{
				Console.WriteLine("False - DerviedFromSecond class is not instance of FirstClass");
			}


			if (derivedFromSecond is SecondClass)
			{
				Console.WriteLine("True - Dervied FromSecond is instance of SecondClass");
			}

			if (null is SecondClass)
			{
			}
			else
			{
				Console.WriteLine("expression 'null is SomeType' is always false");
			}
		}

		public static void isOperatorArrays()
		{
			// we can check if object is instance of other class
			FirstClass[] first = new FirstClass[10]; 
			SecondClass[] second = new SecondClass[10];
			DerivedFromSecond[] derivedFromSecond = new DerivedFromSecond[10]; 

			if (derivedFromSecond is FirstClass[])
			{
			}
			else
			{
				Console.WriteLine("False - DerviedFromSecond[] class is not instance of FirstClass[]");
			}


			if (derivedFromSecond is SecondClass[])
			{
				Console.WriteLine("True - Dervied FromSecond[] is instance of SecondClass[]");
			}

			if (null is SecondClass[])
			{
			}
			else
			{
				Console.WriteLine("expression 'null is SomeType' is always false");
			}
		}

		public static void asOperator()
		{
			// we can check if object is instance of other instance and cast if is - at once
			FirstClass first = new FirstClass();
			SecondClass second = new SecondClass();
			DerivedFromSecond derivedFromSecond = new DerivedFromSecond();

			// not possible - not in one hierarchy of objects
			//if ((derivedFromSecond as FirstClass) != null)
			//{
			//}

			if ((derivedFromSecond as SecondClass) != null)
			{
				Console.WriteLine("True - Dervied FromSecond is instance of SecondClass");
			}

			if ((null as SecondClass) != null)
			{
			}
			else
			{
				Console.WriteLine("expression 'null is SomeType' is always false");
			}
		}

		public static void asOperatorArray()
		{
			// we can check if object is instance of other instance and cast if is - at once
			FirstClass[] first = new FirstClass[10];
			SecondClass[] second = new SecondClass[10];
			DerivedFromSecond[] derivedFromSecond = new DerivedFromSecond[10];

			// not possible - not in one hierarchy of objects
			//if ((derivedFromSecond as FirstClass[]) != null)
			//{
			//}

			if ((derivedFromSecond as SecondClass[]) != null)
			{
				Console.WriteLine("True - Dervied FromSecond[] is instance of SecondClass[]");
			}

			if ((null as SecondClass[]) != null)
			{
			}
			else
			{
				Console.WriteLine("expression 'null is SomeType' is always false");
			}
		}

	}

	class FirstClass
	{
	}

	class SecondClass
	{
	}

	class DerivedFromSecond : SecondClass
	{
	}

	sealed class SealedClass
	{
	}

	interface SomeInterface
	{
	}

}
