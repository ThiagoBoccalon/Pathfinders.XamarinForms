using Xamarin.Forms;

namespace PathfindersClubApp.Views.Units
{
    public partial class CangurusUnitPage : ContentPage
    {
        public CangurusUnitPage()
        {
            InitializeComponent();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromRgb(56, 123, 193);
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.White;
        }
    }
}
