namespace UIPlacasSolares.Views;

public partial class ExpedienteInforme : ContentPage
{/// <summary>
/// vitsa ExpedienteInforme
/// </summary>
    public ExpedienteInforme()
    {
        InitializeComponent();
    }
    /// <summary>
    /// Boton que navega a CasaApta
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void NavCasaApta(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CasaApta());
    }
    /// <summary>
    /// Boton que navega a Gps
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void NavAtras(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Gps());
    }
}