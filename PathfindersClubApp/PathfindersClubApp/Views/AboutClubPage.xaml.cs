using PathfindersClubApp.Models;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PathfindersClubApp.Views
{
    public partial class AboutClubPage : ContentPage
    {
        public AboutClubPage()
        {
            InitializeComponent();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromRgb(92, 174, 66);
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.White;

            SetIntroduction();
            SetCamporis();
        }

        private void SetIntroduction()
        {
            aboutIntroductionOne.Text = "O Clube de Desbravadores Atalaia Internacional " +
                "nasceu em 14 de agosto de 1994, tendo como diretor e fundador " +
                "Alejandro Remo Diaz Gramund um chileno que veio com sua família " +
                "para o Brasil, e apenas 21 desbravadores iniciais. O textto " +
                "bíblico que deu nome ao clube se encontra em Ezequiel 33:6.";

            aboutIntroductionTwo.Text = "O Clube teve o nome Internacional incorporado " +
                "a seu nome devido a outros Clubes Atalaia que foram fundados " +
                "por parentes do fundador em outros países da América do Sul. ";
        }

        private void SetCamporis()
        {
            CadastroCampori cadastroCampori = new CadastroCampori();
            List<Campori> camporis = cadastroCampori.GetCamporis();
            
            var labelTitle = new Style(typeof(Label))
            {
                
                Setters =
                {
                    new Setter {Property = Label.FontSizeProperty, Value = 16},
                    new Setter{Property = Label.FontFamilyProperty, Value = "{StaticResource Caramelia}"},
                    new Setter{Property = Label.FontAttributesProperty, Value = FontAttributes.None},
                    new Setter{Property = Label.HorizontalTextAlignmentProperty, Value = LayoutAlignment.Center},
                    new Setter{Property = Label.HorizontalOptionsProperty, Value = LayoutOptions.Center}
                }
            };
            
            foreach(Campori campori in camporis)
            {
                stackCamporis.Children.Add(new Label { Text = campori.Year, FontSize = 24, 
                                                        FontAttributes = FontAttributes.Bold, 
                                                        Style = labelTitle });

                stackCamporis.Children.Add(new Label { Text = campori.Name, Style = labelTitle });
                stackCamporis.Children.Add(new Label { Text = campori.Local, Style = labelTitle });
                stackCamporis.Children.Add(new Label { Text = campori.Responsability, Style = labelTitle });
            }            
        }
    }
}
