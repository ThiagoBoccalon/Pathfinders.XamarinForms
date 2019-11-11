using System.Collections.Generic;
using Xamarin.Forms;

namespace PathfindersClubApp.Views
{
    public partial class AboutPage : ContentPage
    {
        private Dictionary<int, string> camporisParticipados = new Dictionary<int, string>();
        public AboutPage()
        {
            InitializeComponent();
            //InitializationCamporis();
            //InitializeTexts();
        }

        private void InitializationCamporis()
        {
            camporisParticipados.Add(1994, "");
            camporisParticipados.Add(1995, "");
            camporisParticipados.Add(1996, "");
            camporisParticipados.Add(1997, "");
            camporisParticipados.Add(1998, "");
            camporisParticipados.Add(1999, "");
        }

        private void InitializeTexts()
        {
            aboutTxtIntroductionOne.Text = "O Clube de Desbravadores Atalaia Internacional " +
                "nasceu em 14 de agosto de 1994, tendo como diretor e fundador " +
                "Alejandro Remo Diaz Gramund um chileno que veio com sua família " +
                "para o Brasil, o clube teve sua primeira reunião com apenas 21 desbravadores iniciais.";

            aboutTxtIntroductionTwo.Text = "O Clube teve o nome Internacional incorporado " +
                "a seu nome devido a outros Clubes Atalaia que foram fundados " +
                "por parentes do fundador em outros países da América do Sul. ";

            aboutTxtCamporis.Text = "";
        }
    }
}
