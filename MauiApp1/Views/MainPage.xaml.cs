namespace MauiApp1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    private void BtnCambiarPagina_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Stack());
    }
}
