using MauiMarvelHeroes.ViewModels;
using Microsoft.Maui.Controls;

namespace MauiMarvelHeroes.Pages;

public partial class CharactersPage : ContentPageBase
{
	public CharactersPage(CharactersViewModel viewModel)
	{
		this.BindingContext = viewModel;
        InitializeComponent();
    }
}