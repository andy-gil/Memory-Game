using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class MemoryGame
    {
        public bool Gameover { get; private set; }
        public List<Colors> Colors { get; private set; }

        private int guessPosition = 0;

        public MemoryGame()
        {
            Colors = new List<Colors>();
            randColor();
        }

        public bool MakeGuess(Colors color)
        {
            if (Colors[guessPosition] != color)
            {
                Gameover = true;
                return false;
            }
            else
            {
                //round over
                if(guessPosition == Colors.Count - 1)
                {
                    guessPosition = 0;
                    randColor();
                    return false;
                }
                else
                {
                    guessPosition++;
                    return true;
                }
            }
        }

        private void randColor()
        {
            Random random = new Random();
            int randomColor = random.Next(4);
            Colors randColor = (Colors)randomColor;

            Colors.Add(randColor);
        }
    }
}
