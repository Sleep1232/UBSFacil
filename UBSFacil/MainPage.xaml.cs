using UBSFacil.View;

namespace UBSFacil
{
    public partial class MainPage : ContentPage
    {
      
        public MainPage()
        {
            InitializeComponent();
        }

        //desenvolver a lógica de cadastro
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastroPage());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }

}
