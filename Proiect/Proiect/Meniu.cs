using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    internal class Meniu
    {
        string preparat;
        float pret;
        public string Preparat { get; set; }
        public float Pret { get; set; }
        public Meniu(string preparate, float pret)
        {
            this.Preparat = preparate;
            this.Pret = pret;
        }
        public Meniu() { 
            Preparat=string.Empty;
            Pret = 0;
        }
    }
}
