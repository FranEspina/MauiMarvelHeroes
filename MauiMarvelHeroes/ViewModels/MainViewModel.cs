using CommunityToolkit.Mvvm.Input;
using MauiMarvelHeroes.Pages;
using MauiMarvelHeroes.Services.Navigation;
using MauiMarvelHeroes.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMarvelHeroes.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        public MainViewModel(INavigationService navigationService)
        : base(navigationService)
        {

        }

        [RelayCommand]
        private async Task GotoMovies()
        {
            await NavigationService.NavigateToAsync(nameof(ComicsPage));
        }
    }
}
