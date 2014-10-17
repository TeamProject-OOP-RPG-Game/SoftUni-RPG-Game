using System;

namespace TheGame
{
	public interface IGameEngine
	{
		IRenderer Renderer {get; set;}

		void StartGame();
		void EndGame();
	}
}

