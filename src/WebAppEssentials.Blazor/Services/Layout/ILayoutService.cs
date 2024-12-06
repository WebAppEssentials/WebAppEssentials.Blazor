using System.ComponentModel;
using Microsoft.AspNetCore.Components;

namespace WebAppEssentials.Services.Layout;

public interface ILayoutService
{
    RenderFragment Header { get; }
    SetHeader HeaderSetter { get; set; }
    event PropertyChangedEventHandler PropertyChanged;
    void UpdateHeader();
}