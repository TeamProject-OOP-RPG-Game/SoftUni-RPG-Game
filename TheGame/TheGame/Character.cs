using System;
using TheGame.Renderers;
using TheGame.Structure;

namespace TheGame
{
	public class Character: GameObject, IRenderable
	{
		public Character (int X, int Y, int SizeX, int SizeY)
		{
		    this.X = X;
		    this.Y = Y;
		    this.SizeX = SizeX;
		    this.SizeY = SizeY;
		}

        public SpriteType SpriteType { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public int SizeX { get; set; }

        public int SizeY { get; set; }
    }
}

