﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.Enemy
{
    class WaterEnemyDeff:WaterEnemy, IDeffence
    {
        private const string DefaultWaterEnemyDeffImagePath = "..//..//images/player.png";

        public WaterEnemyDeff()
            : this(DefaultWaterEnemyDeffImagePath)
		{
		}

        public WaterEnemyDeff(string imagePath)
		{
			this.ImagePath = imagePath;
		}
    }
}