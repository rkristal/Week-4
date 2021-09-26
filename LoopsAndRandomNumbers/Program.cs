using System;

namespace LoopsAndRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada PIN-koodi;
            //programm vordleb sisestatud PIN-koodi arvuga 1234
            //kui sisestatud PIN-kood on 1234 siis konsool kuvab "Tere tulemast!
            //kasutajal on kolm katset. i < 3

            int i = 0; //i -iteration

            while (i < 3) //While-loop >> 
            {
                Console.WriteLine("Sisesta PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    //i = i + 1;
                    i++;
                    Console.WriteLine($"Vale PIN. {3 - i} katset on jaanud.");
                }
                
                
            }
            
            
      
            Console.WriteLine("Kena paeva!");
        }
    }
}
