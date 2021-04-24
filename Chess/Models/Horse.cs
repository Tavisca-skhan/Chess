using System.Collections.Generic;

namespace Chess.Models
{
    public class Horse : IPiece
    {
        private readonly Cell Current;
        public Horse(Cell current)
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
