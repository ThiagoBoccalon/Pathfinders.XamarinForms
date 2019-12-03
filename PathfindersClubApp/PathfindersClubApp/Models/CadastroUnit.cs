using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PathfindersClubApp.Models
{
    public class CadastroUnit
    {
        private List<Unit> _units = new List<Unit>();
        private List<Label> anthems = new List<Label>();
        
        Style anthemsStyle = new Style(typeof(Label))
        {
            Setters =
                {
                    new Setter {Property = Label.FontFamilyProperty, Value = "Arial"},
                    new Setter {Property = Label.HorizontalOptionsProperty, Value = "CenterAndExpand"},
                    new Setter {Property = Label.TextColorProperty, Value = "Black"},
                    new Setter {Property = Label.FontSizeProperty, Value = 18}
                }
        };

        Style anthemsWithBoldStyle = new Style(typeof(Label))
        {
            Setters =
                {
                    new Setter {Property = Label.FontFamilyProperty, Value = "Arial"},
                    new Setter {Property = Label.HorizontalOptionsProperty, Value = "CenterAndExpand"},
                    new Setter {Property = Label.TextColorProperty, Value = "Black"},
                    new Setter {Property = Label.FontSizeProperty, Value = 18},
                    new Setter {Property = Label.FontAttributesProperty, Value = FontAttributes.Bold}
                }
        };

        public List<Unit> Units
        {
            get { return _units; }
            private set { _units = value; }
        }
        public CadastroUnit()
        {
            SetUnits();
        }

        private StackLayout AnthemUnityAguia()
        {    
            anthems.Add(new Label { Text = "Unidade Águais como é que é?", Style = anthemsWithBoldStyle });
            anthems.Add(new Label
            {
                Text = "Força, garra e determinação, coragem e ousadia pra cumprir nossa missão, " +
                "com Cristo no comando iremos te mostrar que Ele salva vidas pelo nosso expressar. " +
                "Nosso lema amor e união nosso objetivo é alcançar a salvação. Unidades Águias.",
                Style = anthemsStyle
            });

            return InsertLabelsInStacklayout();
        }

        private StackLayout AnthemUnitCanguru()
        {
            anthems.Add(new Label
            {
                Text = "1, 2, 3, 4 para 5 falta 1 unidade Canguru não dá mole pra nenhum, " +
                "pode vir gritando e berrando sem parar unidade Canguru que chegou para abalar! " +
                "É os cancan guru guru guru.",
                Style = anthemsStyle
            });

            return InsertLabelsInStacklayout();
        }

        private StackLayout InsertLabelsInStacklayout()
        {
            StackLayout stackLayout = new StackLayout();

            foreach (Label label in anthems)
                stackLayout.Children.Add(label);

            anthems.Clear();
            return stackLayout;
        }

        private void SetUnits()
        {            
            Units.Add(new Unit
            {
                Name = "Águias",
                Image = "unit_bandeira_USA",
                BackgroundColor = "#3f5f90",
                AnthemUnity = AnthemUnityAguia(),
                Conselheiro = new Conselheiro() { Name = "Débora Mascarenhas", Image = "conselheira_aguias" }
            });

            Units.Add(new Unit
            {
                Name = "Cangurus",
                Image = "unit_bandeira_NewZealand",
                BackgroundColor = "#0055a8",
                AnthemUnity = AnthemUnitCanguru(),
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
