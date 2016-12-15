using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ConsoleCalculator
{
    class Character : Helper
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
            string date = DateTime.Today.ToShortDateString();
            Console.WriteLine("Welcome to Console Calculator!\nThe current date is: " + date + "\n\nWhat can I do for you today?");
            Console.WriteLine();
            Console.WriteLine("[1] Math Expression");
            Console.WriteLine("[2] Base Conversions");
            Console.WriteLine("[3] Logic Gate Solver");
            Console.WriteLine("[4] Shooter/Target Solver");
            Console.WriteLine();
            Console.WriteLine("[0] Close Console Calculator");

            menuItem = char.ToLower(Console.ReadKey().KeyChar);
            switch(menuItem)
            {
                case '1':
                    menu = MENUS.MDEC;
                    break;
                case '2':
                    menu = MENUS.MCON;
                    break;
                case '3':
                    menu = MENUS.MLGS;
                    break;
                case '4':
                    menu = MENUS.MSTS;
                    break;
                case '0':
                    Environment.Exit(0);
                    break;
            }
        }

        public void MenuConversions()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Base Conversions!");
            Console.WriteLine();
            Console.WriteLine("Enter converting FROM base:");
            int fromBase = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter converting TO base:");
            int toBase = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter conversion number below.");
            Console.WriteLine();
            Console.WriteLine("Input:");
            playerInput = Convert.ToInt32(Console.ReadLine(), fromBase);
            string playerAnswer = Convert.ToString(playerInput, toBase);
            Console.WriteLine("Output:");
            Console.WriteLine(playerAnswer);
            Console.ReadKey();
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
                    case '`':
                        menu = MENUS.MMAIN;
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
                    case '`':
                        menu = MENUS.MMAIN;
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
                    case '`':
                        menu = MENUS.MMAIN;
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
            Console.WriteLine("Welcome to the Shooter/Target Solver!");
            Console.WriteLine();
            Console.WriteLine("Please enter the cliff height:");
            double cliffHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Please enter the ground length:");
            double groundLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Please enter shooter barrel height:");
            Console.WriteLine("(Subtract TEMP from shooter height)");
            double barrelHeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Please enter target headshot height:");
            Console.WriteLine("(Subtract 0.5' from target height)");
            double headshotHeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            double triangleHeight = (cliffHeight + headshotHeight) - barrelHeight;
            double tanAngle = Math.Atan(triangleHeight/groundLength);
            Console.Clear();
            Console.WriteLine("These are the numbers you gave me:");
            Console.WriteLine();
            Console.WriteLine("Cliff Height: " + cliffHeight);
            Console.WriteLine("Ground Length: " + groundLength);
            Console.WriteLine("Barrel Height: " + barrelHeight);
            Console.WriteLine("Headshot Height: " + headshotHeight);
            Console.WriteLine("Triangle Height: " + triangleHeight);
            Console.WriteLine("Angle: " + tanAngle);
            Console.ReadKey();
        }

        public void MenuDecimalExpression()
        {
            bool oktogo = false;
            while (!oktogo)
            {
                Console.Clear();
                Console.WriteLine("Enter expressions below:\nType ESC to go back.");
                Console.WriteLine();
                string playerInput2 = Console.ReadLine();
                if (playerInput2 == "ESC")
                {
                    oktogo = true;
                    menu = MENUS.MDEC;
                }
                else
                {
                    DataTable table = new DataTable();
                    var answer = table.Compute(playerInput2, "");
                    Console.WriteLine(answer);
                    Console.ReadKey();
                }
            }
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
            Console.WriteLine("Binary:");
            playerInput = Convert.ToInt32(Console.ReadLine(), 2);
            Console.WriteLine("Decimal:");
            Console.Write(playerInput);
            Console.ReadKey();
        }

        public void MenuBinaryHexadecimal()
        {
            Console.Clear();
            Console.WriteLine("Enter binary number below.");
            Console.WriteLine();
            Console.WriteLine("Binary:");
            playerInput = Convert.ToInt32(Console.ReadLine(), 2);
            string playerAnswer = Convert.ToString(playerInput, 16);
            Console.WriteLine("Hexadecimal:");
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
            Console.WriteLine("Hexadecimal:");
            playerInput = Convert.ToInt32(Console.ReadLine(), 16);
            string playerAnswer = Convert.ToString(playerInput, 2);
            Console.WriteLine("Binary:");
            Console.WriteLine(playerAnswer);
            Console.ReadKey();
        }

        public void MenuHexadecimalDecimal()
        {
            Console.Clear();
            Console.WriteLine("Enter hexadecimal number below.");
            Console.WriteLine();
            Console.WriteLine("Hexadecimal:");
            playerInput = Convert.ToInt32(Console.ReadLine(), 16);
            string playerAnswer = Convert.ToString(playerInput, 10);
            Console.WriteLine("Decimal:");
            Console.WriteLine(playerAnswer);
            Console.ReadKey();
        }
    }
}
