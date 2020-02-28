using System;

[assembly: CLSCompliant(true)]
namespace AttributedCarLibrary
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false)]
    public sealed class VehicleDescriptionAttribute : Attribute
    {
        public string Description { get; set; }
        public VehicleDescriptionAttribute(string vehicleDescription) => Description = vehicleDescription;
        public VehicleDescriptionAttribute() { }
    }
}
