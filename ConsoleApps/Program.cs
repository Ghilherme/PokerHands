using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApps
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the cards from the players' hands:");
                string str = Console.ReadLine();
            
                Player black = new Player(str.Substring(0, 14));
                Player white = new Player(str.Substring(15));
                switch (black.compareTo(white))
                {
                    case 1:
                        Console.WriteLine("Black wins.");
                        break;
                    case -1:
                        Console.Write("White wins.");
                        break;
                    case 0:
                        Console.WriteLine("Tie.");
                        break;
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occurred: \n {ex}");
                Console.ReadLine();
            }
            
        }
    }
}
