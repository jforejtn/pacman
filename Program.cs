using System.Linq.Expressions;

namespace ConsolePacman
{
	internal class Program
	{
		static void Main(string[] args)
		{
			GameState state = new(30, 8);
			Levels.CreateLevel(state);
			Canvas canvas = new();
			canvas.Draw(state);
			bool quitGame = false;
			while (quitGame == false)
			{
				var outcome = state.WaitForPlayerAction();
				switch (outcome)
				{
					case GameState.ActionOutcome.Victory:
					{
						canvas.Draw(state);
						Console.WriteLine("You are victorious!");
						quitGame = true;
						break;
					}
					case GameState.ActionOutcome.Quit:
					{
						quitGame = true;
						break;
					}
					case GameState.ActionOutcome.Update:
					{
						canvas.Draw(state);
						break;
					}
				}
			}
		}
	}
}
