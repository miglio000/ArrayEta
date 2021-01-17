using System;

namespace LibreriaArray_Eta
{
    public class GestionArray
    {
        public static int Dimensione()
        {
            int dimensione;
            Console.WriteLine($"Inserisci quanti interi vuoi inserire in un array: ");
            dimensione = Convert.ToInt32(Console.ReadLine());
            return dimensione;
        }
        public static void LeggiArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Inserisci età {i+1}° persona: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void StampaArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Il {i+1}° elemento è: {array[i]}.");
            }
        }
        public static bool RicercaArray(int[] array, int vero)
        {
            bool trova = false;
            for (int i = 0; i < array.Length && !trova; i++)
            {
                if (array[i] == vero)
                {
                    trova = true;
                }
            }
            return trova;
        }
        public static void MinMaxArray(int[] array)
        {
            int min = 0, max = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    min = array[i];
                    max = array[i];
                }
                if(array[i] > max)
                {
                    max = array[i];
                    min = array[i];
                }
                if(array[i] < min)
                {
                    min = array[i];
                    max = array[i];
                }
            }
            Console.WriteLine($"Il minimo inserito è: {min}, il massimo è: {max}.");
        }
    }
}
