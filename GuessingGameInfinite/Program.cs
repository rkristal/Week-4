using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10
            //kasutaja peab seda numbrit ara arvama
            //kui kasutaja suutis numbrit ara arvata siis ta on mangu voitnud
            // katsete arv on piiramatu
            //programm genereerib juhuslikku numbrit uhe korra
            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;
            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Sisesta arvatav number");
                int usernumber = Convert.ToInt32(Console.ReadLine());

                if (usernumber == cpuNumber)
                {
                    Console.WriteLine("Oled voitnud!");

                    break;
                }
                else
                {

                    i++;
                    Console.WriteLine($"Vale number, proovi uuesti");

                }


            }


            Console.WriteLine($"Arvatav number oli {cpuNumber}");
            Console.WriteLine("Kena paeva!");
        }
    }
}
