using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePacman
{
	public class Canvas
	{
		public void Draw(GameState state)
		{
			List<char[]> board = new();
			string hyphens = String.Concat(System.Linq.Enumerable.Repeat("-", state.BoardWidth));
			string spaces = String.Concat(System.Linq.Enumerable.Repeat(" ", state.BoardWidth));
			string topBottomRow = $"+{hyphens}+";
			string middleRow = $"|{spaces}|";

			board.Add(topBottomRow.ToCharArray());
			for (int i = 0; i < state.BoardHeight; i++)
			{
				board.Add(middleRow.ToCharArray());
			}
			board.Add(topBottomRow.ToCharArray());

			foreach (var gameObject in state.GameObjects)
			{
				char[] line = board[gameObject.Y + 1];
				line[gameObject.X + 1] = gameObject.Symbol;
			}

			char[] playerLine = board[state.Player.Y + 1];
			playerLine[state.Player.X + 1] = state.Player.Symbol;

			Console.Clear();
			foreach (var line in board)
			{
				Console.WriteLine(line);
			}
		}
	}

}
