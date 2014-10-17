using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.Player
{
    class AirPlayerDeff:AirPlayer
    {
        private const string DefaultAirDeffPlayerImagePath = "..//..//images/player.png";

        public AirPlayerDeff()
            : this(DefaultAirDeffPlayerImagePath)
		{
		}

        public AirPlayerDeff(string imagePath)
		{
			this.ImagePath = imagePath;
		}
    }
}
