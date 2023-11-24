namespace WLCS.ViewModels.Pages;

public partial class TitleViewModel : ViewModelBase
{
    public TitleViewModel(MainViewModel mainViewModel)
    {
        NewMeetCommand = new RelayCommand(() =>
        {
            mainViewModel.CurrentView = mainViewModel.MeetInfoInstance;
        });
    }

#if DEBUG
    public TitleViewModel()
    {
    }
#endif

    public ICommand? NewMeetCommand { get; }

    public ICommand? EditMeetCommand { get; }

    public ICommand? ViewMeetCommand { get; }

    public ICommand? ViewAthletesCommand { get; }
}
