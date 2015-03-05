using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    class Queen : Piece
    {
        public Queen(PieceID id, SideColor color)
            : base(id, color) 
        {
            //allowedMoves.Add("UP", new AllowedMove(0, 1, true));
        }

        public override string Symbol
        {
            get { return PieceSymbol.Queen; }
        }
    }
}
