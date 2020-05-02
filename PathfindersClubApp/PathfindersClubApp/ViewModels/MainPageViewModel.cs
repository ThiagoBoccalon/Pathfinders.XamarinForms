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
        public DelegateCommand NavigateToUnitListPageCommand { get; set; }
        public DelegateCommand NavigateToSongListPageCommand { get; set; }
        public DelegateCommand NavigateToDirectorsPageCommand { get; set; }
        public DelegateCommand NavigateToCalendarPageCommand { get; set; }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Clube Atalaia Internacional";
            _navigationService = navigationService;
            NavigateToAboutPageCommand = new DelegateCommand(ExecuteNavigateToAboutClubPage);
            NavigateToUnitListPageCommand = new DelegateCommand(ExecuteNavigateToUnitListPage);            
            NavigateToSongListPageCommand = new DelegateCommand(ExecuteNavigateToSongListPage);
            NavigateToDirectorsPageCommand = new DelegateCommand(ExecuteNavigateToDirectorsPage);
            NavigateToCalendarPageCommand = new DelegateCommand(ExecuteNavigateToCalendarPage);
        }

        private void ExecuteNavigateToAboutClubPage()
        {
            try
            {
                _navigationService.NavigateAsync("AboutClubPage");
            }
            catch (Exception ex)
            {
                App.Current.MainPage.DisplayAlert("Error", ex.Message, "Ok");
            }
        }

        private void ExecuteNavigateToUnitListPage()
        {
            try
            {
                _navigationService.NavigateAsync("UnitListPage");
            }
            catch(Exception ex)
            {
                App.Current.MainPage.DisplayAlert("Error", ex.Message, "Ok");
            }            
        }

        private void ExecuteNavigateToSongListPage()
        {
            try
            {
                _navigationService.NavigateAsync("SongListPage");
            }
            catch(Exception ex)
            {
                App.Current.MainPage.DisplayAlert("Error", ex.Message, "Ok");
            }
        }

        private void ExecuteNavigateToDirectorsPage()
        {
            try
            {
                _navigationService.NavigateAsync("DirectorsPage");
            }
            catch (Exception ex)
            {
                App.Current.MainPage.DisplayAlert("Error", ex.Message, "Ok");
            }
        }

        private void ExecuteNavigateToCalendarPage()
        {
            try
            {
                _navigationService.NavigateAsync("CalendarPage");
            }
            catch (Exception ex)
            {
                App.Current.MainPage.DisplayAlert("Error", ex.Message, "Ok");
            }
        }
    }
}
