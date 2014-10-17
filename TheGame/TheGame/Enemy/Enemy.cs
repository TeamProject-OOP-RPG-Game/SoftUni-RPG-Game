using System;

namespace TheGame.Enemy
{
	public class Enemy:Character
	{
		private const string DefaultEnemyImagePath = "..//..//enemy.png";

		public Enemy () : this (DefaultEnemyImagePath)
		{
		}

		public Enemy (string imagePath)
		{
			this.ImagePath = imagePath;
		}
	}
}

