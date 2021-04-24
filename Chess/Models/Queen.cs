using System.Collections.Generic;

namespace Chess.Models
{
    public class Queen : IPiece
    {
        private readonly Cell Current;
        public Queen(Cell current)
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
