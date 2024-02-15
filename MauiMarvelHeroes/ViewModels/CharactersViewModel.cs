using MauiMarvelHeroes.Models.MarvelApi;
using MauiMarvelHeroes.Services.MarvelApi;
using MauiMarvelHeroes.Services.Navigation;

namespace MauiMarvelHeroes.ViewModels;

public partial class CharactersViewModel : MarvelViewModel<MarvelCharacter>
{
    public CharactersViewModel(INavigationService navigationService, IMarvelApiService marvelApiService) : base(navigationService, marvelApiService)
    {
    }
}
