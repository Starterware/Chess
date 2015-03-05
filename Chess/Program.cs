using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            string fen = Console.ReadLine();
            game.NewGame(fen);
            Console.WriteLine(game);
            Console.ReadLine();
        }
    }
}
