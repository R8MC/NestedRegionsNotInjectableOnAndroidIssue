using Microsoft.Extensions.Logging;
using NestedRegionsNotInjectableOnAndroidIssue.ViewModels;
using NestedRegionsNotInjectableOnAndroidIssue.Views;

namespace NestedRegionsNotInjectableOnAndroidIssue
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder
                .UseMauiApp<App>()
                .UsePrism(prism => prism
                    .ConfigureLogging(l => l.AddDebug())
                    .RegisterTypes(containerRegistry =>
                    {
                        containerRegistry.RegisterForRegionNavigation<B_g>(nameof(B_g));
                        containerRegistry.RegisterForRegionNavigation<C_g>(nameof(C_g));
                        

                        containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
                    })
                    .CreateWindow(async (container, navigation) =>
                    {
                        var startUri = "NavigationPage/MainPage";

                        var result = await navigation.NavigateAsync(startUri);
                        if (!result.Success)
                            container.Resolve<ILogger<App>>()
                                .LogError(result.Exception, "Startup-Navigation failed");
                    })
                );

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
