using MauiMarvelHeroes.Services.Navigation;
using MauiMarvelHeroes.Services.Settings;

namespace MauiMarvelHeroes
{
    public partial class App : Application
    {
        private readonly ISettingsService _settingsService;
        private readonly INavigationService _navigationService;

        public App(
            ISettingsService settingsService,
            INavigationService navigationService)
        {
            _settingsService = settingsService;
            _navigationService = navigationService;
            
            InitializeComponent();

            InitApp();

            MainPage = new AppShell(navigationService);
        }

        private void InitApp()
        {
            if (VersionTracking.IsFirstLaunchEver)
            {
                _settingsService.SkipIntro = false;
            }

#if DEBUG
            _settingsService.SkipIntro = true;
#endif

        }
    }
}
