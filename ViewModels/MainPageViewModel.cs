using NestedRegionsNotInjectableOnAndroidIssue.Views;

namespace NestedRegionsNotInjectableOnAndroidIssue.ViewModels;

public class MainPageViewModel : BindableBase, INavigatedAware
{
    private readonly IRegionManager _regionManager;

    public DelegateCommand StartIssueCommand { get; }

    public MainPageViewModel(INavigationService navigationService, IRegionManager regionManager)
    {
        _regionManager = regionManager;

        StartIssueCommand = new DelegateCommand(OnStartIssue);
    }

    private void OnStartIssue()
    {
        _regionManager.RequestNavigate(RegionNames.FirstLevelRegion, nameof(B_g), NavigationCallback);
    }

    private void NavigationCallback(NavigationResult obj)
    {
        
    }

    public void OnNavigatedFrom(INavigationParameters parameters)
    {
        
    }

    public void OnNavigatedTo(INavigationParameters parameters)
    {
        
    }
}