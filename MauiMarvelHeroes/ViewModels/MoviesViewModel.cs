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
    public class MoviesViewModel : ViewModelBase
    {
        private readonly IMarvelApiService _marvelApiService;
        public MoviesViewModel(INavigationService navigationService, IMarvelApiService marvelApiService) : base(navigationService)
        {
            _marvelApiService = marvelApiService;
        }

        public override async Task InitializeAsync()
        {
            await _marvelApiService.GetComicsAsync(10, 0);
        }

    }
}
