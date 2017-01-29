using System;
namespace typesystem
{
	public abstract class PropertiesAndInheritance
	{

		public abstract int AbstractProperty { get; set; }
		public virtual int VirtualProperty { get; set; }

	}

	public class InheritanceAndProperties : PropertiesAndInheritance
	{
		public override int AbstractProperty { get; set; }
		sealed public override int VirtualProperty { get; set; }
	}

}
