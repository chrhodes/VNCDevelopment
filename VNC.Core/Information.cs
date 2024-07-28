namespace VNC.Core
{
    public class Information
    {
        public AssemblyInformation AssemblyInformation { get; set; } = new AssemblyInformation();
        public FileInformation FileInformation { get; set; } = new FileInformation();
        public string RuntimeVersion { get; set; }
    }
}
