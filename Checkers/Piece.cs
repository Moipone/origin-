using System;
using System.Collections.Generic;
using System.Text;

namespace Checkers
{
    public class Piece : IPiece
    {
        public Piece(Color c, int pos)
        {
            Status = Status.Active;
            Position = pos;
            Color = c;
        }


        public virtual Status Status { get; set; }
        public virtual Color Color { get; private set; }
        public virtual int Position { get; private set; }


        //public Status Status => throw new NotImplementedException();

        //public Color Color => throw new NotImplementedException();

        //public int Position => throw new NotImplementedException();

        public IEnumerable<int> CapturingMoves(IBoard board)
        {
            throw new NotImplementedException();
        }

        public virtual void Move(int destination)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<int> NormalMoves(IBoard board)
        {
            throw new NotImplementedException();
        }
    }
}
