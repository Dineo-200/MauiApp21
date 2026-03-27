using MauiApp21.ViewModel;

namespace MauiApp21;

public partial class forgetpassword : ContentPage
{
	public forgetpassword()
	{
		InitializeComponent();

        //connecting our page to  the view model
        BindingContext = new SaveClientDetails();
    }

    private void DisplayInformation_ItemTapped(object sender, ItemTappedEventArgs e)
    {

    }
}