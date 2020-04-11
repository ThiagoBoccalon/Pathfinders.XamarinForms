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
                Name = "Estou Cantando Alegre",
                Page = "EstouCantandoAlegre"
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

            songs.Add(new Song
            {
                Name = "Não Desanimamos",
                Page = "NaoDesanimamos"
            });

            songs.Add(new Song
            {
                Name = "Não Mais Eu",
                Page = "NaoMaisEu"
            });

            songs.Add(new Song
            {
                Name = "O Homem da Galileia",
                Page = "OhomemQueAndavaEmGalileia"
            });

            songs.Add(new Song
            {
                Name = "Quero Acordar Cantando",
                Page = "QueroAcordarCantando"
            });

            songs.Add(new Song
            {
                Name = "Sinto",
                Page = "Sinto"
            });

            songs.Add(new Song
            {
                Name = "Vou Caminhando",
                Page = "VouCaminhando"
            });
        }
    }
}
