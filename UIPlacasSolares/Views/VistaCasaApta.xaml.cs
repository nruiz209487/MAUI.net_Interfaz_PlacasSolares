namespace UIPlacasSolares.Views;

public partial class CasaApta : ContentPage
{
    private Boolean opcionSelecionada;

    /// <summary>
    /// vista que muestra la pagina CasaApta
    /// </summary>
    public CasaApta()
    {
        InitializeComponent();
    }
    private void OnCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        opcionSelecionada = e.Value;
    }

    /// <summary>
    /// Boton que navega a Citas
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void NavCitas(object sender, EventArgs e)
    {
        if (opcionSelecionada)
        {
            await Navigation.PushAsync(new Citas());
        }
        else { errorBotonCasaApta.IsVisible = true; }
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