﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Helper
    {
        public enum MENUS {MMAIN, MDEC, MBIN, MHEX, MLGS, MSTS, MDEC1, MDEC2, MDEC3, MBIN1, MBIN2, MBIN3, MHEX1, MHEX2, MHEX3, MCON}

        public static void Pause()
        {
            Console.ReadKey();
        }
    }
}
