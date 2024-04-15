using System.ComponentModel;
using System.Windows.Input;

namespace FormattedTextGestureRecognizerBug;

internal class MainPageViewModel : INotifyPropertyChanged
{
    private int _tapCount;

    public MainPageViewModel()
    {
        TapCommand = new Command(() => TapCount++);
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public ICommand TapCommand { get; }

    public int TapCount 
    {
        get => _tapCount; 
        set
        {
            _tapCount = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TapCount)));
        }
    }
}
