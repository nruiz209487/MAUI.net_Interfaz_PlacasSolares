namespace UIPlacasSolares
{
    using UIPlacasSolares.Views;
    public partial class MainPage : ContentPage
    {

        /// <summary>
        /// vista mainpage
        /// </summary>
        public MainPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Boton que navega a Login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void NavLogin(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }

    }

}
