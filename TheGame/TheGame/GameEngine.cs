using System;

namespace TheGame
{
	public class GameEngine:IGameEngine
	{
		public GameEngine ()
		{
		}

		public IRenderer Renderer {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public void StartGame ()
		{
			throw new NotImplementedException ();
		}

		public void EndGame ()
		{
			throw new NotImplementedException ();
		}
	}
}

