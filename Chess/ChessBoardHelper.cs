using System.Collections.Generic;
using System.Linq;

namespace Chess
{
    public class ChessBoardHelper
    {
        public static List<string> GetPossibleMoves(string piecewithposition)
        {
            
            var input = piecewithposition.Split(' ');
            string PieceName = input[0];
            string Position = input[1];
            var piece = PieceCreator.GetPiece(PieceName, Position);
            var possibleMoves = piece.GetAllPossibleMove();
            return possibleMoves.Select(x => x.BoardValue).ToList();
        }

    }
}
