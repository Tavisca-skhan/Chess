using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter peaceName and position"); //“King D5
            var input = Console.ReadLine().Trim().Split(' ');
            string PieceName = input[0];
            string Position = input[1];
            var piece = PieceCreator.GetPiece(PieceName, Position);
            var possibleMoves = piece.GetAllPossibleMove().Select(x => x.BoardValue).ToList(); ;
            string combindedString = string.Join(",", possibleMoves);
            Console.WriteLine("possible moves are " +combindedString);
            
        }
    }
}
