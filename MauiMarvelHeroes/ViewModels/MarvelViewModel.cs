using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiMarvelHeroes.Helpers;
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
    public partial class MarvelViewModel<T> : ViewModelBase where T : IMarvelQueryable
    {
        private readonly IMarvelApiService _marvelApiService;
        
        private readonly uint _limit = 8;
        private uint _offset = 0;

        [ObservableProperty]
        private string copyright = "";

        [ObservableProperty]
        private string attributionText = "";

        [ObservableProperty]
        private ObservableCollection<T> items = new();

        public MarvelViewModel(INavigationService navigationService, IMarvelApiService marvelApiService) : base(navigationService)
        {
            _marvelApiService = marvelApiService;
        }

        public override async Task InitializeAsync()
        {
            var response = await _marvelApiService.GetMarvelListAsync<T>(_limit, _offset);

            Copyright = response.Copyright;
            AttributionText = response.AttributionText;
            Items = new ObservableCollection<T>(response.Data.Results.Where(i => i.HasThumbnail()));
        }

        [RelayCommand]
        private async Task LoadMoreItems()
        {
            _offset += _limit;

            await IsBusyFor(async () =>
                    {
                        var response = await _marvelApiService.GetMarvelListAsync<T>(_limit, _offset);
                        var items = response.Data.Results.Where(i => i.HasThumbnail());
                        foreach (var item in items)
                        {
                            Items.Add(item);
                        }
                    });
        }
    }
}
