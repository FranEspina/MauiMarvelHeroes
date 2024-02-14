using MauiMarvelHeroes.Models.MarvelApi;
using MauiMarvelHeroes.Services.MarvelApi;
using MauiMarvelHeroes.Services.Navigation;

namespace MauiMarvelHeroes.ViewModels;

public partial class ComicSeriesViewModel : MarvelViewModel<MarvelComic>
{
    public ComicSeriesViewModel(INavigationService navigationService, IMarvelApiService marvelApiService) : base(navigationService, marvelApiService)
    {
    }
}
