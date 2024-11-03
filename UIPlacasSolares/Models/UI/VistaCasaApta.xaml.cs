namespace UIPlacasSolares.Views;

public partial class CasaApta : ContentPage
{
    /// <summary>
    /// vista que muestra la pagina CasaApta
    /// </summary>
    public CasaApta()
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
    /// Boton que navega a ExpedienteInforme
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void NavAtras(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ExpedienteInforme());
    }

}