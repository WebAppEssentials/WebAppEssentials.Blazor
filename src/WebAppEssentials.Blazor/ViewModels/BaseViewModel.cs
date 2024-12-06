using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WebAppEssentials.ViewModels;

public abstract class BaseViewModel
{
    private bool _isBusy;
    private string? _message;
    private string? _messageLevel;

    public bool IsBusy
    {
        get => _isBusy;
        set
        {
            _isBusy = value;
            OnPropertyChanged();
        }
    }

    public string? Message
    {
        get => _message;
        set
        {
            _message = value;
            OnPropertyChanged();
        }
    }

    public string MessageLevel
    {
        get => _messageLevel;
        set
        {
            _messageLevel = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}