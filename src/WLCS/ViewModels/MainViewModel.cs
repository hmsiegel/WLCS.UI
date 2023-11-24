namespace WLCS.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private ViewModelBase? _currentView;

    public MainViewModel()
    {
        MeetInfoInstance = new MeetInfoViewModel(this);
        TitleInstance = new TitleViewModel(this);
        CurrentView = TitleInstance;
    }

    public TitleViewModel TitleInstance { get; }

    public MeetInfoViewModel MeetInfoInstance { get; }
}
