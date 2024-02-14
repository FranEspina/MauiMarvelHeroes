using CommunityToolkit.Maui;
using MauiMarvelHeroes.Pages;
using MauiMarvelHeroes.Services.MarvelApi;
using MauiMarvelHeroes.Services.Navigation;
using MauiMarvelHeroes.Services.RequestProvider;
using MauiMarvelHeroes.Services.Settings;
using MauiMarvelHeroes.ViewModels;
using Microsoft.Extensions.Logging;

namespace MauiMarvelHeroes
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()  
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .RegisterAppServices()
                .RegisterViewModels()
                .RegisterPages()
                .UseMauiCommunityToolkit();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            

            return builder.Build();
        }

        public static MauiAppBuilder RegisterAppServices(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<ISettingsService, SettingsService>();
            mauiAppBuilder.Services.AddSingleton<INavigationService, MauiNavigationService>();
            mauiAppBuilder.Services.AddSingleton<IRequestProvider, RequestProvider>();
            mauiAppBuilder.Services.AddSingleton<IMarvelApiService, MarvelApiService>();

            return mauiAppBuilder;
        }

        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<MainViewModel>();
            mauiAppBuilder.Services.AddSingleton<StartViewModel>();
            mauiAppBuilder.Services.AddSingleton<ComicsViewModel>();

            return mauiAppBuilder;
        }

        public static MauiAppBuilder RegisterPages(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<MainPage>();
            mauiAppBuilder.Services.AddTransient<StartPage>();
            mauiAppBuilder.Services.AddTransient<ComicsPage>();


            return mauiAppBuilder;
        }
    }
}
