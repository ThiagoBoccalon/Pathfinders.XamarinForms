using PathfindersClubApp.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PathfindersClubApp.ViewModels
{
    public class AllUnitsPageViewModel : BindableBase, INavigationAware
    {        
        public AllUnitsPageViewModel()
        {
            
        }

        public string TitleNameUnit { get; private set; }        

        public string ImageBandeiraUnidade { get; private set; }

        public string NomeConselheiro { get; private set; }

        public string ImageConselheiro { get; private set; }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            var unidade = parameters["unidadeSelected"] as Unit;
            TitleNameUnit = unidade.Name;
            ImageBandeiraUnidade = unidade.Image;
            NomeConselheiro = unidade.Conselheiro.Name;
            ImageConselheiro = unidade.Conselheiro.Image;
        }
    }
}
