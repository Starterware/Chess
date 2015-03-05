using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Board;

namespace Chess
{
    class Game
    {
        private CurrentGameState currentGameState;

        public Game() 
        {
            currentGameState = new CurrentGameState();
        }

        public void NewGame(string fen) 
        {
            currentGameState.SetFEN(fen);
        }

        public override string ToString()
        {
            return currentGameState.ToString();
        }
    }
}
