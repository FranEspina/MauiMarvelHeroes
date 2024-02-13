using MauiMarvelHeroes.Extensions;
using MauiMarvelHeroes.ViewModels;
using System.Runtime.CompilerServices;

namespace MauiMarvelHeroes.Pages;

public partial class MainPage : ContentPageBase
{
	public MainPage(MainViewModel viewModel)
	{
		this.BindingContext = viewModel;

		InitializeComponent();

        imgHeroes.Clicked += (s, e) => imgHeroes.AnimateOnClick();
        imgComics.Clicked += (s, e) => imgComics.AnimateOnClick();
        imgFilms.Clicked += (s, e) => imgFilms.AnimateOnClick();

    }


}