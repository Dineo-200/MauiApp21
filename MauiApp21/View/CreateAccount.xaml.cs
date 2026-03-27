using MauiApp21.ViewModel;

namespace MauiApp21.View;

public partial class CreateAccount : ContentPage
{
	public CreateAccount()
	{
		InitializeComponent();

        //connecting our page to  the view model
        BindingContext = new SaveClientDetails();
    }
}