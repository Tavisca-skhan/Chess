using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Models
{
    public class Cell
    {
        public int Row;
        public int Column;
        public string BoardValue;

        public Cell(int row, int column)
        {
            Row = row;
            Column = column;
            BoardValue = GetValue(row, column);

        }
        public bool IsValidPosition()
        {
            return (Row >= 0 && Row < 8) && Column >= 0 && Column < 8;
        }

        public Cell(string boardValue)
        {
            BoardValue = boardValue;
            Row = 72-(int)boardValue[0];
            Column = Convert.ToInt32(boardValue[1].ToString()) - 1;
        }
        //public override bool Equals(object obj)
        //{
        //    var cell = obj as Cell;
        //    return cell != null &&
        //           Row == cell.Row &&
        //           Column == cell.Column;
        //}

        
        private string GetValue(int x, int y)
        {
            return ((char)(72 - x)) + (y + 1).ToString();

        }
    }
}

