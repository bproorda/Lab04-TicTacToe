using Lab04_TicTacToe.Classes;
using System;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StartGame();
        }

        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
            Console.WriteLine("Shall we play a game...of TicTacToe");
            Player player1 = new Player();
            Player player2 = new Player();
            Console.WriteLine("What is the name of Player 1?");
            player1.Name = Console.ReadLine();
            player1.Marker = "X";
            Console.WriteLine("What is the name of Player 1?");
            player2.Name = Console.ReadLine();
            player2.Marker = "O";
            Console.WriteLine($"Hello, {player1.Name} and {player2.Name}");
            Console.WriteLine($"{player1.Name} shall play {player1.Marker}, and {player2.Name} shall play {player2.Marker}");
            Game newGame = new Game(player1, player2);
            newGame.Board.DisplayBoard();
        }


    }
}
