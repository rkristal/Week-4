using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10
            //kasutaja peab seda numbrit ara arvama
            //kui kasutaja suutis numbrit ara arvata siis ta on mangu voitnud
            // kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ara arvata siis mangu voidab arvuti
            //programm genereerib juhuslikku numbrit uhe korra

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;
            bool loopActive = true;

            while (i < 3) 
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
                    Console.WriteLine($"Vale number, proovi uuesti {3 - i} katset jaanud!");
                   
                }

                 
            }


            Console.WriteLine($"Arvatav number oli {cpuNumber}");
            Console.WriteLine("Kena paeva!");
        }
    }
}

