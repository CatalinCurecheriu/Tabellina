using System;

namespace Tabellina
{
    class Program
    {
        static void Main(string[] args)
        {
            int moltiplicatore = 1, i = 0;
            int risultato;
            Console.WriteLine("Inserisci un numero e ti stamperò la tabellina relativa");
            int n_inserito = Convert.ToInt32(Console.ReadLine());


            while (i <= 10)
            {
                risultato = n_inserito * i;
                Console.WriteLine($"{n_inserito} x {i} =" + risultato);
                i++;
            }
            i = 0;
            Console.WriteLine();

            //************************************************************************************

            do
            {
               risultato = n_inserito * i;
                Console.WriteLine($"{n_inserito} x {i} =" + risultato);
                i++;              
            } while (i <= 10);
            Console.WriteLine();

            //*****************************************************************************

            for (i = 0; i <= 10; i++)
            {
                risultato = n_inserito * i;
                Console.WriteLine($"{n_inserito} x {i} =" + risultato);
                
            }
            Console.WriteLine();
            Console.ReadKey();





        }
    }
}
