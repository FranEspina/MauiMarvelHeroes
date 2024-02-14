using MauiMarvelHeroes.Models.MarvelApi;
using MauiMarvelHeroes.Services.MarvelApi;
using MauiMarvelHeroes.Services.Navigation;

namespace MauiMarvelHeroes.ViewModels;

public partial class ComicsViewModel : MarvelViewModel<MarvelComic>
{
    public ComicsViewModel(INavigationService navigationService, IMarvelApiService marvelApiService) : base(navigationService, marvelApiService)
    {
    }
}
