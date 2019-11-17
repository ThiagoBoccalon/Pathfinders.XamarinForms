using Xamarin.Forms;

namespace PathfindersClubApp.Views
{
    public partial class UnitListPage : ContentPage
    {
        public UnitListPage()
        {
            InitializeComponent();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromRgb(56, 123, 193);
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.White;            
        }
    }
}
