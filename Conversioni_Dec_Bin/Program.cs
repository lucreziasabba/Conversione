using System;

namespace DecToBin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il numero da convertire: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Seleziona in che sistema lo vuoi convertire: 2,8,16");
            string selezione = (Console.ReadLine());
            try
            {
                if (selezione == "2")
                {
                    Console.WriteLine(Convert.ToString(n, 2));
                }
                else if (selezione == "8")
                {
                    Console.WriteLine(Convert.ToString(n, 8));
                }
                else if (selezione == "16")
                {
                    Console.WriteLine(Convert.ToString(n, 16));
                }


            }
            catch (Exception e)
            {

            }

            Console.ReadLine();


        }
    }
}
