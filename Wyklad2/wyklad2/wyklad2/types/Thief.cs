﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyklad2.types
{
    class Thief : Player
    {
        protected int energy;
        protected override int damageCount()
        {
            return 15;
        }
    }
}
