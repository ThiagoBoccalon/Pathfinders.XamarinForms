using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfindersClubApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private INavigationService _navigationService;
        public DelegateCommand NavigateToAboutPageCommand { get; set; }
        //public DelegateCommand NavigateToUnitListPageCommand { get; set; }
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Atalaia Internacional";
            _navigationService = navigationService;
            NavigateToAboutPageCommand = new DelegateCommand(ExecuteNavigateToAboutPage);
            //NavigateToUnitListPageCommand = new DelegateCommand(ExecuteNavigateToUnitListPage);
        }
        
        private void ExecuteNavigateToAboutPage()
        {
            try
            {
                _navigationService.NavigateAsync("AboutPage");
            }
            catch (Exception ex)
            {
                App.Current.MainPage.DisplayAlert("Error", ex.Message, "Ok");
            }
        }
        /*
        private void ExecuteNavigateToUnitListPage()
        {
            try
            {
                _navigationService.NavigateAsync("UnitList");
            }
            catch(Exception ex)
            {
                App.Current.MainPage.DisplayAlert("Error", ex.Message, "Ok");
            }            
        }*/
    }
}
