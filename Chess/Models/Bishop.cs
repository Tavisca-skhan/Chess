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


            return cells;


        }
    }




}
