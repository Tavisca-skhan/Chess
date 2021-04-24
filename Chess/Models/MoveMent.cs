using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Models
{
    public sealed class Movement
    {
         Movement() { }
        private Movement movement;
        
        private static readonly object padlock = new object();
        private static Movement instance = null;
        public static Movement GetInstance()
        {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new Movement();
                        }
                    }
                }
                return instance;
            
        }

        public  List<Cell>  GetPossibleMoveOfUp(Cell curr, int boundry)
        {
            var cells = new List<Cell>();
            for (int i = 1; i <= boundry; i++)
            {
                int row = curr.Row + i;
                int column = curr.Column;
                var newcell = new Cell(row, column);
                if (newcell.IsValidPosition() == false) break;
                cells.Add(newcell);
            }
            return cells;

        }
       public  List<Cell> GetPossibleMoveOfDown(Cell curr, int boundry)
        {
            var cells = new List<Cell>();
            for (int i = 1; i <= boundry; i++)
            {
                int row = curr.Row -i;
                int column = curr.Column;
                var newcell = new Cell(row, column);
                if (newcell.IsValidPosition() == false) break;
                cells.Add(newcell);
            }
            return cells;

        }
      public   List<Cell> GetPossibleMoveOfLeft(Cell curr, int boundry)
        {
            var cells = new List<Cell>();
            for (int i = 1; i <= boundry; i++)
            {
                int row = curr.Row;
                int column = curr.Column-i;
                var newcell = new Cell(row, column);
                if (newcell.IsValidPosition() == false) break;
                cells.Add(newcell);
            }
            return cells;

        }
       public  List<Cell> GetPossibleMoveOfRight(Cell curr, int boundry)
        {
            var cells = new List<Cell>();
            for (int i = 1; i <= boundry; i++)
            {
                int row = curr.Row;
                int column = curr.Column+i;
                var newcell = new Cell(row, column);
                if (newcell.IsValidPosition() == false) break;
                cells.Add(newcell);
            }
            return cells;

        }
        public  List<Cell> GetPossibleMoveOfUpRight(Cell curr, int boundry)
        {
            var cells = new List<Cell>();
            for (int i = 1; i <= boundry; i++)
            {
                int row = curr.Row - i;
                int column = curr.Column + i;
                var newcell = new Cell(row, column);
                if (newcell.IsValidPosition() == false) break;
                cells.Add(newcell);
            }
            return cells;

        }

        public  List<Cell> GetPossibleMoveOfUpLeft(Cell curr, int boundry)
        {
            var cells = new List<Cell>();
            for (int i = 1; i <= boundry; i++)
            {
                int row = curr.Row - i;
                int column = curr.Column - i;
                var newcell = new Cell(row, column);
                if (newcell.IsValidPosition() == false) break;
                cells.Add(newcell);
            }
            return cells;

        }
        public  List<Cell> GetPossibleMoveOfDownLeft(Cell curr, int boundry)
        {
            var cells = new List<Cell>();
            for (int i = 1; i <= boundry; i++)
            {
                int row = curr.Row +i;
                int column = curr.Column - i;
                var newcell = new Cell(row, column);
                if (newcell.IsValidPosition() == false) break;
                cells.Add(newcell);
            }
            return cells;

        }
        public  List<Cell> GetPossibleMoveOfDownRight(Cell curr, int boundry)
        {
            var cells = new List<Cell>();
            for (int i = 1; i <= boundry; i++)
            {
                int row = curr.Row + i;
                int column = curr.Column + i;
                var newcell = new Cell(row, column);
                if (newcell.IsValidPosition() == false) break;
                cells.Add(newcell);
            }
            return cells;

        }
    }
}
