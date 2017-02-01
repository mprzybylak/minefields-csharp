using System;
using Typesystem.ReferenceTypes;
using Typesystem.ValueTypes;

namespace typesystem
{
	public static class TypeSystem
	{
		public static void Main()
		{
			// value types
			ValueTypesInitialization.example();
			ValueTypeAliases.example();
			UserDefinedStructs.example();
			UserDefinedEnums.example();

			// reference types
			ReferenceTypes.example();
			Properties.example();
			Indexers.example();
			NamedAndOptionalParameters.example();
			ExtensionMethods.example();
			GenericTypes.example();

		}
	}
}
