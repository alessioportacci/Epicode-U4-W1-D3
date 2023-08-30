using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epicode_U4_W1_D3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ES. 0
            Console.WriteLine("ES. 0 \n");

            CV curriculum = new CV("Alessio", "Portacci", "3494575250", "alessio.portacci.s@gmail.com");
            curriculum.addStudi("Diploma ITIS", "Istituto tecnico superiore Lattanzio", "Infomratica", "12/09/2011", "12/07/2017");
            curriculum.addStudi("Jr. FullStack Developer", "Epicode", "Corso di formazione", "28/05/2023");
            curriculum.addImpiego("", "FrontEnd Developer", "Piccoli siti per attivita' locali", "Gennaio 2019", "Gennaio 2021");
            curriculum.addImpiego("FullService Solution", "FullStack Developer", "Sviluppatore .net a contratto fulltime", "Novembre 2021", "Maggio 2023");
            curriculum.Impiego.Esperienze[1].addCompito("Sviluppatore FrondEnd");
            curriculum.Impiego.Esperienze[1].addCompito("Sviluppatore BackEnd");
            curriculum.Impiego.Esperienze[1].addCompito("Montaggio video");

            StampaCVSuSchermo(curriculum);

            #endregion

            #region ES. 1

            Console.WriteLine("ES. 1 \n");

            ContoCorrente conto = new ContoCorrente(10);
            Console.WriteLine(string.Concat("Il saldo e' di " + conto.getSaldo()));
            //Versamento
            Console.WriteLine("Scegli quanto versare");
            conto.versamento(Int32.Parse(Console.ReadLine()));
            Console.WriteLine(string.Concat("Il saldo e' di " + conto.getSaldo()));

            //Prelevamento
            Console.WriteLine("Scegli quanto prelevare");
            conto.prelevamento(Int32.Parse(Console.ReadLine()));
            Console.WriteLine(string.Concat("Il saldo e' di " + conto.getSaldo()));

            Console.WriteLine();

            #endregion

            #region ES. 2
            Console.WriteLine("ES 2 \n");
            bool uscito = false;
            string[] nomiArray = { "Alessio", "Simone", "Alessandro", "Yanina", "Giulia" };
            Console.Write("Inserisci un nome ");
            string nome = Console.ReadLine();

            foreach (string nomi in nomiArray) 
            {
                if(nome.Trim() == nomi)
                {
                    Console.WriteLine(String.Concat(nomi, " e' presente nell'array"));
                    uscito = true;
                }
            }

            if (!uscito)
                Console.WriteLine(string.Concat("Il nome ", nome, " non era presente nell'array"));

            Console.WriteLine();
            #endregion

            #region ES. 3
            Console.WriteLine("Es.3 \n");

            Console.WriteLine("Inserisci la lunghezza dell'array ");
            int arrayLength = Int32.Parse(Console.ReadLine());

            int[] intArray = new int[arrayLength];
            float somma = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(string.Concat("Inserisci il ", i +1, " numero"));
                int currentNumber = Int32.Parse(Console.ReadLine());

                intArray[i] = currentNumber;
                somma += currentNumber;
            }

            Console.WriteLine(string.Concat("La somma di tutti i numeri e' ", somma));
            Console.WriteLine(string.Concat("La media di tutti i numeri e'", somma / arrayLength));
            #endregion

            Console.ReadLine();

        }

        public static void StampaCVSuSchermo(CV curriculum)
        {
            //Info personali
            Console.WriteLine("++++ INIZIO Info personali ++++ \n");

            Console.WriteLine(string.Concat("Nome:     ", curriculum.Info.Nome));
            Console.WriteLine(string.Concat("Cognome:  ", curriculum.Info.Cognome));
            Console.WriteLine(string.Concat("Telefono: ", curriculum.Info.Telefono));
            Console.WriteLine(string.Concat("Email:    ", curriculum.Info.Email));
            
            Console.WriteLine("\n++++ FINE Info personali ++++ \n\n");

            //Studi
            Console.WriteLine("++++ INIZIO Studi e Formazione ++++ \n");
            
            foreach (Studi studio in curriculum.StudiList)
            {
                //Istituto
                Console.WriteLine(string.Concat("Istituto:  ", studio.Istituto));
                //Qualifica
                Console.WriteLine(string.Concat("Qualifica: ", studio.Qualifica));
                //Tipo
                Console.WriteLine(string.Concat("Tipo:      ", studio.Tipo));
                //Dal-Al
                Console.WriteLine(string.Concat("Dal ", studio.Dal, " al ", studio.Al, "\n"));
            }
            
            Console.WriteLine("\n++++ FINE Studi e Formazione ++++ \n\n");

            //Impieghi
            Console.WriteLine("++++ INIZIO Impieghi ++++ \n");

            foreach(Esperienza esperienza in curriculum.Impiego.Esperienze)
            {
                //Istituto
                Console.WriteLine(string.Concat("Azienda:     ", esperienza.Azienda));
                //Qualifica
                Console.WriteLine(string.Concat("Titolo:      ", esperienza.JobTitle));
                //Tipo
                Console.WriteLine(string.Concat("Descrizione: ", esperienza.Descrizione));
                //Compiti
                Console.Write("Compiti:     ");
                foreach(string compito in esperienza.Compiti)
                {
                    Console.Write(string.Concat(compito, ", "));
                }
                Console.Write("\n");
                //Dal-Al
                Console.WriteLine(string.Concat("Dal ", esperienza.Dal, " al ", esperienza.Al, "\n"));

            }

            Console.WriteLine("++++ FINE Impieghi ++++ \n\n");
        }

    }
}
