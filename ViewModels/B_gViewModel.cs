namespace NestedRegionsNotInjectableOnAndroidIssue.ViewModels;

public partial class B_gViewModel : BindableBase, INavigatedAware
{
    private readonly IRegionManager _regionManager;
    private readonly INavigationService _navigationService;

    public B_gViewModel(IRegionManager regionManager, INavigationService navigationService)
    {
        _regionManager = regionManager;
        _navigationService = navigationService;
    }

    public void OnNavigatedFrom(INavigationParameters parameters)
    {
        
    }

    public void OnNavigatedTo(INavigationParameters parameters)
    {
        
    }
}