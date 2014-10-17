using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.Player
{
    class WaterPlayerDeff:WaterPlayer, IDeffence
    {
        private const string DefaultWaterDeffPlayerImagePath = "..//..//images/player.png";

        public WaterPlayerDeff()
            : this(DefaultWaterDeffPlayerImagePath)
		{
		}

        public WaterPlayerDeff(string imagePath)
		{
			this.ImagePath = imagePath;
		}
    }
}
