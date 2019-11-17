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
        CadastroUnit cadastroUnit = new CadastroUnit();
        public List<Unit> Units
        {
            get
            {
                return cadastroUnit.Units;
            }            
        }
        private INavigationService _navigationService;

        public Unit _selectedUnit { get; set; }
        public Unit SelectedUnit
        {
            get
            {
                return _selectedUnit;
            }
            set
            {
                _selectedUnit = value;
                SelectedUnitPage();
            }
        }

        private void SelectedUnitPage()
        {
            var navigationParams = new NavigationParameters();
            navigationParams.Add("unidadeSelected", _selectedUnit);
            _navigationService.NavigateAsync("AllUnitsPage", navigationParams);
        }
        
        public UnitListPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;            
        }             
    }
}
