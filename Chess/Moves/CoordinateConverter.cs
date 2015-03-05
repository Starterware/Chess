using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Moves
{
    class Coord
    {
        static public int RankToWhiteViewConverter(int rank) 
        {
            return rank;
        }

        static public int RankToBlackViewConverter(int rank) 
        {
            return BoardSize.MaxRank - rank - 1;
        }

        static public int FileToWhiteViewConverter(int file) 
        {
            return file;
        }

        static public int FileToBlackViewConverter(int file) 
        {
            return BoardSize.MaxFile - file - 1;
        }


        static public int RankFromWhiteViewConverter(int rank)
        {
            return rank;
        }

        static public int RankFromBlackViewConverter(int rank)
        {
            return BoardSize.MaxRank - rank - 1;
        }

        static public int FileFromWhiteViewConverter(int file)
        {
            return file;
        }

        static public int FileFromBlackViewConverter(int file)
        {
            return BoardSize.MaxFile - file - 1;
        }
    }
}
