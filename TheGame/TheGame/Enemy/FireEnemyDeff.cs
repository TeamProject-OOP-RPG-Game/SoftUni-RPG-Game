using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.Enemy
{
    class FireEnemyDeff:FireEnemy, IDeffence
    {
        private const string DefaultFireEnemyDeffImagePath = "..//..//images/player.png";

        public FireEnemyDeff()
            : this(DefaultFireEnemyDeffImagePath)
		{
		}

        public FireEnemyDeff(string imagePath)
		{
			this.ImagePath = imagePath;
		}
    }
}
