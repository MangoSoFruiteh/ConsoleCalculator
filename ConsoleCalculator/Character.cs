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
        string menuSelector;
        int playerInput;
        protected MENUS menu;
        //Getters
        public MENUS GetMenu()
        {
            return menu;
        }
        //Menus
        public void MenuMain()
        {
            Console.WriteLine("Welcome to Console Calculator! What can I do for you today?");
            Console.WriteLine();
            Console.WriteLine("[1] Decimal Math");
            Console.WriteLine("[2] Binary Math");
            Console.WriteLine("[3] Hexadecimal Math");
            Console.WriteLine("[4] Logic Gate Solver");
            Console.WriteLine("[5] Shooter/Target Solver");
            Console.WriteLine();
            Console.WriteLine("[0] Close Console Calculator");
        }

        public void MenuDecimal()
        {
            Console.Clear();
            Console.WriteLine("You are now in the Decimal Math section. Select an option below.");
            Console.WriteLine();
            Console.WriteLine("[1] Enter Expressions");
            Console.WriteLine("[2] Decimal to Binary Conversion");
            Console.WriteLine("[3] Decimal to Hexadecimal Conversion");
            Console.WriteLine();
            Console.WriteLine("[~] Back to Main Menu");
            menuSelector = Console.ReadLine();
            if (menuSelector == "1")
            {
                Console.Clear();
                Console.WriteLine("Enter expressions below:");
                Console.WriteLine();
                Console.ReadLine();
                //playerInput = EvaluateExpression(math);
                //Console.WriteLine(playerInput);
            }
            if (menuSelector == "2")
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
            if (menuSelector == "3")
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
            else
            {
                Console.WriteLine("Invalid input!");
                Console.ReadKey();
            }
            Console.ReadKey();
        }

        public void MenuBinary()
        {
            Console.Clear();
            Console.WriteLine("You are now in the Binary Math section. Select an option below.");
            Console.WriteLine();
            Console.WriteLine("[1] Enter Expressions");
            Console.WriteLine("[2] Binary to Decimal Conversion");
            Console.WriteLine("[3] Binary to Hexadecimal Conversion");
            Console.WriteLine();
            Console.WriteLine("[~] Back to Main Menu");
            menuSelector = Console.ReadLine();
            if (menuSelector == "1")
            {
                Console.Clear();
                Console.WriteLine("Enter expressions below:");
                Console.WriteLine();
                Console.ReadLine();
                //playerInput = EvaluateExpression(math);
                //Console.WriteLine(playerInput);
            }
            if (menuSelector == "2")
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
            if (menuSelector == "3")
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
            else
            {
                Console.WriteLine("Invalid input!");
                Console.ReadKey();
            }
            Console.ReadKey();
        }

        public void MenuHexadecimal()
        {
            Console.Clear();
            Console.WriteLine("You are now in the Hexadecimal Math section. Select an option below.");
            Console.WriteLine();
            Console.WriteLine("[1] Enter Expressions");
            Console.WriteLine("[2] Hexadecimal to Binary Conversion");
            Console.WriteLine("[3] Hexadecimal to Decimal Conversion");
            Console.WriteLine();
            Console.WriteLine("[~] Back to Main Menu");
            menuSelector = Console.ReadLine();
            if (menuSelector == "1")
            {
                Console.Clear();
                Console.WriteLine("Enter expressions below:");
                Console.WriteLine();
                Console.ReadLine();
                //playerInput = EvaluateExpression(math);
                //Console.WriteLine(playerInput);
            }
            if (menuSelector == "2")
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
            if (menuSelector == "3")
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
            else
            {
                Console.WriteLine("Invalid input!");
                Console.ReadKey();
            }
            Console.ReadKey();
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
    
    }
}
