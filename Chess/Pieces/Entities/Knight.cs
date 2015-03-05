using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    class Knight : Piece
    {
        public Knight(PieceID id, SideColor color)
            : base(id, color) 
        { 
            //allowedMoves.Add(new AllowedMove(1, 2));
            //allowedMoves.Add(new AllowedMove(2, 1));

            //allowedMoves.Add(new AllowedMove(-1, 2));
            //allowedMoves.Add(new AllowedMove(2, -1));

            //allowedMoves.Add(new AllowedMove(1, -2));
            //allowedMoves.Add(new AllowedMove(-2, 1));

            //allowedMoves.Add(new AllowedMove(-1, -2));
            //allowedMoves.Add(new AllowedMove(-2, -1));
        }

        public override string Symbol
        {
            get { return PieceSymbol.Knight; }
        }
    }
}
