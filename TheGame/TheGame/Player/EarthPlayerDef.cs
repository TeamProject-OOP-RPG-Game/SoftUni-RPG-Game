using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.Player
{
    class EarthPlayerDef:EarthPlayer, IDeffence
    {
        private const string DefaultEartDefPlayerImagePath = "..//..//images/player.png";

        public EarthPlayerDef()
            : this(DefaultEartDefPlayerImagePath)
		{
		}

        public EarthPlayerDef(string imagePath)
		{
			this.ImagePath = imagePath;
		}
    }
}
