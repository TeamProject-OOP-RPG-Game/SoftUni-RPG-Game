using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.Enemy
{
    class AirEnemyDeff:AirEnemy, IDeffence
    {
        private const string DefaultEnemyDeffImagePath = "..//..//images/player.png";

        public AirEnemyDeff()
            : this(DefaultEnemyDeffImagePath)
		{
		}

        public AirEnemyDeff(string imagePath)
		{
			this.ImagePath = imagePath;
		}
    }
}
