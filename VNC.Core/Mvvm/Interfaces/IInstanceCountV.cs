using System;

namespace VNC.Core.Mvvm
{
    public interface IInstanceCountV
    {
        /// <summary>
        /// Used to count the number of times parameterless constructor called
        /// </summary>
        Int32 InstanceCountV { get; set; }

        /// <summary>
        /// Used to count the number of times constructor called
        /// </summary>
        Int32 InstanceCountVP { get; set; }
    }
}
