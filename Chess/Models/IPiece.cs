using System.Collections.Generic;

namespace Chess.Models
{
    public interface IPiece
    {
       List<Cell> GetAllPossibleMove();
       
    }
    public enum Pieces
    {

        King,
        Queen,
        Rook,
        Horse,
        Pawn,
        Bishop
    }
}
