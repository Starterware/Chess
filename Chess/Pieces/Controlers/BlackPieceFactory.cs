using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    class BlackPieceFactory : PieceFactory
    {
        public BlackPieceFactory()
            : base(SideColor.Black)
        {

        }
    }
}
