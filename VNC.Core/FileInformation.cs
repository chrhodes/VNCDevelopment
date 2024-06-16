namespace VNC.Core
{
    public class FileInformation
    {
        public string FileVersion { get; set; }
        public string FileDescription { get; set; }

        public string ProductName { get; set; }
        public string InternalName { get; set; }
        public string ProductVersion { get; set; }

        public string ProductMajorPart { get; set; }
        public string ProductMinorPart { get; set; }
        public string ProductBuildPart { get; set; }
        public string ProductPrivatePart { get; set; }

        public string Comments { get; set; }

        public bool IsDebug { get; set; }
        public bool IsPatched { get; set; }
        public bool IsPreRelease { get; set; }
        public bool IsPrivateBuild { get; set; }
        public bool IsSpecialBuild { get; set; }
    }
}
