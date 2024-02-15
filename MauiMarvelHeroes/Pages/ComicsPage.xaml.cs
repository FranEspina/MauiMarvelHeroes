using MauiMarvelHeroes.ViewModels;
using Microsoft.Maui.Controls;

namespace MauiMarvelHeroes.Pages;

public partial class ComicsPage : ContentPageBase
{

    
	public ComicsPage(ComicsViewModel viewModel)
	{
		this.BindingContext = viewModel;

		InitializeComponent();
    }
}