using System;
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
            var moveMent = Movement.GetInstance();
            int upIndex = Current.Row + 2;  // up
            int downIndex = Current.Row - 2; // down
            int leftIndex = Current.Column - 2; // left
            int rightIndex = Current.Column + 2; //right
            var cell = new Cell(upIndex, Current.Column);
            if(cell.IsValidPosition())
            {
                cells.AddRange(moveMent.GetPossibleMoveOfLeft(cell, 1));
                cells.AddRange(moveMent.GetPossibleMoveOfRight(cell, 1));

            }
             //vertical down
             cell = new Cell(downIndex, Current.Column);
            if (cell.IsValidPosition())
            {
                cells.AddRange(moveMent.GetPossibleMoveOfRight(cell, 1));
                cells.AddRange(moveMent.GetPossibleMoveOfLeft(cell, 1));

            }
            cell = new Cell(Current.Row, leftIndex);
            if (cell.IsValidPosition())
            {
                cells.AddRange(moveMent.GetPossibleMoveOfUp(cell, 1));
                cells.AddRange(moveMent.GetPossibleMoveOfDown(cell, 1));

            }
            cell = new Cell(Current.Row, rightIndex);
            if (cell.IsValidPosition())
            {
                cells.AddRange(moveMent.GetPossibleMoveOfDown(cell, 1));
                cells.AddRange(moveMent.GetPossibleMoveOfUp(cell, 1));

            }


            return cells;


        }

       
    }




}
