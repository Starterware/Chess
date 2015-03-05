using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    class Bishop : Piece
    {
        public Bishop(PieceID id, SideColor color)
            : base(id, color) 
        { 
        
        }

        public override string Symbol
        {
            get { return PieceSymbol.Bishop; }
        }
    }
}
