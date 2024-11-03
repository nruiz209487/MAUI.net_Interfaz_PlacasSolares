namespace UIPlacasSolares.Views;

public partial class Login : ContentPage
{
    /// <summary>
    /// vista login
    /// </summary>
    public Login()
    {
        InitializeComponent();
    }
    /// <summary>
    /// Boton que navega a Citas
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void NavCitas(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Citas());
    }
    /// <summary>
    /// Boton que navega a MainPage
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void NavAtras(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}