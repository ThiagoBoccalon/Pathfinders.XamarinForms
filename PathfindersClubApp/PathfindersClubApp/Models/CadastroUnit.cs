using System;
using System.Collections.Generic;
using System.Text;

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
                Conselheiro = new Conselheiro() { Name = "Débora Mascarenhas", Image = ""}
            });

            Units.Add(new Unit
            {
                Name = "Cangurus",
                Image = "unit_bandeira_NewZealand",
                Conselheiro = new Conselheiro() { Name = "Sarah Engler", Image = "" }
            });

            Units.Add(new Unit
            {
                Name = "Falcões",
                Image = "unit_bandeira_Italy",
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
