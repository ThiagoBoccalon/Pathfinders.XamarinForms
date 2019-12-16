using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PathfindersClubApp.Models
{
    public class CadastroUnit
    {
        private List<Unit> units = new List<Unit>();

        public CadastroUnit()
        {
            SetUnits();
        }

        public List<Unit> Units
        {
            get { return units; }
            private set { units = value; }
        }     

        private void SetUnits()
        {
            Units.Add(new Unit
            {
                Name = "Águias",
                Image = "unit_bandeira_USA",
                Page = "AguiasUnitPage"
            });

            Units.Add(new Unit
            {
                Name = "Cangurus",
                Image = "unit_bandeira_NewZealand",
                Page = "CangurusUnitPage"
            });

            Units.Add(new Unit
            {
                Name = "Falcões",
                Image = "unit_bandeira_Italy",
                Page = "FalcoesUnitPage"
            });

            Units.Add(new Unit
            {
                Name = "Pumas",
                Image = "unit_bandeira_Chile",
                Page = "PumasUnitPage"
            });

            Units.Add(new Unit
            {
                Name = "Tucanos",
                Image = "unit_bandeira_Brazil",
                Page = "TucanosUnitPage"
            });
        }
    }
}
