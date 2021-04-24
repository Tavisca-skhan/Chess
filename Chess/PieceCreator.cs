using Chess.Models;
using System;

namespace Chess
{
    public static class PieceCreator
    {
        public static IPiece GetPiece(string name, string  curr)
        {
            if (Enum.TryParse(name, true, out Pieces Piece))
            {
                var currCell = new Cell(curr);
                if (currCell.IsValidPosition() == false) throw new Exception("given position is invalid");
                switch (Piece)
                {
                    case Pieces.King:
                        return new King(currCell);


                    default:
                        throw new Exception(" piece name is not implemented");
                }
            }
            else throw new Exception("piece name is invalid");

        }
    }
}
