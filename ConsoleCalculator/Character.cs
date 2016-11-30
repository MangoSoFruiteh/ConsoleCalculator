using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleCalculator.Helper;

namespace ConsoleCalculator
{
    class Character
    {
        int playerInput;
        protected MENUS menu;

        //Getters
        public MENUS GetMenu()
        {
            return menu;
        }

        //Setters
        public void SetMenu(MENUS newMen)
        {
            menu = newMen;
        }

        //Menus
        public void MenuMain()
        {
            char menuItem;
            Console.Clear();
            Console.WriteLine("Welcome to Console Calculator! What can I do for you today?");
            Console.WriteLine();
            Console.WriteLine("[1] Decimal Math");
            Console.WriteLine("[2] Binary Math");
            Console.WriteLine("[3] Hexadecimal Math");
            Console.WriteLine("[4] Logic Gate Solver");
            Console.WriteLine("[5] Shooter/Target Solver");
            Console.WriteLine();
            Console.WriteLine("[0] Close Console Calculator");

            menuItem = char.ToLower(Console.ReadKey().KeyChar);
            switch(menuItem)
            {
                case '1':
                    menu = MENUS.MDEC;
                    break;
                case '2':
                    menu = MENUS.MBIN;
                    break;
                case '3':
                    menu = MENUS.MHEX;
                    break;
                case '4':
                    menu = MENUS.MLGS;
                    break;
                case '5':
                    menu = MENUS.MSTS;
                    break;
                case '0':
                    Environment.Exit(0);
                    break;
            }
        }

        public void MenuDecimal()
        {
            bool oktogo = false;
            char menuItem;
            while(!oktogo)
            {
                oktogo = true;
                Console.Clear();
                Console.WriteLine("You are now in the Decimal Math section. Select an option below.");
                Console.WriteLine();
                Console.WriteLine("[1] Enter Expressions");
                Console.WriteLine("[2] Decimal to Binary Conversion");
                Console.WriteLine("[3] Decimal to Hexadecimal Conversion");
                Console.WriteLine();
                Console.WriteLine("[~] Back to Main Menu");

                menuItem = char.ToLower(Console.ReadKey().KeyChar);
                switch (menuItem)
                {
                    case '1':
                        menu = MENUS.MDEC1;
                        break;
                    case '2':
                        menu = MENUS.MDEC2;
                        break;
                    case '3':
                        menu = MENUS.MDEC3;
                        break;
                }
            }
        }

        public void MenuBinary()
        {
            bool oktogo = false;
            char menuItem;
            while (!oktogo)
            {
                oktogo = true;
                Console.Clear();
                Console.WriteLine("You are now in the Binary Math section. Select an option below.");
                Console.WriteLine();
                Console.WriteLine("[1] Enter Expressions");
                Console.WriteLine("[2] Binary to Decimal Conversion");
                Console.WriteLine("[3] Binary to Hexadecimal Conversion");
                Console.WriteLine();
                Console.WriteLine("[~] Back to Main Menu");

                menuItem = char.ToLower(Console.ReadKey().KeyChar);
                switch (menuItem)
                {
                    case '1':
                        menu = MENUS.MBIN1;
                        break;
                    case '2':
                        menu = MENUS.MBIN2;
                        break;
                    case '3':
                        menu = MENUS.MBIN3;
                        break;
                }
            }
        }

        public void MenuHexadecimal()
        {
            bool oktogo = false;
            char menuItem;
            while (!oktogo)
            {
                oktogo = true;
                Console.Clear();
                Console.WriteLine("You are now in the Hexadecimal Math section. Select an option below.");
                Console.WriteLine();
                Console.WriteLine("[1] Enter Expressions");
                Console.WriteLine("[2] Hexadecimal to Binary Conversion");
                Console.WriteLine("[3] Hexadecimal to Decimal Conversion");
                Console.WriteLine();
                Console.WriteLine("[~] Back to Main Menu");

                menuItem = char.ToLower(Console.ReadKey().KeyChar);
                switch (menuItem)
                {
                    case '1':
                        menu = MENUS.MHEX1;
                        break;
                    case '2':
                        menu = MENUS.MHEX2;
                        break;
                    case '3':
                        menu = MENUS.MHEX3;
                        break;
                }
            }
        }

