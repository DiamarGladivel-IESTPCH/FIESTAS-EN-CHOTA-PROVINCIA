namespace AppSanJuan2025
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        private async void BtnVerPrograma_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AppSanJuan2025.Views.OpcionesPage());
        }
    }

}
