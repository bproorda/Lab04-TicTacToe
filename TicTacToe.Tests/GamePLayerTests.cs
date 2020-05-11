using System;
using System.Collections.Generic;
using System.Text;
using Lab04_TicTacToe.Classes;
using Xunit;

namespace TicTacToe.Tests
/* Tests we need 
 1. Given a game board, test for winners
2. Test that there is a switch in players between turns
3. Test to confirm that the position the player inputs correlates to the correct index of the array
4. One other "unique" test of your own */
{
    public class GamePLayerTests
    {
        [Fact]
        public void CanViewBoard()
        {
            //Arrange 
            Lab04_TicTacToe.Classes.Player player1 = new Player();
            Lab04_TicTacToe.Classes.Player player2 = new Player();
            player1.Name = "Scott";
            player2.Name = "Brennan";


            //act
            Lab04_TicTacToe.Classes.Game newGame = new Game(player1, player2);


            //Assert
            Assert.NotNull(player1);
            Assert.Equal("Brennan", player2.Name);
            Assert.NotNull(newGame);
        }

        [Fact]
        public void CheckForWinnerTest()
        {
            //Arrange 
            Lab04_TicTacToe.Classes.Player player1 = new Player();
            Lab04_TicTacToe.Classes.Player player2 = new Player();
            player1.Name = "Scott";
            player2.Name = "Brennan";
            Lab04_TicTacToe.Classes.Game newGame = new Game(player1, player2);
            bool expected = false;

            //act 
            bool result = newGame.CheckForWinner(newGame.Board);

            //assert 
            Assert.Equal(expected, result);
        }
       
            [Fact]
        public void PositionForNumberTest()
        {
            //Arrange
            Lab04_TicTacToe.Classes.Player player1 = new Player();
            Lab04_TicTacToe.Classes.Player player2 = new Player();
            player1.Name = "Scott";
            player2.Name = "Brennan";
            Lab04_TicTacToe.Classes.Game newGame = new Game(player1, player2);
            int numericalPosition = 5;
            int[] expected = new int[] { 1, 1 };

            //act
            Lab04_TicTacToe.Classes.Position testPosition = Lab04_TicTacToe.Classes.Player.PositionForNumber(numericalPosition);
            int[] result = new int[] { testPosition.Row, testPosition.Column };

            //assert
            Assert.Equal(expected, result);

        }
        [Fact]
        public void SwitchPLayerTest()
        {
            //Arrange
            Lab04_TicTacToe.Classes.Player player1 = new Player();
            Lab04_TicTacToe.Classes.Player player2 = new Player();
            player1.Name = "Scott";
            player2.Name = "Brennan";
            Lab04_TicTacToe.Classes.Game newGame = new Game(player1, player2);
            player1.IsTurn = true;
            player2.IsTurn = false;

            //Act
            newGame.SwitchPlayer();

            //Assert
            Assert.False(player1.IsTurn);
            Assert.True(player2.IsTurn);

    }
    }
}
