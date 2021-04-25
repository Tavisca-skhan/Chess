using System.Collections.Generic;

namespace Chess.Models
{
    public class Bishop : IPiece
    {
        private readonly Cell Current;
        public Bishop(Cell current)
        {
            Current = current;
        }
        public List<Cell> GetAllPossibleMove()
        {
            var cells = new List<Cell>();
            var moveMent = Movement.GetInstance();
            cells.AddRange(moveMent.GetPossibleMoveOfDownLeft(Current, 8));
            cells.AddRange(moveMent.GetPossibleMoveOfDownRight(Current, 8));
            cells.AddRange(moveMent.GetPossibleMoveOfUpLeft(Current, 8));
            cells.AddRange(moveMent.GetPossibleMoveOfUpRight(Current, 8));
            return cells;
        }
    }




}
