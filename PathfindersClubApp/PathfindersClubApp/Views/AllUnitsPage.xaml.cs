using PathfindersClubApp.Models;
using PathfindersClubApp.ViewModels;
using Xamarin.Forms;

namespace PathfindersClubApp.Views
{
    public partial class AllUnitsPage : ContentPage
    {        
        public AllUnitsPage()
        {
            InitializeComponent();
            Set();
        }

        private void Set()
        {
            var txt = bandeiraUnidade;
            stackTest.Children.Add(new Label { Text = "Examplo 1" });
            stackTest.Children.Add(new Label { Text = "Examplo 2" });
        }
    }
}
