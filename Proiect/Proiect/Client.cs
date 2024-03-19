using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    internal class Client
    {
   
        public int Idclient {  get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public double Nrtel { get; set; }
        public string Adresa { get; set; }
        public Client()
        {
            Nume= string.Empty;
            Prenume= string.Empty;
            Adresa= string.Empty;
            Nrtel= 0;
        }
        public Client(int Idclient, string nume, string prenume)
        {
            this.Idclient = Idclient;
            this.Nume = nume;
            this.Prenume = prenume;
        }
        public Client(int Idclient,string nume, string prenume, string adresa, double nrTel)
        {
            this.Idclient = Idclient;
            this.Nume = nume;
            this.Prenume = prenume;
            this.Adresa = adresa;
            this.Nrtel = nrTel;
        }
        public string Info()
        {
            string info = $"Id:{Idclient} Nume:{Nume ?? " NECUNOSCUT "} Prenume: {Prenume ?? " NECUNOSCUT "}";

            return info;
        }

    }
}