        public void MenuLogicGate()
        {
            Console.Clear();
            Console.WriteLine("You are now in the Logic Gate Solver section.\nEnter a logic gate problem to be solved.");
            Console.WriteLine();
            Console.WriteLine("Input:");
            Console.ReadLine();
        }

        public void MenuShooterTarget()
        {
            Console.Clear();
            Console.ReadKey();
        }

        public void MenuDecimalExpression()
        {
            Console.Clear();
            Console.WriteLine("Enter expressions below:");
            Console.WriteLine();
            Console.ReadLine();
            //playerInput = EvaluateExpression(math);
            //Console.WriteLine(playerInput);
        }

        public void MenuDecimalBinary()
        {
            Console.Clear();
            Console.WriteLine("Enter decimal number below.");
            Console.WriteLine();
            Console.WriteLine("Input:");
            playerInput = Convert.ToInt32(Console.ReadLine());
            string playerAnswer = Convert.ToString(playerInput, 2);
            Console.WriteLine("Answer:");
            Console.WriteLine(playerAnswer);
            Console.ReadKey();
        }

        public void MenuDecimalHexadecimal()
        {
            Console.Clear();
            Console.WriteLine("Enter decimal number below.");
            Console.WriteLine();
            Console.WriteLine("Input:");
            playerInput = Convert.ToInt32(Console.ReadLine());
            string playerAnswer = Convert.ToString(playerInput, 16);
            Console.WriteLine("Answer:");
            Console.WriteLine(playerAnswer);
            Console.ReadKey();
        }

        public void MenuBinaryExpression()
        {
            Console.Clear();
            Console.WriteLine("Enter expressions below:");
            Console.WriteLine();
            Console.ReadLine();
            //playerInput = EvaluateExpression(math);
            //Console.WriteLine(playerInput);
        }

        public void MenuBinaryDecimal()
        {
            Console.Clear();
            Console.WriteLine("Enter binary number below.");
            Console.WriteLine();
            Console.WriteLine("Input:");
            playerInput = Convert.ToInt32(Console.ReadLine());
            string playerAnswer = Convert.ToString(playerInput, 10);
            Console.WriteLine("Answer:");
            Console.WriteLine(playerAnswer);
            Console.ReadKey();
        }

        public void MenuBinaryHexadecimal()
        {
            Console.Clear();
            Console.WriteLine("Enter binary number below.");
            Console.WriteLine();
            Console.WriteLine("Input:");
            playerInput = Convert.ToInt32(Console.ReadLine());
            string playerAnswer = Convert.ToString(playerInput, 16);
            Console.WriteLine("Answer:");
            Console.WriteLine(playerAnswer);
            Console.ReadKey();
        }

        public void MenuHexadecimalExpression()
        {
            Console.Clear();
            Console.WriteLine("Enter expressions below:");
            Console.WriteLine();
            Console.ReadLine();
            //playerInput = EvaluateExpression(math);
            //Console.WriteLine(playerInput);
        }

        public void MenuHexadecimalBinary()
        {
            Console.Clear();
            Console.WriteLine("Enter hexadecimal number below.");
            Console.WriteLine();
            Console.WriteLine("Input:");
            playerInput = Convert.ToInt32(Console.ReadLine());
            string playerAnswer = Convert.ToString(playerInput, 2);
            Console.WriteLine("Answer:");
            Console.WriteLine(playerAnswer);
            Console.ReadKey();
        }

        public void MenuHexadecimalDecimal()
        {
            Console.Clear();
            Console.WriteLine("Enter hexadecimal number below.");
            Console.WriteLine();
            Console.WriteLine("Input:");
            playerInput = Convert.ToInt32(Console.ReadLine());
            string playerAnswer = Convert.ToString(playerInput, 10);
            Console.WriteLine("Answer:");
            Console.WriteLine(playerAnswer);
            Console.ReadKey();
        }
    }
}
