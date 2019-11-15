using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PathfindersClubApp.Models
{
    public class Campori
    {
        private Dictionary<int, string> camporis = new Dictionary<int, string>();
        private void InitializationCamporiYearsNinety()
        {
            camporis.Add(1994, "A");
            camporis.Add(1995, "B");
            camporis.Add(1996, "C");
            camporis.Add(1997, "D");
            camporis.Add(1998, "E");
            camporis.Add(1999, "F");
        }

        private void InitializationCamporiYearsTwoThousand()
        {
            camporis.Add(2000, "G");
            camporis.Add(2001, "F");
            camporis.Add(2002, "H");
            camporis.Add(2003, "I");
            camporis.Add(2004, "J");
            camporis.Add(2005, "K");
            camporis.Add(2006, "L");
            camporis.Add(2007, "M");
            camporis.Add(2008, "N");
            camporis.Add(2010, "O");
        }

        private void InitializationCamporiAfterYearsTwoThousand()
        {
            camporis.Add(2011, "P");
            camporis.Add(2012, "Q");
            camporis.Add(2013, "R");
            camporis.Add(2014, "S");
            camporis.Add(2015, "T");
            camporis.Add(2016, "U");
            camporis.Add(2017, "V");
            camporis.Add(2018, "W");
            camporis.Add(2019, "X");
        }

        public void SetIntroductionsAbout(ref Label aboutIntroductionOne, ref Label aboutIntroductionTwo)
        {
            aboutIntroductionOne.Text = "O Clube de Desbravadores Atalaia Internacional " +
                "nasceu em 14 de agosto de 1994, tendo como diretor e fundador " +
                "Alejandro Remo Diaz Gramund um chileno que veio com sua família " +
                "para o Brasil, o clube teve sua primeira reunião com apenas 21 desbravadores iniciais.";

            aboutIntroductionTwo.Text = "O Clube teve o nome Internacional incorporado " +
                "a seu nome devido a outros Clubes Atalaia que foram fundados " +
                "por parentes do fundador em outros países da América do Sul. ";
            
        }

        public void SetCamporis(ref Label camporisAboutText)
        {
           foreach(KeyValuePair<int, string> campori in camporis)
            {
                string line = "\n";
                camporisAboutText.Text = string.Format(campori.Key.ToString(), line, 
                    campori.Value, line);
            }
        }
    }
}
