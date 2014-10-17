using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.Enemy
{
    class EarthEnemyDeff:EarthEnemy, IDeffence
    {
        private const string DefaultEarthEnemyDeffImagePath = "..//..//images/player.png";

        public EarthEnemyDeff()
            : this(DefaultEarthEnemyDeffImagePath)
		{
		}

        public EarthEnemyDeff(string imagePath)
		{
			this.ImagePath = imagePath;
		}
    }
}
