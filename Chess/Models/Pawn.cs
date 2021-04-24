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


            return cells;


        }
    }




}
