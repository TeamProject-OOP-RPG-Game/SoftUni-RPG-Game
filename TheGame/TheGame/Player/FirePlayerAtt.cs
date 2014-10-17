using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.Player
{
    class FirePlayerAtt:FirePlayer, IAttack
    {
        private const string DefaultFireAttPlayerImagePath = "..//..//images/player.png";

        public FirePlayerAtt()
            : this(DefaultFireAttPlayerImagePath)
		{
		}

        public FirePlayerAtt(string imagePath)
		{
			this.ImagePath = imagePath;
		}
    }
}
