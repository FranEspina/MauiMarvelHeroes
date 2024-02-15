using MauiMarvelHeroes.Models.MarvelApi;
using MauiMarvelHeroes.Services.MarvelApi;
using MauiMarvelHeroes.Services.Navigation;

namespace MauiMarvelHeroes.ViewModels;

public partial class ComicSeriesViewModel : MarvelViewModel<MarvelComicSerie>
{
    public ComicSeriesViewModel(INavigationService navigationService, IMarvelApiService marvelApiService) : base(navigationService, marvelApiService)
    {
    }
}
