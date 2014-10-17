using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.Player
{
    class FirePlayerDeff:FirePlayer, IDeffence
    {
        private const string DefaultFireDeffPlayerImagePath = "..//..//images/player.png";

        public FirePlayerDeff()
            : this(DefaultFireDeffPlayerImagePath)
		{
		}

        public FirePlayerDeff(string imagePath)
		{
			this.ImagePath = imagePath;
		}
    }
}
