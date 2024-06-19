
namespace VNC.Core.Mvvm
{
    public interface IInstanceCountV
    {
        /// <summary>
        /// Used to count the number of times parameterless constructor called
        /// </summary>
        int InstanceCountV { get; set; }

        /// <summary>
        /// Used to count the number of times constructor called
        /// </summary>
        int InstanceCountVP { get; set; }
    }
}
