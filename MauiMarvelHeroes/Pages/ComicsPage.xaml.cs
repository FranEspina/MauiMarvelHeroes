using MauiMarvelHeroes.ViewModels;

namespace MauiMarvelHeroes.Pages;

public partial class ComicsPage : ContentPageBase
{
	public ComicsPage(ComicsViewModel viewModel)
	{
		this.BindingContext = viewModel;

		InitializeComponent();

    }
}