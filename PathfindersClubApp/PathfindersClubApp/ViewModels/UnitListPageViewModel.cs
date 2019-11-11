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
        public List<Unit> units { get; private set; } = new List<Unit>();
        private INavigationService _navigationService;

        public Unit _selectedUnits { get; set; }
        public Unit SelectedUnits
        {
            get
            {
                return _selectedUnits;
            }
            set
            {
                _selectedUnits = value;
                HandleSelectedItem();
            }
        }

        private void HandleSelectedItem()
        {
            _navigationService.NavigateAsync(SelectedUnits.Page);
        }
        public UnitListPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            SetUnits();
        }

        private void SetUnits()
        {
            units.Add(new Unit
            {
                Name = "Águias",
                Image = "",
                Page = ""
            });

            units.Add(new Unit
            {
                Name = "Cangurus",
                Image = "",
                Page = ""
            });

            units.Add(new Unit
            {
                Name = "Falcões",
                Image = "",
                Page = ""
            });

            units.Add(new Unit
            {
                Name = "Pumas",
                Image = "",
                Page = ""
            });

            units.Add(new Unit
            {
                Name = "Tigres",
                Image = "",
                Page = ""
            });

            units.Add(new Unit
            {
                Name = "Tucanos",
                Image = "",
                Page = ""
            });
        }
    }
}
