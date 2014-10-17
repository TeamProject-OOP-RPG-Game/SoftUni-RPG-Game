using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.Enemy
{
    class FireBoss:Boss, IBossAttack, IBossDeffence
    {
        private const string DefaultFireBossImagePath = "..//..//images/player.png";

        public FireBoss()
            : this(DefaultFireBossImagePath)
		{
		}

        public FireBoss(string imagePath)
		{
			this.ImagePath = imagePath;
		}
    }
}
