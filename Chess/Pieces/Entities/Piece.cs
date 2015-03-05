using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    abstract class Piece
    {
        protected Dictionary<string, PossibleMove> moves;

        public int Rank { get; protected set; }
        public int File { get; protected set; }

        public PieceID ID { get; protected set; }
        public SideColor Color { get; private set; }
        abstract public string Symbol { get; }

        public Piece(PieceID id, SideColor color) 
        {
            Color = color;
            ID = id;
        }

        public void SetCoordinates(int rank, int file) 
        {
            Rank = rank;
            File = file;
        }

        public List<PossibleMove> PossibleMoves { get { return moves.Values.ToList(); } }

        public override string ToString()
        {
            return ((Color == SideColor.White) ? Symbol.ToLower() : Symbol.ToUpper());
        }
    }
}
