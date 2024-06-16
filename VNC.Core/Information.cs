namespace VNC.Core
{
    public class Information
    {
        public AssemblyInformation AssemblyInformation = new AssemblyInformation();
        public FileInformation FileInformation = new FileInformation();
        public string RuntimeVersion { get; set; }
    }
}
