using System;
using System.Linq;
using Xunit;
using FluentAssertions;
using FluentAssertions.Collections;

namespace Chess.Test
{
    public class ChessTest
    {
        [Theory]
        [InlineData("king D5", "E5,C5,D6,D4,E4,E6,C4,C6")]
        [InlineData("king B1", "C1,A1,B2,C2,A2")]
        [InlineData("king A4", "B4,A5,A3,B3,B5")]
      
        public void chessboard_when_given_valid_input_for_king_should_produce_valid_output(string input, string expectedResponse)
        {
            var results = ChessBoardHelper.GetPossibleMoves(input);
            var expectedResults = expectedResponse.Split(",", StringSplitOptions.RemoveEmptyEntries).ToList();
            results.Should().BeEquivalentTo(expectedResults);

        }
        [Theory]
       
        [InlineData("Queen B1", "C1,D1,E1,F1,G1,H1,A1,B2,B3,B4,B5,B6,B7,B8,C2,D3,E4,F5,G6,H7,A2")]
        [InlineData("Queen A4", "B4,C4,D4,E4,F4,G4,H4,A5,A6,A7,A8,A3,A2,A1,B3,C2,D1,B5,C6,D7,E8")]
        [InlineData("Queen H1", "G1,F1,E1,D1,C1,B1,A1,H2,H3,H4,H5,H6,H7,H8,G2,F3,E4,D5,C6,B7,A8")]
        public void chessboard_when_given_valid_input_for_queen_should_produce_valid_output(string input, string expectedResponse)
        {
            var results = ChessBoardHelper.GetPossibleMoves(input);
            var expectedResults = expectedResponse.Split(",", StringSplitOptions.RemoveEmptyEntries).ToList();
            results.Should().BeEquivalentTo(expectedResults);

        }
        [Theory]
        [InlineData("Horse E3", "G4,F5,D5,C4,C2,G2,D1,F1")]
        [InlineData("Horse A5", "C6,C4,B3,B7")]
        [InlineData("Horse D4", "B3,B5,F5,F3,C2,E2,E6,C6")]
        public void chessboard_when_given_valid_input_for_horse_should_produce_valid_output(string input, string expectedResponse)
        {
            var results = ChessBoardHelper.GetPossibleMoves(input);
            var expectedResults = expectedResponse.Split(",", StringSplitOptions.RemoveEmptyEntries).ToList();
            results.Should().BeEquivalentTo(expectedResults);

        }
        [Theory]
        [InlineData("Rook E3", "F3,G3,H3,D3,C3,B3,A3,E4,E5,E6,E7,E8,E2,E1")]
        [InlineData("Rook A5", "B5,C5,D5,E5,F5,G5,H5,A6,A7,A8,A4,A3,A2,A1")]
        [InlineData("Rook D4", "E4,F4,G4,H4,C4,B4,A4,D5,D6,D7,D8,D3,D2,D1")]
        public void chessboard_when_given_valid_input_for_rook_should_produce_valid_output(string input, string expectedResponse)
        {
            var results = ChessBoardHelper.GetPossibleMoves(input);
            var expectedResults = expectedResponse.Split(",", StringSplitOptions.RemoveEmptyEntries).ToList();
             results.Should().BeEquivalentTo(expectedResults);

        }
        [Theory]
        [InlineData("Bishop E3", "D2,C1,D4,C5,B6,A7,F2,G1,F4,G5,H6")]
        [InlineData("Bishop A5", "B4,C3,D2,E1,B6,C7,D8")]
        [InlineData("Bishop D4", "C3,B2,A1,C5,B6,A7,E3,F2,G1,E5,F6,G7,H8")]
        public void chessboard_when_given_valid_input_for_bishop_should_produce_valid_output(string input, string expectedResponse)
        {
            var results = ChessBoardHelper.GetPossibleMoves(input);
            var expectedResults = expectedResponse.Split(",", StringSplitOptions.RemoveEmptyEntries).ToList();
            results.Should().BeEquivalentTo(expectedResults);

        }
        [Theory]
        [InlineData("Pawn E3", "F3")]
        [InlineData("Pawn A5", "B5")]
        [InlineData("Pawn D4", "E4")]
        public void chessboard_when_given_valid_input_for_pawn_should_produce_valid_output(string input, string expectedResponse)
        {
            var results = ChessBoardHelper.GetPossibleMoves(input);
            var expectedResults = expectedResponse.Split(",", StringSplitOptions.RemoveEmptyEntries).ToList();
            results.Should().BeEquivalentTo(expectedResults);

        }
    }
}
