using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.Player
{
    class WaterPlayerAtt:WaterPlayer, IAttack
    {
        private const string DefaultWaterAttPlayerImagePath = "..//..//images/player.png";

        public WaterPlayerAtt()
            : this(DefaultWaterAttPlayerImagePath)
		{
		}

        public WaterPlayerAtt(string imagePath)
		{
			this.ImagePath = imagePath;
		}
    }
}
