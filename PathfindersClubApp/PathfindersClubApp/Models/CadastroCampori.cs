using System;
using System.Collections.Generic;
using System.Text;

namespace PathfindersClubApp.Models
{
    public class CadastroCampori
    {
        private string _responsabilityANP = "Associação Norte Paranaense";
        private string _resposabilityUSB = "União Sul Brasileira";
        private string _responsabilityDSA = "Divisão Sul Americana";

        private List<Campori> camporis = new List<Campori>();

        private void SetCamporisYearsNinety()
        {
            camporis.Add(new Campori { Year = "1994", 
                Name = "Revivendo a esperança dos Pioneiros", 
                Local = "Goioerê/PR", 
                Responsability = _responsabilityANP }
            );

            camporis.Add(new Campori
            {
                Year = "1995",
                Name = "Jesus e eu: que Amizade",
                Local = "São José/SC",
                Responsability = _resposabilityUSB
            });

            camporis.Add(new Campori
            {
                Year = "1996",
                Name = "Jesus o Melhor Amigo",
                Local = "Mamborê/PR",
                Responsability = _responsabilityANP
            });

            camporis.Add(new Campori
            {
                Year = "1997",
                Name = "ANP Cristo + Desbravador uma Amizade Que Dá Certo",
                Local = "Maringá/PR",
                Responsability = _responsabilityANP
            });

            camporis.Add(new Campori
            {
                Year = "1998",
                Name = "Em La Direccion de Dios",
                Local = "Pucón/Chile",
                Responsability = _responsabilityDSA
            });

            camporis.Add(new Campori
            {
                Year = "1998",
                Name = "Escolhidos para Brilhar",
                Local = "Esteio/RS",
                Responsability = _resposabilityUSB
            });

            camporis.Add(new Campori
            {
                Year = "1999",
                Name = "Rumo ao Porto Seguro",
                Local = "Guaíra/PR",
                Responsability = _responsabilityANP
            });
        }

        private void SetCamporisYearsTwoThousand()
        {
            camporis.Add(new Campori
            {
                Year = "2000",
                Name = "É Tempo de ver Jesus",
                Local = "Paranavaí/PR",
                Responsability = _responsabilityANP
            });

            camporis.Add(new Campori
            {
                Year = "2001",
                Name = "Fazendo Bonito na Trilha do Mestre",
                Local = "Foz do Iguaçu/PR",
                Responsability = _responsabilityANP
            });

            camporis.Add(new Campori
            {
                Year = "2002",
                Name = "Pontes de Amizade, Solidariedade e Esperança",
                Local = "Foz do Iguaçu/PR",
                Responsability = _resposabilityUSB
            });

            camporis.Add(new Campori
            {
                Year = "2003",
                Name = "Abrindo Caminhos",
                Local = "Umuarama/PR",
                Responsability = _responsabilityANP
            });

            camporis.Add(new Campori
            {
                Year = "2005",
                Name = "Fonte de Esperança",
                Local = "Santa Helena/PR",
                Responsability = _resposabilityUSB
            });

            camporis.Add(new Campori
            {
                Year = "2005",
                Name = "Sonho sem Fim",
                Local = "Campo Mourão/PR",
                Responsability = _responsabilityANP
            });

            camporis.Add(new Campori
            {
                Year = "2006",
                Name = "Jesus me escolheu Primeiro",
                Local = "Campo Mourão/PR",
                Responsability = _responsabilityANP
            });

            camporis.Add(new Campori
            {
                Year = "2006",
                Name = "Campori de Líderes",
                Local = "Porto Belo/SC",
                Responsability = _resposabilityUSB
            });

            camporis.Add(new Campori
            {
                Year = "2007",
                Name = "Paraná Total, A Glória Verdadeira",
                Local = "Ponta Grossa/PR",
                Responsability = _responsabilityANP
            });

            camporis.Add(new Campori
            {
                Year = "2008",
                Name = "Campuni, Pioneiros em União",
                Local = "Mandaguaçu/PR",
                Responsability = _responsabilityANP
            });

            camporis.Add(new Campori
            {
                Year = "2010",
                Name = "Esperança pra Brilhar com Poder",
                Local = "Santa Helena/PR",
                Responsability = _resposabilityUSB
            });

            camporis.Add(new Campori
            {
                Year = "2010",
                Name = "Coragem para Vencer",
                Local = "Jandaia do Sul/PR",
                Responsability = _responsabilityANP
            });

            camporis.Add(new Campori
            {
                Year = "2010",
                Name = "Decisões Radicais",
                Local = "Campo Mourão/PR",
                Responsability = _responsabilityANP
            });
        }

        private void SetCamporisOthers()
        {
            camporis.Add(new Campori
            {
                Year = "2012",
                Name = "Conquistando o Impossível",
                Local = "Maringá/PR",
                Responsability = _responsabilityANP
            });

            camporis.Add(new Campori
            {
                Year = "2014",
                Name = "Cristo por todos, todos por Cristo",
                Local = "Maringá/PR",
                Responsability = _responsabilityANP
            });

            camporis.Add(new Campori
            {
                Year = "2015",
                Name = "Coração de Rei",
                Local = "Santa Helena/PR",
                Responsability = _resposabilityUSB
            });

            camporis.Add(new Campori
            {
                Year = "2016",
                Name = "Escolhidos",
                Local = "Londrina/PR",
                Responsability = _responsabilityANP
            });

            camporis.Add(new Campori
            {
                Year = "2019",
                Name = "A Melhor Aventura",
                Local = "Barretos/SP",
                Responsability = _responsabilityDSA
            });
        }

        public CadastroCampori()
        {
            SetCamporisYearsNinety();
            SetCamporisYearsTwoThousand();
            SetCamporisOthers();
        }
        public List<Campori> GetCamporis()
        {
            return camporis;
        }
    }
}
