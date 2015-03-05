using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    class PossibleMove
    {
        public PossibleMove(int toColumn, int toRow, bool isVector = false, bool isAttackMove = true) 
        {
            ToRow = toRow;
            ToColumn = toColumn;
            IsVector = isVector;
            IsAttackMove = isAttackMove;
        }
        
        public int ToColumn { get; private set; }
        public int ToRow { get; private set; }
        public bool IsVector { get; private set; }
        public bool IsAttackMove { get; private set; }
    }
}
