using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    internal class StocareDate
    {
        private const int NR_MAX_CLIENTI = 50;

        private Client[] clienti;
        private int nrClienti;

        public StocareDate()
        {
            clienti = new Client[NR_MAX_CLIENTI];
            nrClienti = 0;
        }

        public void AddClient(Client client)
        {
            clienti[nrClienti] = client;
            nrClienti++;
        }

        public Client[] GetClienti(out int nrClienti)
        {
            nrClienti = this.nrClienti;
            return clienti;
        }
    }
}
