using Xamarin.Forms;

namespace PathfindersClubApp.Views
{
    public partial class SongListPage : ContentPage
    {
        public SongListPage()
        {
            InitializeComponent();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromRgb(131, 72, 154);
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.White;
        }
    }
}
