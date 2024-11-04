namespace UIPlacasSolares.Views;

public partial class Gps : ContentPage
{
    /// <summary>
    /// vista Gps
    /// </summary>
    public Gps()
    {
        InitializeComponent();
    }
    /// <summary>
    /// Boton que navega a ExpedienteInforme
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void NavExpedienteInforme(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ExpedienteInforme());
    }
    /// <summary>
    /// Boton que navega a Citas
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void NavAtras(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Citas());
    }
}