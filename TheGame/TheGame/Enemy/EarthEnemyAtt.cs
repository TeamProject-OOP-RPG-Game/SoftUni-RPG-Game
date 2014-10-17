using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.Enemy
{
    class EarthEnemyAtt:EarthEnemy, IAttack
    {
        private const string DefaultEarthEnemyAttImagePath = "..//..//images/player.png";

        public EarthEnemyAtt()
            : this(DefaultEarthEnemyAttImagePath)
		{
		}

        public EarthEnemyAtt(string imagePath)
		{
			this.ImagePath = imagePath;
		}
    }
}
