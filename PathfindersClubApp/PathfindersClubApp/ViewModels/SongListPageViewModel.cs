using PathfindersClubApp.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PathfindersClubApp.ViewModels
{
    public class SongListPageViewModel : BindableBase
    {
        private INavigationService _navigationService;
        public List<Song> Songs { get; private set; }

        private Song _selectedSong { get; set; }
        public Song SelectedSong
        {
            get
            {
                return _selectedSong;
            }
            set
            {
                _selectedSong = value;
                HandleSelectedItem();
            }
        }

        private void HandleSelectedItem()
        {
            _navigationService.NavigateAsync(SelectedSong.Page);
        }

        public SongListPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            CadastroSong cadastroSong = new CadastroSong();
            Songs = cadastroSong.Songs;
        }
    }
}
