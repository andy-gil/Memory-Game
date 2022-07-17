using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            MemoryGame game = new MemoryGame();
            

            while (!game.Gameover)
            {
                displayRound(game);
                Colors colors;

                do
                {
                    Console.WriteLine("Enter color: ");
                    string colorAsString = Console.ReadLine();
                    colors = StringToColorConverter.Convert(colorAsString);

                }while (game.MakeGuess(colors));
            }
            Console.WriteLine();
            Console.WriteLine("Game Over");
            Console.WriteLine("Shutting down ..........");
            System.Threading.Thread.Sleep(4000);

        }
        private static void displayRound(MemoryGame game)
        {
            Console.Clear();
            foreach (Colors colors in game.Colors)
            {
                Console.WriteLine("Round " + game.Colors.Count + ": \n");
                System.Threading.Thread.Sleep(400);
                switch (colors)
                {
                    case Colors.red:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Colors.blue:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case Colors.green:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Colors.yellow:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    //case Colors.purple:
                    //    Console.ForegroundColor = ConsoleColor.Black;
                    //    break;
                }
                Console.WriteLine(colors);

                System.Threading.Thread.Sleep(400);

                Console.Clear();
                Console.ResetColor();
            }
            Console.WriteLine("Round " + game.Colors.Count + ": \n");
        }

    }
}
