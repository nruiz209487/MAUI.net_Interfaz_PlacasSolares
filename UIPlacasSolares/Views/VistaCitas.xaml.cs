using System.Collections.ObjectModel;
using UIPlacasSolares.ENT;
using UIPlacasSolares.ViewModels;

namespace UIPlacasSolares.Views;

public partial class Citas : ContentPage
{
    /// <summary>
    /// ObservableCollection de la clase ClsCita con el el metodo get
    /// </summary>
    public ObservableCollection<ClsCita> listaCitas { get;}
    /// <summary>
    /// Pagina citas que llama a la funcion en ClsListaPersonas.ObtenerCitas() para importar la lista 
    /// </summary>
    public Citas()
    {
        InitializeComponent();
        listaCitas = CitasVM.ListaCitasVM;
        BindingContext = this;
    }
    /// <summary>
    /// Boton que navega a Gps
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void OnItemTapped(object sender, ItemTappedEventArgs e)
    {
        await Navigation.PushAsync(new Gps());
    }
    /// <summary>
    /// Boton que navega a Login
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void NavAtras(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Login());
    }
}