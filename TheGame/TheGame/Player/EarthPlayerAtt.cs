using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.Player
{
    class EarthPlayerAtt: EarthPlayer, IAttack
    {
        private const string DefaultEartAttPlayerImagePath = "..//..//images/player.png";

        public EarthPlayerAtt()
            : this(DefaultEartAttPlayerImagePath)
		{
		}

        public EarthPlayerAtt(string imagePath)
		{
			this.ImagePath = imagePath;
		}
    }
}
