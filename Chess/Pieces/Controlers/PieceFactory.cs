using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    abstract class PieceFactory
    {
        private SideColor color;

        public PieceFactory(SideColor color) 
        {
            this.color = color;
        }

        public Piece GetNoPiece() 
        {
            return null;
        }

        public Piece GetKing()
        {
            return new King(new PieceID(), color);
        }

        public Piece GetQueen() 
        {
            return new Queen(new PieceID(), color);
        }

        public Piece GetRook()
        {
            return new Rook(new PieceID(), color);
        }

        public Piece GetBishop()
        {
            return new Bishop(new PieceID(), color);
        }

        public Piece GetKnight()
        {
            return new Knight(new PieceID(), color);
        }

        public Piece GetPawn()
        {
            return new Pawn(new PieceID(), color);
        }
    }
}
