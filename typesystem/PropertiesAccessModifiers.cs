using System;
namespace Typesystem.ReferenceTypes
{

	public interface InterfaceWithProperty
	{
		int PropertyFromInterface { get; set; }
		int PropertyFromInterfaceWithOneAccessor { get; }
	}

	public class PropertyAccessModifiersShowCase : InterfaceWithProperty
	{
		public int PublicProperty { get; set; }
		private int PrivateProperty { get; set; }
		protected int ProtectedProperty { get; set; }
		internal int InternalProperty { get; set; }
		protected internal int ProtectedInternalProperty { get; set; }

		public static int StaticProperty { get; set; }

		// we can set ONE accessor visibility other than whole property (but not wider and we need to respect overriding rules if apply)
		public int PublicGetterPrivateSetter { get; private set; }

		// cannot change visiblity of accessor if we have only one accessor in property
		public int OnlyGetter { /*private*/ get; }

		// we cannot change visibility of accessors inherited from intereface...
		public int PropertyFromInterface { get; /*private*/ set; }
		// ...but we can if interface defined only one accessor (we can change visiblity of the other one
		public int PropertyFromInterfaceWithOneAccessor { get; private set; }

		/*
		 * The difference between private setter and no setter:
		 * - private setter: you have access to it inside class
		 * - no setter: you have access to it only in constructor
		 */
		public int PropertyWithPrivateSetter { get; private set; }
		public int PropertyWithoutSetter { get; }

		public void usageOfPrivateSetter()
		{
			// we can use private setter here
			PropertyWithPrivateSetter = 12;

			// cannot do that - there is no setter
			// PropertyWithoutSetter = 10;
		}

		public PropertyAccessModifiersShowCase()
		{
			// in constructor we can use both - property with private setter and property without setter
			PropertyWithPrivateSetter = 12;
			PropertyWithoutSetter = 10;
		}

	}

}
