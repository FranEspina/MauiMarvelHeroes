using CommunityToolkit.Mvvm.Input;
using MauiMarvelHeroes.Services.Navigation;
using MauiMarvelHeroes.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMarvelHeroes.ViewModels
{
    public partial class StartViewModel : ViewModelBase
    {
        public StartViewModel(INavigationService navigationService) : base(navigationService)
        {
            
        }

        [RelayCommand]
        private async Task GotoMainPage()
        {
            await NavigationService.NavigateToAsync("//MainPage");
        }
    }
}
