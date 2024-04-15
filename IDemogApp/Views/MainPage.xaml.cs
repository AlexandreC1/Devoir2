using Devoir2.ViewModels;

namespace Devoir2.Views;



public partial class MainPage : ContentPage
{
	public MainPage(MainPageViewModel mainPageViewModel)
	{
        InitializeComponent();
        BindingContext = mainPageViewModel;
    }

}