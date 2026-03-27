using MauiApp21.ViewModel;

namespace MauiApp21
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            //connecting our page to  the view model
            BindingContext = new SaveClientDetails();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///signin");
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            string email = EmailEntryField.Text;
            string password = PasswordEntryField.Text;

            //Validate
            if (string.IsNullOrWhiteSpace(email)  || string.IsNullOrWhiteSpace(password))
            {
                await DisplayAlert("error", "please enter both field", "ok");
            }

            else if(email =="ldil" && password == "2026")
            {
                await DisplayAlert("success", "login successful", "ök");

                //clear the fields
                EmailEntryField.Text = "";
                PasswordEntryField.Text = "";

                //navigate to the home page
                await Shell.Current.GoToAsync("///HomePage");
            }
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///forgetpassword");
        }
        bool IsPasswordHidden = false;
        private void ShowHidePassword_Clicked(object sender, EventArgs e)
        {
            //Flips the values
            IsPasswordHidden = IsPasswordHidden;

            //change the password visibility
            PasswordEntryField.IsPassword = IsPasswordHidden;

            //Change the icons
            ShowHidePassword.Source = IsPasswordHidden ? "hide.png" : "show.png";
        }
    }
}
