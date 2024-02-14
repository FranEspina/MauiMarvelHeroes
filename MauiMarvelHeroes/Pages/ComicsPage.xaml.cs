using MauiMarvelHeroes.ViewModels;

namespace MauiMarvelHeroes.Pages;

public partial class ComicsPage : ContentPageBase
{
	public ComicsPage(ComicsViewModel moviesViewModel)
	{
		this.BindingContext = moviesViewModel;

		InitializeComponent();
	}
}