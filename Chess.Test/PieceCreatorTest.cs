using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using Chess.Models;

namespace Chess.Test
{
   public class PieceCreatorTest
    {
        [Theory]
        [InlineData("King", "D5")]
        [InlineData("Horse", "D3")]
        [InlineData("Rook", "D6")]
        [InlineData("Pawn","A6")]
        public void piececreator_when_given_valid_input_should_create_valid_piece(string name,string pos)
        {
            var piece =PieceCreator.GetPiece(name, pos);
            if(name.Equals("King"))
            {
                piece.Should().BeOfType<King>();
            }
            else if(name.Equals("Horse"))
            {
                piece.Should().BeOfType<Horse>();
            }
            else if (name.Equals("Rook"))
            {
                    piece.Should().BeOfType<Rook>();
            }
            else if (name.Equals("Pawn"))
            {
                piece.Should().BeOfType<Pawn>();
            }

        }
        [Theory]
        [InlineData("King1", "D9")]
        [InlineData("Kings", "D6")]
        
        public void piececreator__when_given_invalid_input_should_throw_exception(string name, string pos)
        {
            Action response = () => PieceCreator.GetPiece(name, pos);
            Assert.ThrowsAny<Exception>(response);
        }
    }


}
