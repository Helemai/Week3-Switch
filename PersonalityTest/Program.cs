using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada tema lemmikvärv;
            //kui kasutaja sisestab "punane", konsool kuvsb "oled romantiline";
            //kui kasutaja sisestab "sinine", konsool kuvadb "oled töökas";
            //kui kasutaja sisestab "roheline", konsool kuvab "oled looduse sõber";
            //kui kasutaja sisestab midagi muud, konsool kuvab "oled {usercolor} ükssarvik";

            Console.WriteLine("Sisesta oma lemmikvärv");
            string userColor = Console.ReadLine();

            if(userColor =="punane")
            {
                Console.WriteLine("Oled romantiline.");
            }

            else if(userColor == "sinine")
            {
                Console.WriteLine("oled töökas.");
            }

            else if(userColor == "roheline")
            {
                Console.WriteLine("oled looduse sõber.");
            }
            else
            {
                Console.WriteLine($"Oled {userColor} ükssarvik.");
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
