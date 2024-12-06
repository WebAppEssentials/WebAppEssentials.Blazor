using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Components;

namespace WebAppEssentials.Services.Layout;

public class LayoutService : ILayoutService, INotifyPropertyChanged
{
    private SetHeader _headerSetter;
    public RenderFragment Header => HeaderSetter?.ChildContent;

    public SetHeader HeaderSetter
    {
        get => _headerSetter;
        set
        {
            if (_headerSetter == value) return;
            _headerSetter = value;
            UpdateHeader();
        }
    }

    public void UpdateHeader()
    {
        NotifyPropertyChanged(nameof(Header));
    }

    public event PropertyChangedEventHandler PropertyChanged;

    private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}