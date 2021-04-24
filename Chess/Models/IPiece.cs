using System.Collections.Generic;

namespace Chess.Models
{
    public interface IPiece
    {
       List<Cell> GetAllPossibleMove();
       
    }
}
