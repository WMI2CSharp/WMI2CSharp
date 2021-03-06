using WMI2CSharp.Attributes;

namespace WMI2CSharp.Models.DeviceModels
{
    [WMIClass("Win32_OperatingSystem")]
    public class OperatingSystem
    {
        public string BootDevice { get; set; }
        public string BuildNumber { get; set; }
        public string BuildType { get; set; }
        public string Caption { get; set; }
        public string CodeSet { get; set; }
        public string CountryCode { get; set; }
        public string CreationClassName { get; set; }
        public string CSCreationClassName { get; set; }
        public string CSDVersion { get; set; }
        public string CSName { get; set; }
        public int CurrentTimeZone { get; set; }
        public bool DataExecutionPrevention_32BitApplications { get; set; }
        public bool DataExecutionPrevention_Available { get; set; }
        public bool DataExecutionPrevention_Drivers { get; set; }
        public byte DataExecutionPrevention_SupportPolicy { get; set; }
        public bool Debug { get; set; }
        public string Description { get; set; }
        public bool Distributed { get; set; }
        public uint EncryptionLevel { get; set; }
        public byte ForegroundApplicationBoost { get; set; }
        public ulong FreePhysicalMemory { get; set; }
        public ulong FreeSpaceInPagingFiles { get; set; }
        public ulong FreeVirtualMemory { get; set; }
        public string InstallDate { get; set; }
        public uint LargeSystemCache { get; set; }
        public string LastBootUpTime { get; set; }
        public string LocalDateTime { get; set; }
        public string Locale { get; set; }
        public string Manufacturer { get; set; }
        public uint MaxNumberOfProcesses { get; set; }
        public ulong MaxProcessMemorySize { get; set; }
        public string[] MUILanguages { get; set; }
        public string Name { get; set; }
        public uint NumberOfLicensedUsers { get; set; }
        public uint NumberOfProcesses { get; set; }
        public uint NumberOfUsers { get; set; }
        public uint OperatingSystemSKU { get; set; }
        public string Organization { get; set; }
        public string OSArchitecture { get; set; }
        public uint OSLanguage { get; set; }
        public uint OSProductSuite { get; set; }
        public ushort OSType { get; set; }
        public string OtherTypeDescription { get; set; }
        public bool PAEEnabled { get; set; }
        public string PlusProductID { get; set; }
        public string PlusVersionNumber { get; set; }
        public bool PortableOperatingSystem { get; set; }
        public bool Primary { get; set; }
        public uint ProductType { get; set; }
        public string RegisteredUser { get; set; }
        public string SerialNumber { get; set; }
        public ushort ServicePackMajorVersion { get; set; }
        public ushort ServicePackMinorVersion { get; set; }
        public ulong SizeStoredInPagingFiles { get; set; }
        public string Status { get; set; }
        public uint SuiteMask { get; set; }
        public string SystemDevice { get; set; }
        public string SystemDirectory { get; set; }
        public string SystemDrive { get; set; }
        public string TotalSwapSpaceSize { get; set; }
        public ulong TotalVirtualMemorySize { get; set; }
        public ulong TotalVisibleMemorySize { get; set; }
        public string Version { get; set; }
        public string WindowsDirectory { get; set; }

        public override string ToString()
        {
            return Name + " " + Caption;
        }
    }
}
