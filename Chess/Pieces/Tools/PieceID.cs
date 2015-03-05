using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    class PieceID
    {
        static PieceID() 
        {
            InitIDGenerator();
        }

        public PieceID()
        {
            Value = GetNextID();
        }

        public int Value { get; private set; }

        static private int nextID;

        static private void InitIDGenerator()
        {
            nextID = 0;
        }

        static private int GetNextID() 
        {
            return nextID++;
        }
    }
}
