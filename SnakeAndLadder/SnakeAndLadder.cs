using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SnakeAndLadder
    {
        public const int NO_PLAY = 0, SNAKE = 1, LADDER = 2, WINNING = 100;
        public int Start = 0;
        public int RolledDice;
        int Option = 0;
        public void GamePlayed()
        {
            while (this.Start < 100)
            {
                Random Random = new Random();
                RolledDice = Random.Next(1, 7);
                Console.WriteLine("player Roll  Dice number is:" + " " + RolledDice);
                Option = Random.Next(0, 3);
                Console.WriteLine("Dice value:" + Option);
                switch (Option)
                {
                    case NO_PLAY:
                        Console.WriteLine("No Play");
                        break;
                    case SNAKE:
                        Start += RolledDice;
                        Console.WriteLine("Got Ladder:" + Start);
                        break;
                    case LADDER:
                        Start -= RolledDice;
                        Console.WriteLine("Snake Attack:" + Start);
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }
        }
    }
}
