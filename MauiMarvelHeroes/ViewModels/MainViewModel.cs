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
        private async Task GotoComics()
        {
            await NavigationService.NavigateToAsync(nameof(ComicsPage));
        }

        [RelayCommand]
        private async Task GotoCharacters()
        {
            await NavigationService.NavigateToAsync(nameof(CharactersPage));
        }

        [RelayCommand]
        private async Task GotoComicSeries()
        {
            await NavigationService.NavigateToAsync(nameof(ComicSeriesPage));
        }
    }
}
