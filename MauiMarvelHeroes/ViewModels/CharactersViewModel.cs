using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiMarvelHeroes.Models.MarvelApi;
using MauiMarvelHeroes.Services.MarvelApi;
using MauiMarvelHeroes.Services.Navigation;
using MauiMarvelHeroes.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMarvelHeroes.ViewModels
{
    public partial class CharactersViewModel : ViewModelBase
    {
        private readonly IMarvelApiService _marvelApiService;
        
        private readonly uint _limit = 10;
        private uint _offset = 0;

        [ObservableProperty]
        private string copyright = "";

        [ObservableProperty]
        private string attributionText = "";

        [ObservableProperty]
        private ObservableCollection<MarvelCharacter> characters = new();

        public CharactersViewModel(INavigationService navigationService, IMarvelApiService marvelApiService) : base(navigationService)
        {
            _marvelApiService = marvelApiService;
        }

        public override async Task InitializeAsync()
        {
            var response = await _marvelApiService.GetCharactersAsync(_limit, _offset);

            Copyright = response.Copyright;
            AttributionText = response.AttributionText;
            Characters = new ObservableCollection<MarvelCharacter>(response.Data.Results);
        }

        [RelayCommand]
        private async Task LoadMoreItems()
        {
            _offset += _limit;

            await IsBusyFor(async () =>
                    {
                        var response = await _marvelApiService.GetCharactersAsync(_limit, _offset);
                        var characters = response.Data.Results;
                        foreach (var character in characters)
                        {
                            Characters.Add(character);
                        }
                    });
        }
    }
}
