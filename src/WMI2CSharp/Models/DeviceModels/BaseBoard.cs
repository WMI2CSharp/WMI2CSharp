using WMI2CSharp.Attributes;

namespace WMI2CSharp.Models.DeviceModels
{
    [WMIClass("Win32_BaseBoard")]
    public class BaseBoard
    {
        public string Caption { get; set; }
        public string[] ConfigOptions { get; set; }
        public string CreationClassName { get; set; }
        public string Depth { get; set; }
        public string Description { get; set; }
        public float Height { get; set; }
        public bool HostingBoard { get; set; }
        public bool HotSwappable { get; set; }
        public string InstallDate { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }
        public string OtherIdentifyingInfo { get; set; }
        public string PartNumber { get; set; }
        public bool PoweredOn { get; set; }
        public string Product { get; set; }
        public bool Removable { get; set; }
        public bool Replaceable { get; set; }
        public string RequirementsDescription { get; set; }
        public bool RequiresDaughterBoard { get; set; }
        public string SerialNumber { get; set; }
        public string SKU { get; set; }
        public string SlotLayout { get; set; }
        public string SpecialRequirements { get; set; }
        public string Status { get; set; }
        public string Tag { get; set; }
        public string Version { get; set; }
        public string Weight { get; set; }
        public float Width { get; set; }

        public override string ToString()
        {
            return Name + " " + Caption;
        }
    }
}
