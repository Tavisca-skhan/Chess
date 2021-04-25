using System.Collections.Generic;

namespace Chess.Models
{
    public class Pawn : IPiece
    {
        private readonly Cell Current;
        public Pawn(Cell current)
        {
            Current = current;
        }
        public List<Cell> GetAllPossibleMove()
        {

            var cells = new List<Cell>();
            var moveMent = Movement.GetInstance();
            cells.AddRange(moveMent.GetPossibleMoveOfUp(Current, 1));
            return cells;
        }
    }




}
