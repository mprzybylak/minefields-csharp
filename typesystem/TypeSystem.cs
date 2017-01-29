using System;
using Typesystem.ValueTypes;

namespace typesystem
{
	public static class TypeSystem
	{
		public static void Main()
		{
			ValueTypesInitialization.example();
			ValueTypeAliases.example();
			UserDefinedStructs.example();
			UserDefinedEnums.example();
		}
	}
}
