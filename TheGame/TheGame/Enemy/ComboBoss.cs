using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.Enemy
{
    class ComboBoss:Boss, IBossAttack, IBossDeffence
    {
        private const string DefaultComboBossImagePath = "..//..//images/player.png";

        public ComboBoss()
            : this(DefaultComboBossImagePath)
		{
		}

        public ComboBoss(string imagePath)
		{
			this.ImagePath = imagePath;
		}
    }
}
