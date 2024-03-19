using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            StocareDate adminClienti = new StocareDate();
            int nrClienti = 0;
            Client clientNou = new Client();
            
            string optiune;
            do
            {
                Console.WriteLine("C. Citire informatii student de la tastatura");
                Console.WriteLine("I. Afisarea informatiilor despre ultimului student introdus");
                Console.WriteLine("A. Afisare studenti din fisier");
                Console.WriteLine("S. Salvare student in vector de obiecte");
                Console.WriteLine("Z. Cautare dupa nume");
                Console.WriteLine("X. Inchidere program");

                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine();

                switch (optiune.ToUpper())
                {
                    case "C":
                        clientNou = CitireClientTastatura();

                        break;
                    case "I":
                        AfisareClient(clientNou);

                        break;
                    case "A":
                        Client[] clienti = adminClienti.GetClienti(out nrClienti);
                        AfisareClienti(clienti, nrClienti);

                        break;
                    case "S":
                        int idClient = nrClienti + 1;
                        clientNou.Idclient = idClient;
                        //adaugare student in vectorul de obiecte
                        adminClienti.AddClient(clientNou);

                        break;
                    case "Z":
                        Client[] cauta = adminClienti.GetClienti(out nrClienti);
                        CautareDupaNume(cauta, nrClienti);
                        break;
                    case "X":
                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;
                }
            } while (optiune.ToUpper() != "X");

            
            Console.ReadKey();
        }
        public static Client CitireClientTastatura()
            {
                Console.WriteLine("Introduceti numele");
                string nume = Console.ReadLine();

                Console.WriteLine("Introduceti prenumele");
                string prenume = Console.ReadLine();

                Client client = new Client(0, nume, prenume);

                return client;
            }
        public static void AfisareClient(Client client)
        {
            string infoClient = string.Format("Clientul cu id-ul #{0} are numele: {1} {2}",
                    client.Idclient,
                    client.Nume ?? " NECUNOSCUT ",
                    client.Prenume ?? " NECUNOSCUT ");

            Console.WriteLine(infoClient);
        }

        public static void AfisareClienti(Client[] clienti, int nrClienti)
        {
            Console.WriteLine("Clientii sunt:");
            for (int i = 0; i < nrClienti; i++)
            {
                string infoClient = clienti[i].Info();
                Console.WriteLine(infoClient);
            }
        }
        public static void CautareDupaNume(Client[] clienti, int nrClienti)
        {
            Console.WriteLine("Introdu numele clientului: ");
            string nume = Console.ReadLine();

            Console.WriteLine("Introduceti prenumele: ");
            string prenume = Console.ReadLine();
            for (int i = 0; i < nrClienti; i++)
            {
                if (nume == clienti[i].Nume && prenume== clienti[i].Prenume)
                {
                    Console.WriteLine("Am gasit clientl");
                    string infoClient = clienti[i].Info();
                    Console.WriteLine(infoClient);
                }
                else
                    Console.WriteLine("clientul nu exista");
                
            }
        }
    }
}
