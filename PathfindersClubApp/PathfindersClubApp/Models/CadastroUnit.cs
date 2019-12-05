using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PathfindersClubApp.Models
{
    public class CadastroUnit
    {
        private List<Unit> _units = new List<Unit>();
        
        public List<Unit> Units
        {
            get { return _units; }
            private set { _units = value; }
        }
        public CadastroUnit()
        {
            SetUnits();
        }

        private void SetUnits()
        {
            Units.Add(new Unit
            {
                Name = "Águias",
                Image = "unit_bandeira_USA",
                BackgroundColor = "#3f5f90",
                Antherm = "Unidade Águais como é que é?"+
                "Força, garra e determinação, coragem e ousadia pra cumprir nossa missão, " +
                "com Cristo no comando iremos te mostrar que Ele salva vidas pelo nosso expressar. " +
                "Nosso lema amor e união nosso objetivo é alcançar a salvação. Unidades Águias.",
                Conselheiro = new Conselheiro() { Name = "Débora Mascarenhas", Image = "conselheira_aguias" }
            });

            Units.Add(new Unit
            {
                Name = "Cangurus",
                Image = "unit_bandeira_NewZealand",
                BackgroundColor = "#0055a8",                
                Conselheiro = new Conselheiro() { Name = "Sarah Engler", Image = "conselheira_aguias" }
            });

            Units.Add(new Unit
            {
                Name = "Falcões",
                Image = "unit_bandeira_Italy",
                BackgroundColor = "#5ebf70",                    
                Conselheiro = new Conselheiro() { Name = "Natan Almeida", Image = "" }
            });

            Units.Add(new Unit
            {
                Name = "Pumas",
                Image = "unit_bandeira_Chile",                
                Conselheiro = new Conselheiro() { Name = "Mirian Cristina", Image = "" }
            });

            Units.Add(new Unit
            {
                Name = "Tigres",
                Image = "unit_bandeira_Malasia",                
                Conselheiro = new Conselheiro() { Name = "Vinicius Queiroz", Image = "" }
            });

            Units.Add(new Unit
            {
                Name = "Tucanos",
                Image = "unit_bandeira_Brazil",                
                Conselheiro = new Conselheiro() { Name = "Leandro Esteca", Image = "" }
            });
        }
    }
}
