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

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            _navigationService = navigationService;
            NavigateToAboutPageCommand = new DelegateCommand(ExecuteNavigateToAboutPageCommand);
        }

        private string _imageButtonAbout = "imagemButtonAboutMainPage.png";

        public DelegateCommand NavigateToAboutPageCommand { get; set; }

        public string ImageButtonAbout
        {
            get { return _imageButtonAbout; }
        }

        private void ExecuteNavigateToAboutPageCommand()
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
    }
}
