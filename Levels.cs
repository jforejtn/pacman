using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePacman
{
	public class Levels
	{
		public static void CreateLevel(GameState state)
		{
			state.GameObjects.Add(new GameObject(4, 0, 'X'));
			state.GameObjects.Add(new GameObject(4, 1, 'X'));
			state.GameObjects.Add(new GameObject(12, 2, 'X'));
			state.GameObjects.Add(new GameObject(19, 1, 'X'));
			state.GameObjects.Add(new GameObject(20, 1, 'X'));
			state.GameObjects.Add(new GameObject(21, 1, 'X'));
			state.GameObjects.Add(new GameObject(19, 1, 'X'));
			state.GameObjects.Add(new GameObject(21, 2, 'X'));
			state.GameObjects.Add(new GameObject(21, 3, 'X'));
			state.GameObjects.Add(new GameObject(3, 4, 'X'));
			state.GameObjects.Add(new GameObject(3, 5, 'X'));
			state.GameObjects.Add(new GameObject(3, 6, 'X'));
			state.GameObjects.Add(new GameObject(17, 6, 'X'));
			state.GameObjects.Add(new GameObject(18, 6, 'X'));
			state.GameObjects.Add(new GameObject(19, 6, 'X'));
			
			state.GameObjects.Add(new GameObject(1, 0, 'o'));
			state.GameObjects.Add(new GameObject(25, 0, 'o'));
			state.GameObjects.Add(new GameObject(8, 1, 'o'));
			state.GameObjects.Add(new GameObject(22, 3, 'o'));
			state.GameObjects.Add(new GameObject(1, 4, 'o'));
			state.GameObjects.Add(new GameObject(16, 4, 'o'));
			state.GameObjects.Add(new GameObject(1, 7, 'o'));
			state.GameObjects.Add(new GameObject(18, 7, 'o'));

			state.Player.X = 7;
			state.Player.Y = 5;
		}
	}
}
