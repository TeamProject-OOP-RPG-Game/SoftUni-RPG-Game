using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.Enemy
{
    class WaterEnemyAtt:WaterEnemy, IAttack
    {
        private const string DefaultWaterEnemyAttImagePath = "..//..//images/player.png";

        public WaterEnemyAtt()
            : this(DefaultWaterEnemyAttImagePath)
		{
		}

        public WaterEnemyAtt(string imagePath)
		{
			this.ImagePath = imagePath;
		}
    }
}
