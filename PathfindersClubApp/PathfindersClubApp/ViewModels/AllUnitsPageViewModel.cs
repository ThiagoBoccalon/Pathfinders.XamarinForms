using PathfindersClubApp.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace PathfindersClubApp.ViewModels
{
    public class AllUnitsPageViewModel : BindableBase, INavigationAware
    {        
        public AllUnitsPageViewModel()
        {
            
        }

        private string _titleNameUnit;
        public string TitleNameUnit
        {
            get
            {
                return _titleNameUnit;
            }
            private set
            {
                _titleNameUnit = value;
                OnPropertyChanged();
            }
        }

        private string _imageBandeiraUnidade;
        
        public string ImageBandeiraUnidade
        {
            get
            {
                return _imageBandeiraUnidade;
            }
            private set
            {
                _imageBandeiraUnidade = value;
                OnPropertyChanged();
            }
        }

        private string _nomeConselheiro;

        public string NomeConselheiro
        {
            get
            {
                return _nomeConselheiro;
            }
            private set
            {
                _nomeConselheiro = value;
                OnPropertyChanged();
            }
        }

        private string _imageConselheiro;
        public string ImageConselheiro
        {
            get
            {
                return _imageConselheiro;
            }
            set
            {
                _imageConselheiro = value;
                OnPropertyChanged();
            }
        }

        private StackLayout _anthemUnity;
        public StackLayout AnthemUnity
        {
            get
            {
                return _anthemUnity;
            }
            set
            {
                _anthemUnity = value;
                OnPropertyChanged();
            }
        }

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
            AnthemUnity = unidade.AnthemUnity;
        }
    }
}
