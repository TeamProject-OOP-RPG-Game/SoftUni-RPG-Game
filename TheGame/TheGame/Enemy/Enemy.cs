using System;

namespace TheGame.Enemy
{
	public class Enemy:Character
	{
        //private const string DefaultEnemyImagePath = "..//..//King_Cold.png";

		public Enemy ()  //this (DefaultEnemyImagePath)
		{
		}

		public Enemy (string imagePath)
		{
			this.ImagePath = imagePath;
		}

        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
}

