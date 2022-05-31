using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegnvejrsstatistikProjekt
{
    class Menu
    {
        public static void RegnMenu(double[] måleværdier)
        {
            bool exit = false;
            do
            {
                Console.Clear();
                Console.CursorVisible = false;
                Console.WriteLine("1. Tabel\n2. Gennemsnit\n3. Max-værdi\n4. Min-værdi\n5. Exit\n");
                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        // Udskriver alle måleværdier i en tabel
                        Console.Clear();
                        for (int i = 0; i < måleværdier.Length; i++)
                        {
                            Console.WriteLine($"- \tMåleværdi {i + 1} = {måleværdier[i]} mm");
                        }
                        Console.ReadKey();
                        break;
                    case '2':
                        // Udskriver gennemsnittet i listen
                        Console.Clear();
                        Console.WriteLine($"Gennemsnit: {måleværdier.Average()}");
                        Console.ReadKey();
                        break;
                    case '3':
                        // Udskriver max-værdien i listen
                        Console.Clear();
                        Console.WriteLine($"Max-værdi: {måleværdier.Max()}");
                        Console.ReadKey();
                        break;
                    case '4':
                        // Udskriver min-værdien i listen
                        Console.Clear();
                        Console.WriteLine($"Min-værdi: {måleværdier.Min()}");
                        Console.ReadKey();
                        break;
                    case '5':
                        // Afslutter programmet
                        Console.Clear();
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Ugyldig værdi");
                        break;
                }
            } 
            while (!exit);
        }
    }
}
