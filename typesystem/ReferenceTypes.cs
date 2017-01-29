using System;
namespace typesystem
{
	public static class ReferenceTypes
	{
		public static void example()
		{
			Console.WriteLine("Regerence types");
			references();
			passingReferencesToMethods();
			Console.WriteLine();
		}

		private static void references()
		{
			SimplestClass firstObject = new SimplestClass();
			Console.WriteLine("We've created object {0}", firstObject);

			// multiple references can point to the same object
			SimplestClass otherReferenceToFirstObject = firstObject;
			Console.WriteLine("We've created other reference to the same object {0} - we cannot do that with value types", otherReferenceToFirstObject);
		}

		private static void passingReferencesToMethods()
		{
			SimplestClass simplestClass = new SimplestClass();
			Console.WriteLine("Object created: {0}", simplestClass.GetHashCode());

			assignNewValueToPassedReference(simplestClass);
			Console.WriteLine("Do our reference changed after exiting from method? {0}", simplestClass.GetHashCode());
		}

		private static void assignNewValueToPassedReference(SimplestClass reference)
		{
			reference = new SimplestClass();
			Console.WriteLine("Method re-asigned reference {0}", reference.GetHashCode());
		}

	}

	public class SimplestClass
	{
		public string text;
	}
}
