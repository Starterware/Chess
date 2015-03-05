using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Pieces;

namespace Chess.Moves
{
    class MoveHandler
    {
        public List<KeyValuePair<int, int>> GetListOfPossibleSquares(CurrentGameState gameState, int rank, int file) 
        {
            List<KeyValuePair<int, int>> possibleSquares = new List<KeyValuePair<int, int>>();

            //foreach (PossibleMove move in gameState.board[file, rank].PossibleMoves) 
            //{ 
                
            //}

            return possibleSquares;
        }
    }
}
