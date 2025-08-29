using Prism.Events;

namespace VNC.Core.Events
{
    /// <summary>
    /// ModuleLoadedEvent is used to indicate that a module has been loaded.
    /// Name of module is passed as string.
    /// </summary>
    public class ModuleLoadedEvent : PubSubEvent<string> { }
}
