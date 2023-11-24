namespace WLCS.ViewModels.Pages;

public partial class MeetInfoViewModel : ViewModelBase
{
    public MeetInfoViewModel(MainViewModel mainViewModel)
    {
        var mainViewModel1 = mainViewModel;

        NavigateToTitleCommand = new RelayCommand(() =>
        {
            mainViewModel1.CurrentView = mainViewModel1.TitleInstance;
        });
    }

#if DEBUG
    public MeetInfoViewModel()
    {
    }
#endif

    public ICommand? CreateMeetCommand { get; }

    public ICommand? NavigateToTitleCommand { get; }
}
