using Xamarin.Forms;

namespace PathfindersClubApp.Views
{
    public partial class DirectorsPage : ContentPage
    {
        public DirectorsPage()
        {
            InitializeComponent();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromRgb(217, 68, 74);
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.White;
        }
    }
}
