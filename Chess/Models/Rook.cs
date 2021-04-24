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


            return cells;


        }
    }




}
