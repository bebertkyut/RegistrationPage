using RegistrationPage.Pages;

namespace RegistrationPage
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void BTNLogin(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrationFormPTII());
        }
    }
}