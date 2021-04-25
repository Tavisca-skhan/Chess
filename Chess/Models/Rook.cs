using System.Collections.Generic;

namespace Chess.Models
{
    public class Rook : IPiece
    {
        private readonly Cell Current;
        public Rook(Cell current)
        {
            Current = current;
        }
        public List<Cell> GetAllPossibleMove()
        {

            var cells = new List<Cell>();
            var moveMent = Movement.GetInstance();
            cells.AddRange(moveMent.GetPossibleMoveOfDown(Current, 8));
            cells.AddRange(moveMent.GetPossibleMoveOfUp(Current, 8));
            cells.AddRange(moveMent.GetPossibleMoveOfRight(Current, 8));
            cells.AddRange(moveMent.GetPossibleMoveOfLeft(Current, 8));
            return cells;


        }
    }




}
