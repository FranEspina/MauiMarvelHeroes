using MauiMarvelHeroes.ViewModels;

namespace MauiMarvelHeroes.Pages;

public partial class CharactersPage : ContentPageBase
{
	public CharactersPage(CharactersViewModel viewModel)
	{
		this.BindingContext = viewModel;

		InitializeComponent();

    }
}