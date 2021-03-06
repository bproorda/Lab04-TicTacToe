﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
	public class Player
	{
		public string Name { get; set; }
		/// <summary>
		/// P1 is X and P2 will be O
		/// </summary>
		public string Marker { get; set; }

		/// <summary>
		/// Flag to determine if it is the user's turn
		/// </summary>
		public bool IsTurn { get; set; }

		//Prompts the player to select a numbered postion, then uses PositionForNumber to select right Position object
		public Position GetPosition(Board board)
		{
			try
			{
				Position desiredCoordinate = null;
				while (desiredCoordinate is null)
				{
					Console.WriteLine("Please select a location");
					Int32.TryParse(Console.ReadLine(), out int position);
					desiredCoordinate = PositionForNumber(position);
				}
				return desiredCoordinate;
			}
			catch (ArgumentException)
			{

				Console.WriteLine("Invalid input");
				return null;
			}
			catch (InvalidOperationException)
			{
				throw;
			}


		}

		//connected number from board to new postion object
		//returns null if invalid number chosen
		public static Position PositionForNumber(int position)
		{
			try
			{
				switch (position)
				{
					case 1: return new Position(0, 0); // Top Left
					case 2: return new Position(0, 1); // Top Middle
					case 3: return new Position(0, 2); // Top Right
					case 4: return new Position(1, 0); // Middle Left
					case 5: return new Position(1, 1); // Middle Middle
					case 6: return new Position(1, 2); // Middle Right
					case 7: return new Position(2, 0); // Bottom Left
					case 8: return new Position(2, 1); // Bottom Middle 
					case 9: return new Position(2, 2); // Bottom Right

					default: return null;
				}
			}
			catch (ArgumentException)
			{

				Console.WriteLine("Invalid input");
				return null;
			}
			catch (InvalidOperationException)
			{
				throw;
			}
		}
		//Tells the current player to take their turn
		//uses GetPosition to create new position object
		// if not a number, converts position to player's marker
	
		public void TakeTurn(Board board)
		{
			//IsTurn = false;
			try
			{

				Console.WriteLine($"{Name} it is your turn");

				Position position = GetPosition(board);

				if (Int32.TryParse(board.GameBoard[position.Row, position.Column], out int _))
				{
					board.GameBoard[position.Row, position.Column] = Marker;
				}
				else
				{
					Console.WriteLine("This space is already occupied");
					TakeTurn(board);

				}
			}
			catch (ArgumentException)
			{

				Console.WriteLine("Invalid input");
			}
		}
	}
}
