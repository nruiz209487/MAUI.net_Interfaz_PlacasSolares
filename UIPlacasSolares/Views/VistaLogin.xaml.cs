using System.Collections.ObjectModel;
using UIPlacasSolares.Models.ENT;
using UIPlacasSolares.ViewModels;

namespace UIPlacasSolares.Views;

public partial class Login : ContentPage
{
    public ObservableCollection<ClsUsuario> listaUsuarios { get; }
    /// <summary>
    /// vista login
    /// </summary>
    public Login()
    {
        InitializeComponent();
        listaUsuarios = LoginVM.ListaCitasVM;
        BindingContext = this;
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