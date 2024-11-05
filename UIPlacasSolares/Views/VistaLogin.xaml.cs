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

        String textoUsuario = usuarioEntry.Text;
        String textoContrasenya = contrasenyaEntry.Text;
        if (textoUsuario != "" && textoUsuario != null && textoContrasenya != "" && textoContrasenya != null)
        {
            if (listaUsuarios.Any(u => u.nombre == textoUsuario && u.contrasenya == textoContrasenya))
            {
                await Navigation.PushAsync(new Citas());
            }
            else { errorLoginLabel.IsVisible = true; }
        }
     

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