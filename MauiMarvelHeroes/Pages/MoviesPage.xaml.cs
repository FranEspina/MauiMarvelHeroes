using MauiMarvelHeroes.ViewModels;

namespace MauiMarvelHeroes.Pages;

public partial class MoviesPage : ContentPageBase
{
	public MoviesPage(MoviesViewModel moviesViewModel)
	{
		this.BindingContext = moviesViewModel;

		InitializeComponent();
	}
}