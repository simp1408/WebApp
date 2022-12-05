using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        
        //pulsante pronotazione
        protected void PrenotazioneSala(object sender, EventArgs e)
        {
            //dentro sala ci metto la scela dell'utente
            int sala = Convert.ToInt32(dropdownList.SelectedValue);

            if (sala == 1)
            {
                ArchivioPrenotazioni("SALA NORD");
            }
            else if (sala == 2)
            {
                ArchivioPrenotazioni("SALA SUD");
            }
            else if (sala == 3)
            {
                ArchivioPrenotazioni("SALA EST");
            }
            else
            {
                Console.WriteLine("seleziona sala");
                Console.ReadLine();
            }

        }


        public void ArchivioPrenotazioni(string SalaNome)
        {

            Prenotazione p = new Prenotazione();
            p.Nome = nome.Text;
            p.Cognome = cognome.Text;
            p.SalaCinema = SalaNome;

            Prenotazione._listaPrenotati.Add(p);
            BigliettiVenduti();

           
        }

        public void BigliettiVenduti()
        {
            int BigliettiVendutiSalaNord = 0;
            int BigliettiVendutiSalaSud = 0;
            int BigliettiVendutiSalaEst = 0;

            foreach(Prenotazione p in Prenotazione._listaPrenotati)
            {
                if(p.SalaCinema=="SALA NORD")
                {
                    BigliettiVendutiSalaNord += 1;
                }
               else if(p.SalaCinema=="SALA SUD")
                {
                    BigliettiVendutiSalaSud += 1;
                }
               else if(p.SalaCinema=="SALA EST")
                {
                    BigliettiVendutiSalaEst += 1;   
                }
                else if (p.SalaCinema==" ")
                       { Console.WriteLine("nessun biglietto");
                    Console.ReadLine();
                }

                bigiettiVendutiSalaNord.Text = Convert.ToString(BigliettiVendutiSalaNord);
                bigiettiVendutiSalaSud.Text = Convert.ToString(BigliettiVendutiSalaSud);
                bigiettiVendutiSalaEst.Text = Convert.ToString(BigliettiVendutiSalaEst);


            }
        }

        public class Prenotazione
        {
            private string _nome;

            public string Nome
            { get { return _nome; }
                set { _nome = value; } 
            }

            private string _cognome;

            public string Cognome { get { return _cognome; } set { _cognome = value; } }

            private string _salaCinema;

            public string SalaCinema { get { return _salaCinema; } set { _salaCinema = value; } }

            private static List<Prenotazione> ListaPrenotati = new List<Prenotazione>();

            public static List<Prenotazione> _listaPrenotati { 
                get { return ListaPrenotati; } set { ListaPrenotati = value; } 
            }






        }
    }
}