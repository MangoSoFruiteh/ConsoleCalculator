using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleCalculator.Helper;


namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            Character Player = new Character();
            while(!quit)
            {
                switch (Player.GetMenu())
                {
                    default:
                    case MENUS.MMAIN:
                        Player.MenuMain();
                        break;
                    case MENUS.MDEC:
                        Player.MenuDecimal();
                        break;
                    case MENUS.MBIN:
                        Player.MenuBinary();
                        break;
                    case MENUS.MHEX:
                        Player.MenuHexadecimal();
                        break;
                    case MENUS.MLGS:
                        Player.MenuLogicGate();
                        break;
                    case MENUS.MSTS:
                        Player.MenuShooterTarget();
                        break;
                }
            }
            Pause();
        }
    }
}
