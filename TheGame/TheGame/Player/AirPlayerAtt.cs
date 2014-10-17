using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.Player
{
    class AirPlayerAtt:AirPlayer,IAttack
    {
        private const string DefaultAirAttPlayerImagePath = "..//..//images/player.png";

        public AirPlayerAtt()
            : this(DefaultAirAttPlayerImagePath)
		{
		}

        public AirPlayerAtt(string imagePath)
		{
			this.ImagePath = imagePath;
		}
    }
}
