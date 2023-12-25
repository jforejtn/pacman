using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePacman
{
	public class GameState(int boardWidth, int boardHeight)
	{
		public int Moves = 0;
		public int TopScore = 0;
		public int BoardWidth = boardWidth;
		public int BoardHeight = boardHeight;
		public List<GameObject> GameObjects = new();
		public GameObject Player = new(0, 0, 'O');

		public enum ActionOutcome
		{
			Quit
		, Update
		, Victory
		, None
		}

		private GameObject? ObjectAt(int x, int y)
		{
			foreach (var obj in GameObjects)
			{
				if (obj.X == x && obj.Y == y)
				{
					return obj;
				}
			}

			return null;
		}

		private int ObjectCount(char symbol)
		{
			int count = 0;

			foreach (var obj in GameObjects)
			{
				if (obj.Symbol == symbol)
				{
					count += 1;
				}
			}

			return count;
		}

		private ActionOutcome HandleArrowKey(ConsoleKey key)
		{
			int potentialPlayerX = Player.X;
			int potentialPlayerY = Player.Y;
			switch (key)
			{
				case ConsoleKey.LeftArrow:
				{
					potentialPlayerX -= 1;
					break;
				}
				case ConsoleKey.RightArrow:
				{
					potentialPlayerX += 1;
					break;
				}
				case ConsoleKey.DownArrow:
				{
					potentialPlayerY += 1;
					break;
				}
				case ConsoleKey.UpArrow:
				{
					potentialPlayerY -= 1;
					break;
				}
			}
			
			var obj = ObjectAt(potentialPlayerX, potentialPlayerY);
			if (obj == null)
			{
				if
				(
					potentialPlayerX >= 0
					&&
					potentialPlayerX < BoardWidth
					&&
					potentialPlayerY >= 0
					&&
					potentialPlayerY < BoardHeight
				)
				{
					Player.X = potentialPlayerX;
					Player.Y = potentialPlayerY;
					return ActionOutcome.Update;
				}
			}
			else
			{
				if (obj.Symbol == 'o')
				{
					GameObjects.Remove(obj);
					Player.X = potentialPlayerX;
					Player.Y = potentialPlayerY;

					if (ObjectCount('o') == 0)
					{
						return ActionOutcome.Victory;
					}
					else
					{
						return ActionOutcome.Update;
					}
				}
			}

			return ActionOutcome.None;
		}

		public ActionOutcome WaitForPlayerAction()
		{
			ConsoleKeyInfo input = Console.ReadKey(intercept: true);
			switch (input.Key)
			{
				case ConsoleKey.Q:
				{
					return ActionOutcome.Quit;
				}
				case ConsoleKey.UpArrow:
				case ConsoleKey.LeftArrow:
				case ConsoleKey.DownArrow:
				case ConsoleKey.RightArrow:
				{
					return HandleArrowKey(input.Key);
				}
				default:
				{
					return ActionOutcome.None;
				}
			}
		}
	}

}
