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
            string menuSelector;
            Character Player = new Character();
            int playerInput = 0;
            switch(Player.GetMenu())
            {
                default:
                case MENUS.MMAIN:
                    Player.MenuMain();
                    break;
                case MENUS.MDEC:
                    Player.MenuDecimal();
                    break;
            }
            menuSelector = Console.ReadLine();
            if (menuSelector == "1")
            {
            }
            else if (menuSelector == "2")
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
            else if (menuSelector == "3")
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
            else if (menuSelector == "4")
            {
                Console.Clear();
                Console.WriteLine("You are now in the Logic Gate Solver section.\nEnter a logic gate problem to be solved.");
                Console.WriteLine();
                Console.WriteLine("Input:");
                Console.ReadLine();
            }
            else if (menuSelector == "5")
            {
                Console.Clear();
                Console.ReadKey();
            }
            else if (menuSelector == "0")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid input!");
                Console.ReadKey();
            }
        }
    }
}
