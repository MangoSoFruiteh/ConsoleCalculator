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
                    case MENUS.MDEC1:
                        Player.MenuDecimalExpression();
                        break;
                    case MENUS.MDEC2:
                        Player.MenuDecimalBinary();
                        break;
                    case MENUS.MDEC3:
                        Player.MenuDecimalHexadecimal();
                        break;
                    case MENUS.MBIN1:
                        Player.MenuBinaryExpression();
                        break;
                    case MENUS.MBIN2:
                        Player.MenuBinaryDecimal();
                        break;
                    case MENUS.MBIN3:
                        Player.MenuBinaryHexadecimal();
                        break;
                    case MENUS.MHEX1:
                        Player.MenuHexadecimalExpression();
                        break;
                    case MENUS.MHEX2:
                        Player.MenuHexadecimalBinary();
                        break;
                    case MENUS.MHEX3:
                        Player.MenuHexadecimalDecimal();
                        break;
                }
            }
            Pause();
        }
    }
}
