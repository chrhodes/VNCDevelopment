using System;
using System.Threading.Tasks;

namespace VNC.Core.Mvvm
{
    public interface IDetailViewModel : IViewModel
    {
        Int32 Id { get; }

        string Title { get; }

        Boolean HasChanges { get; }

        Task LoadAsync(Int32 id);
    }
}
