using PathfindersClubApp.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PathfindersClubApp.ViewModels
{
    public class UnitListPageViewModel : BindableBase
    {
        private INavigationService _navigationService;

        public List<Unit> Units { get; private set; } = new List<Unit>();
        private Unit _selectedUnit { get; set; }
        public Unit SelectedUnit
        {
            get
            {
                return _selectedUnit;
            }
            set
            {
                _selectedUnit = value;
                HandleSelectedItem();
            }
        }

        private void HandleSelectedItem()
        {
            _navigationService.NavigateAsync(SelectedUnit.Page);
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public UnitListPageViewModel(INavigationService navigationService)
        {            
            _navigationService = navigationService;
            CadastroUnit cadastroUnit = new CadastroUnit();
            Units = cadastroUnit.Units;            
        }
    }
}
