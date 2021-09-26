using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbri 1 kuni 10-ni
            // kui genereeritud number on 5, programm lopetab oma too ja soovib kasutajale "kena paeva"
            //kui genereeritud number on midagi muud siis programm jatkab oma tood


            Random rnd = new Random();

            //int myRandomNumber = rnd.Next(1, 11);

            int i = 0;
            while (i != 5)

            {
                int myRandomNumber = rnd.Next(1, 11);
                Console.WriteLine($"Juhuslik number on {myRandomNumber}");
                if (myRandomNumber == 5)
                {
                    i = myRandomNumber;
                }

            }




            Console.WriteLine("Kena paeva!");



            //Console.WriteLine($"Juhuslik number on {myRandomNumber}");


        }
    }
}