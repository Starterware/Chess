using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Chess.Pieces;

namespace Chess.Board
{
    /// <summary>
    /// Forsyth-Edwards Notation 
    /// </summary>
    class FENHandler
    {
        private const string DefaultFEN = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";

        public bool IsValid { get; private set; }
        public Piece[,] Board { get; private set; }
        public bool IsWhiteTurn { get; private set; }
        // castling
        // en passantsquare
        // halfmove
        // full move number

        public FENHandler(string fen)
        {
            IsValid = true;
            Board = new Piece[BoardSize.MaxRank, BoardSize.MaxFile];

            RetrieveInformation(fen);
        }

        private void RetrieveInformation(string fen)
        {
            if (string.IsNullOrEmpty(fen)) fen = DefaultFEN;
            string[] splittedFEN = fen.Split(' ');

            if (splittedFEN.Length == 6)
            {
                SetBoard(splittedFEN[0]);
                //if (!IsValid) SetTurn(splittedFEN[1]);
                //if (!IsValid) SetCastlingAvailability(splittedFEN[2]);
                //if (!IsValid) SetEnPassantSquare(splittedFEN[3]);
                //if (!IsValid) SetHalfmoveClock(splittedFEN[4]);
                //if (!IsValid) SetFullmoveNumber(splittedFEN[5]);
            }
            else
            {
                IsValid = false;
            }

            if (!IsValid) 
                SetInvalidValues();
        }

        private void SetInvalidValues()
        {
            Board = null;
        }

        private void SetBoard(string fen)
        {
            WhitePieceFactory whitePieceFactory = new WhitePieceFactory();
            BlackPieceFactory blackPieceFactory = new BlackPieceFactory();
            
            Piece currentP;
            int rank = 0, file = 0;
            for (int i = 0; i < fen.Length; ++i) 
            {
                currentP = null;

                switch (fen[i]) 
                {
                    case 'p': currentP = whitePieceFactory.GetPawn(); break;
                    case 'r': currentP = whitePieceFactory.GetRook(); break;
                    case 'n': currentP = whitePieceFactory.GetKnight(); break;
                    case 'b': currentP = whitePieceFactory.GetBishop(); break;
                    case 'q': currentP = whitePieceFactory.GetQueen(); break;
                    case 'k': currentP = whitePieceFactory.GetKing(); break;
                    case 'P': currentP = blackPieceFactory.GetPawn(); break;
                    case 'R': currentP = blackPieceFactory.GetRook(); break;
                    case 'N': currentP = blackPieceFactory.GetKnight(); break;
                    case 'B': currentP = blackPieceFactory.GetBishop(); break;
                    case 'Q': currentP = blackPieceFactory.GetQueen(); break;
                    case 'K': currentP = blackPieceFactory.GetKing(); break;
                    case '/': 
                        if (rank != BoardSize.MaxFile)
                        {
                            IsValid = false;
                            return;
                        }
                        ++file; 
                        rank = 0; 
                        break;
                    default: //number
                        if (fen[i] < '0' || fen[i] > '9')
                        {
                            IsValid = false;
                            return;
                        }
                        int num = Convert.ToInt32(fen[i].ToString());
                        for (int j = 0; j < num; ++j)
                           Board[file, rank++] = null;
                        break;
                }
                
                if (currentP != null)
                    Board[file, rank++] = currentP;
            }

            if (file != BoardSize.MaxFile - 1)
                IsValid = false;
        }

        private void SetTurn(string fen)
        {
            throw new NotImplementedException();
        }

        private void SetCastlingAvailability(string fen)
        {
            throw new NotImplementedException();
        }

        private void SetEnPassantSquare(string fen)
        {
            throw new NotImplementedException();
        }

        private void SetHalfmoveClock(string fen)
        {
            throw new NotImplementedException();
        }

        private void SetFullmoveNumber(string fen)
        {
            throw new NotImplementedException();
        }
    }
}
