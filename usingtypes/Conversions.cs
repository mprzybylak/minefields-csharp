using System;
namespace UsingTypes.Conversions
{
	public static class Conversions
	{
		public static void example()
		{
			Console.WriteLine("General conversions examples");
			wideningConversions();
			narrowingConersions();
			handlingOverflows();
			checkedUncheckedBlock();
			Console.WriteLine();
		}

		public static void wideningConversions()
		{
			// regular wideining conversion - int can store more values than byte
			byte byteSource = 10;
			int intDestination = byteSource;
			Console.WriteLine("integer={0} stores value from byte={1} value", intDestination, byteSource);

			// casting from derived to base type is widening operation
			DerivedClass deriverSource = new DerivedClass();
			BaseClass baseDestination = deriverSource;
			Console.WriteLine("BaseClass reference stores value of type: {0}", baseDestination.GetType());

			// casting from implementation to interface is widening conversion
			Implementation implementationSource = new Implementation();
			Interface interfaceDestination = implementationSource;
			Console.WriteLine("Interface reference stores value of type: {0}", interfaceDestination.GetType());

			// conversion from integral type to floating points (or from decimal to floating points) is widening conversion
			// if there is possible that during conversion we will loose only precision (so, no magintude) it is still widening conversion
			int intSource = 12;
			float floatDestination = intSource;
			double doubleDestination = intSource;
			Console.WriteLine("float {0} and double {1} stores value converted from integer {2}", intSource, floatDestination, doubleDestination);
		}

		public static void narrowingConersions()
		{
			// regular narrowing conersion - byte cannot store values larger than byte
			int intSource = 10;
			byte byteDestination = (byte)intSource; // need implicit cast
			Console.WriteLine("byte={0} maybe can store value from int={1} - need explict cast", intSource, byteDestination);

			// casting from base to derived type is narrowing conversion
			BaseClass baseSourceThatIsDerivedInFact = new DerivedClass();
			BaseClass baseSourceThatIsBaseType = new BaseClass();

			DerivedClass derivedDestination = (DerivedClass)baseSourceThatIsDerivedInFact;
			//DerivedClass derivedDestination2 = (DerivedClass)baseSourceThatIsBaseType; // InvalidCastException

			// casting from interface to implementation is narrowing conversion;
			Interface interfaceThatIsDerivedInFact = new Implementation();
			Implementation implementationDestination = (Implementation)interfaceThatIsDerivedInFact;

			// conversion from floating points to integers
			float floatSource = 12;
			double doubleSource = 12;

			int intDestinationForFloat = (int)floatSource;
			int intDestinationForDouble = (int)doubleSource;
			Console.WriteLine("integers {0}, {1} maybe can hold values from float {2} and double {3}", intDestinationForFloat, intDestinationForDouble, floatSource, doubleSource);

		}

		public static void handlingOverflows()
		{
			unchecked
			{
				int integerValue = int.MaxValue;
				integerValue = integerValue + 1;
				Console.WriteLine("Integer with value bigger than max value will be truncated = {0} (equal to int.MinValue)", integerValue);

				double doubleValue = double.MaxValue;

				/* 
				 * not so easy to make double infinite - if you will try to add "small" value to double.MaxValue nothing will happen
				 * (small in comparison to double.MaxValue), because of loosing of precision
				 */
				doubleValue = doubleValue + 1e292; 
				Console.WriteLine("Doubles will be set to infinite on overflow = {0}, is infinite? {1}", doubleValue, double.IsInfinity(doubleValue)); 
			}
		}

		public static void checkedUncheckedBlock()
		{
			// in this block overflow / underflow will always throw exception
			checked
			{
				int maxVal = int.MaxValue; // + 1 will result with exception
			}

			// in this block overflow / underflow will never throw exception
			unchecked
			{
				int maxVal = int.MaxValue; // + 1 will NOT result with exception
			}
		}

		private static void blockIsNotWorkingHere()
		{
			// if this method is called inside checked / unckecked block it will NOT change default settings for code executed inside this mehtods
		}
	}

	class BaseClass
	{
	}

	class DerivedClass : BaseClass
	{
	}

	interface Interface
	{
	}

	class Implementation : Interface
	{
	}


}
