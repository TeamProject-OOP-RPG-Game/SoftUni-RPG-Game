using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.Enemy
{
    class FireEnemyAtt:FireEnemy, IAttack
    {
        private const string DefaultFireEnemyAttImagePath = "..//..//images/player.png";

        public FireEnemyAtt()
            : this(DefaultFireEnemyAttImagePath)
		{
		}

        public FireEnemyAtt(string imagePath)
		{
			this.ImagePath = imagePath;
		}
    }
}
