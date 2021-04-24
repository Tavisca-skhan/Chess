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
          

            return cells;


        }
    }




}
