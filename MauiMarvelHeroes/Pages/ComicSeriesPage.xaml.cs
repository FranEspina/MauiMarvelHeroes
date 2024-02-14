using MauiMarvelHeroes.ViewModels;

namespace MauiMarvelHeroes.Pages;

public partial class ComicSeriesPage : ContentPageBase
{
	public ComicSeriesPage(ComicSeriesViewModel viewModel)
	{
		this.BindingContext = viewModel;

		InitializeComponent();

    }
}