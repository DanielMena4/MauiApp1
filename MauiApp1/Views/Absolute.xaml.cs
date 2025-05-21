namespace MauiApp1;

public partial class Absolute : ContentPage
{
	public Absolute()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PopToRootAsync();
    }
}