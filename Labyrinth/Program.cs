using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using static System.Net.Mime.MediaTypeNames;

namespace Labyrinth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(1920,1080);
            

            Console.ForegroundColor
               = ConsoleColor.Yellow;

            try
            {
                using StreamReader sr = new StreamReader("Labyrinth Title.txt");

                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }


            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();

            }

            Console.ForegroundColor
               = ConsoleColor.Gray;


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            TypeWriter("Welcome to my text adventure!");
            TypeWriter("What would you like your character's name to be?");
            string userName = Console.ReadLine();
            TypeWriter("Hello " + userName + ", your adventure begins now!");

            StartGame(userName);


        }

        static void StartGame(string userName)
        {
            bool continuePlaying = true;
            bool isFirstTime = true;

            while (continuePlaying)
            {
                if (isFirstTime)
                {
                    TypeWriter("You wake up on a pile of leaves,");
                    isFirstTime = false;
                }
                else
                {
                    TypeWriter("You arrive in an area with leaves on the ground");
                    TypeWriter("\"Wait!\" You say, \"I've already been here! \"");
                    TypeWriter("You have arrived back at the beginning");
                    TypeWriter("What will you do next, "+ userName + "?");
                }
                TypeWriter("Choose a path: (left/right/back/forward/exit/inv)");

                string userChoice = Console.ReadLine().ToLower();

                switch (userChoice)
                {
                    case "left":
                        left();
                        break;

                    case "right":
                        right();
                        break;

                    case "back":
                        back();
                        break;

                    case "forward":
                        forward();
                        break;

                    default:
                        TypeWriter("Invalid choice. Please choose a valid path, type 'inv' to check your inventory, or 'exit' to quit the game.");
                        break;
                }
            }

            TypeWriter("Thank you for playing! Goodbye.");
        }

        static void TypeWriter(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(50);
            }
            Console.WriteLine();
        }
    }
}
