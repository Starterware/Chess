using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    class Rook : Piece
    {
        public Rook(PieceID id, SideColor color)
            : base(id, color) 
        {
            
        }

        public override string Symbol
        {
            get { return PieceSymbol.Rook; }
        }
    }
}
