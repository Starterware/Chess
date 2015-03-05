using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Board;
using Chess.Pieces;

namespace Chess
{
    class CurrentGameState
    {
        private Dictionary<int, Piece>[] pieceDictionaries;

        private Piece[,] board;
        private int sideToPlay;

        public CurrentGameState() 
        {
            pieceDictionaries = new Dictionary<int, Piece>[2];

            pieceDictionaries[(int) SideColor.Black] = new Dictionary<int, Piece>();
            pieceDictionaries[(int) SideColor.White] = new Dictionary<int, Piece>();

            board = new Piece[BoardSize.MaxRank, BoardSize.MaxFile];
            sideToPlay = 0;
        }

        public void SetFEN(string fen)
        {
            FENHandler fenHandler = new FENHandler(fen);
            board = fenHandler.Board;

            for (int i = 0; i < BoardSize.MaxRank; ++i)
                for (int j = 0; j < BoardSize.MaxFile; ++j)
                    AddPieceToDictionary(board[i, j]);
        }

        public string GetPieceAt(int rank, int file) 
        {
            if (rank < 0 || rank >= BoardSize.MaxRank || file < 0 || file >= BoardSize.MaxFile) 
                return string.Empty;
            return (board[file, rank] == null) ? string.Empty : board[file, rank].ToString();
        }

        //public List<KeyValuePair<int,int>> GetPossibleMoveSquares(int rank, int file)
        //{
        //    if (board[file, rank] == null || (int)board[file, rank].Color == sideToPlay) return null;
        //    return MoveHandler.GetListOfPossibleSquares(board[file, rank].PossibleMoves);
        //}

        private void AddPieceToDictionary(Piece p)
        {
            if (null == p) return;
            pieceDictionaries[(int) p.Color].Add(p.ID.Value, p);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < BoardSize.MaxFile; ++i)
            {
                for (int j = 0; j < BoardSize.MaxRank; ++j)
                {
                    builder.Append((null != board[i, j]) ? board[i, j].ToString() : " ");
                }
                builder.AppendLine();
            }
            return builder.ToString();
        }
    }
}
