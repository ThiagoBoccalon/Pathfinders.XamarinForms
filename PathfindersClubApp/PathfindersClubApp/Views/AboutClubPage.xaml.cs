using Xamarin.Forms;

namespace PathfindersClubApp.Views
{
    public partial class AboutClubPage : ContentPage
    {
        public AboutClubPage()
        {
            InitializeComponent();
        }

        private void SetIntroduction()
        {
            aboutIntroductionOne.Text = string.Format("O Clube de Desbravadores Atalaia Internacional ",
                "nasceu em 14 de agosto de 1994, tendo como diretor e fundador ",
                "Alejandro Remo Diaz Gramund um chileno que veio com sua família ",
                "para o Brasil, e apenas 21 desbravadores iniciais. O textto ",
                "bíblico que deu nome ao clube se encontra em Ezequiel 33:6.");

            aboutIntroductionTwo.Text = string.Format("O Clube teve o nome Internacional incorporado ",
                "a seu nome devido a outros Clubes Atalaia que foram fundados ",
                "por parentes do fundador em outros países da América do Sul. ");
        }
    }
}
