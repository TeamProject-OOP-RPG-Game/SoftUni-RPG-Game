using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.Enemy
{
    class AirEnemyAtt:AirEnemy, IAttack
    {
        private const string DefaultAirEnemyAttImagePath = "..//..//images/player.png";

        public AirEnemyAtt()
            : this(DefaultAirEnemyAttImagePath)
		{
		}

        public AirEnemyAtt(string imagePath)
		{
			this.ImagePath = imagePath;
		}
    }
}
