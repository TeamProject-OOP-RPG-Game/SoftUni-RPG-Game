using System;

namespace TheGame.Player
{
	public class Player:Character
	{
		private const string DefaultPlayerImagePath = "..//..//images/player.png";

        public Player()
            : this(DefaultPlayerImagePath)
		{
		}

        public Player(string imagePath)
		{
			this.ImagePath = imagePath;
		}
	}
}

