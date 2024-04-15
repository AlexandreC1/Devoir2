using Devoir2.ViewModels;

namespace Devoir2.Views;

public partial class AjoutPage : ContentPage
{
	public AjoutPage(AjoutPageViewModel ajoutPageViewModel)
	{
		InitializeComponent();

		BindingContext = ajoutPageViewModel;
	}
}