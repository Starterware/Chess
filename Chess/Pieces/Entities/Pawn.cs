using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    class Pawn : Piece
    {
        public Pawn(PieceID id, SideColor color)
            : base(id, color) 
        {
            //moves.Add(new PossibleMove(0, 1, false, false));
            //moves.Add(new PossibleMove(0, 2, false, false));
            //moves.Add(new PossibleMove(1, 1));
            //moves.Add(new PossibleMove(-1, 1));
        }

        public override string Symbol
        {
            get { return PieceSymbol.Pawn; }
        }
    }
}
