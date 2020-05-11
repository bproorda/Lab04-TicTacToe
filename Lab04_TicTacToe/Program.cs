using Lab04_TicTacToe.Classes;
using System;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            StartGame();
        }

        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
            Console.WriteLine("Shall we play a game...of TicTacToe?");
          
            //Creating Player 1
            Console.WriteLine("What is the name of Player 1?");
            Player player1 = new Player()
            {
                Name = Console.ReadLine(),
                Marker = "X",
                IsTurn = true,
            };
       
            //Creating Player2     
            Console.WriteLine("What is the name of Player 2?");
            Player player2 = new Player()
            {
                Name = Console.ReadLine(),
                Marker = "0",
                IsTurn = false,
            };
            Console.WriteLine($"Hello, {player1.Name} and {player2.Name}");
            Console.WriteLine($"{player1.Name} shall play {player1.Marker}, and {player2.Name} shall play {player2.Marker}");

            //Creating a new game
            Game newGame = new Game(player1, player2);
            newGame.Board.DisplayBoard();

            //Calling play method and waiting for it to return a winnner
            Player winner = newGame.Play();
            if (winner != null)
            {
                Console.WriteLine($"Congratulations, {winner.Name}! You won!");
            } else
            {
                Console.WriteLine("An interesting game, the only way to win is not to play.");
            }
            
          
            

        }


    }
}
