using System.Collections.Generic;

namespace Chess.Models
{
    public class King : IPiece
    {
        private readonly Cell Current;
        public King(Cell current)
        {
            Current = current;
        }
        public List<Cell> GetAllPossibleMove()
        {
           
            var cells = new List<Cell>();
            var moveMent = Movement.GetInstance();
            cells.AddRange(moveMent.GetPossibleMoveOfDown(Current, 1));
            cells.AddRange(moveMent.GetPossibleMoveOfUp(Current, 1));
            cells.AddRange(moveMent.GetPossibleMoveOfRight(Current, 1));
            cells.AddRange(moveMent.GetPossibleMoveOfLeft(Current, 1));
            cells.AddRange(moveMent.GetPossibleMoveOfUpLeft(Current, 1));
            cells.AddRange(moveMent.GetPossibleMoveOfUpRight(Current, 1));
            cells.AddRange(moveMent.GetPossibleMoveOfDownLeft(Current, 1));
            cells.AddRange(moveMent.GetPossibleMoveOfDownRight(Current, 1));

            return cells;


        }
    }




}
