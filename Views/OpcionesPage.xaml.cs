using AppSanJuan2025.Views.Novenario;
using AppSanJuan2025.Views.Actividades;
namespace AppSanJuan2025.Views;

public partial class OpcionesPage : ContentPage
{
	public OpcionesPage()
	{
		InitializeComponent();
	}

    private  async void btnNovenario_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AppSanJuan2025.Views.Novenario.Novenario());
    }

    private async void btnActividades_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AppSanJuan2025.Views.Actividades.Actividades());
    }
}
