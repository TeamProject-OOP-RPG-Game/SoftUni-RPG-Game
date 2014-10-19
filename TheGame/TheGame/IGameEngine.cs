using System;
using TheGame.Renderers;

namespace TheGame
{
	public interface IGameEngine
	{

		void StartGame();
		void EndGame();

        void Draw(IRenderable item);
    }
}

