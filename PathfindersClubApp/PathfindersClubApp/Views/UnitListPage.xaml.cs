using PathfindersClubApp.Models;
using PathfindersClubApp.ViewModels;
using Prism.Navigation;
using System;
using Xamarin.Forms;

namespace PathfindersClubApp.Views
{
    public partial class UnitListPage : ContentPage
    {
        private INavigationService _navigationService;

        public UnitListPage(){
            InitializeComponent();            
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromRgb(56, 123, 193);
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.White;
        }
        
        void ListViewTapped(object sender, ItemTappedEventArgs e)
        {
            unidadesListView.ClearValue();
        }
        
        protected override void OnAppearing()
        {
            base.OnAppearing();
            unidadesListView.ItemTapped += ListViewTapped;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            unidadesListView.ItemTapped -= ListViewTapped;
            
        }
        
    }
}
