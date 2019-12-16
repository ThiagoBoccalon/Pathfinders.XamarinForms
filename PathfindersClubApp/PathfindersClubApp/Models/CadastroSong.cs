using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PathfindersClubApp.Models
{
    public class CadastroSong
    {
        private List<Song> songs = new List<Song>();
        public CadastroSong()
        {
            SetSongs();
        }

        public List<Song> Songs
        {
            get { return songs; }
            private set { songs = value; }
        }

        private void SetSongs()
        {
            songs.Add(new Song
            {
                Name = "Coração de Rei",
                Page = "CoracaoDeReiPage"
            });

            songs.Add(new Song
            {
                Name = "Eu sou Teu",
                Page = ""
            });

            songs.Add(new Song
            {
                Name = "Não Desanimamos",
                Page = ""
            });

            songs.Add(new Song
            {
                Name = "Hino Atalaia Internacional",
                Page = "HinoAtalaiaPage"
            });

            songs.Add(new Song
            {
                Name = "Hino dos Desbravadores",
                Page = "HinoDesbravadoresPage"
            });
        }
    }
}
