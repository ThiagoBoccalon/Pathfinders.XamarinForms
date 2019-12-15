
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Navigation.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace PathfindersClubApp.ViewModels.Units
{
    public class FalcoesUnitPageViewModel : BindableBase
    {
        private INavigationService _navigationService;
        public FalcoesUnitPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
