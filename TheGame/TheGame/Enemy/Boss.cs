﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.Enemy
{
    abstract class Boss:Enemy
    {
        public Boss(int X, int Y, int SizeX, int SizeY)
            : base(X, Y, SizeX, SizeY) 
		{
		}
    }
}
