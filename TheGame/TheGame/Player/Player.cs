using System;

namespace TheGame.Player
{
	public class Player:Character
	{
        //private const string DefaultPlayerImagePath = "..//..//images/King_Cold.png";

        public Player()
           // : this(DefaultPlayerImagePath)
		{
		}

        public Player(string imagePath)
		{
			this.ImagePath = imagePath;
		}

        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
}

