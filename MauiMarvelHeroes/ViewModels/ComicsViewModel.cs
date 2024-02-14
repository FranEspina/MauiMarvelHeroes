using CommunityToolkit.Mvvm.ComponentModel;
using MauiMarvelHeroes.Services.MarvelApi;
using MauiMarvelHeroes.Services.Navigation;
using MauiMarvelHeroes.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMarvelHeroes.ViewModels
{
    public partial class ComicsViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string copyright;

        [ObservableProperty]
        private string attributionText;


        private readonly IMarvelApiService _marvelApiService;
        public ComicsViewModel(INavigationService navigationService, IMarvelApiService marvelApiService) : base(navigationService)
        {
            _marvelApiService = marvelApiService;
        }

        public override async Task InitializeAsync()
        {
            var response = await _marvelApiService.GetComicsAsync(10, 0);
        }

    }
}
