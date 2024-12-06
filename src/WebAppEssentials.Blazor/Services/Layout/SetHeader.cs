using Microsoft.AspNetCore.Components;

namespace WebAppEssentials.Services.Layout;

public class SetHeader : ComponentBase, IDisposable
{
    [Inject] private ILayoutService Layout { get; set; }

    [Parameter] public RenderFragment ChildContent { get; set; }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected override void OnInitialized()
    {
        if (Layout != null) Layout.HeaderSetter = this;
        base.OnInitialized();
    }

    protected override bool ShouldRender()
    {
        var shouldRender = base.ShouldRender();
        if (shouldRender) Layout.UpdateHeader();
        return shouldRender;
    }

    protected virtual void Dispose(bool disposing)
    {
        if (Layout != null) Layout.HeaderSetter = null;
    }
}