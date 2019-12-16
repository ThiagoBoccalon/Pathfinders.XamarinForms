using Xamarin.Forms;

namespace PathfindersClubApp.Views.Songs
{
    public partial class HinoDesbravadoresPage : ContentPage
    {
        public HinoDesbravadoresPage()
        {
            InitializeComponent();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromRgb(131, 72, 154);
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.White;
        }
    }
}
