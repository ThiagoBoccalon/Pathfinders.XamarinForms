using Xamarin.Forms;

namespace PathfindersClubApp.Views.Songs
{
    public partial class CoracaoDeReiPage : ContentPage
    {
        public CoracaoDeReiPage()
        {
            InitializeComponent();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromRgb(131, 72, 154);
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.White;
        }
    }
}
