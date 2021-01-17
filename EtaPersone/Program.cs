using System;
using LibreriaArray_Eta;
namespace EtaPersone
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensione = GestionArray.Dimensione();
            int[] età = new int[dimensione];
            GestionArray.LeggiArray(età);

            Console.WriteLine("Metti un'età da ricercare: ");
            int ricerca_età = Convert.ToInt32(Console.ReadLine());

            bool esito = GestionArray.RicercaArray(età, ricerca_età);

            if(esito == true)
            {
                Console.WriteLine("Età trovata tra quelle inserite.");
                GestionArray.StampaArray(età);
            }
            else
            {
                Console.WriteLine("Età non trovata tra quelle inserite.");
            }
            GestionArray.MinMaxArray(età);
        }
    }
}
