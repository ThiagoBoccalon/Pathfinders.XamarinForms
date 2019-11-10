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
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
        }

        private string _imageButtonAbout = "imagemButtonAboutMainPage.png";

        public string ImageButtonAbout
        {
            get { return _imageButtonAbout; }
        }
    }
}
