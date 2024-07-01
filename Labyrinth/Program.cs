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
    public class Program
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
                    TypeWriter("You wake up on a pile of leaves");
                    TypeWriter("\"Where am I?\" you say");
                    TypeWriter("As you look around you realise you are in some kind of maze");
                    TypeWriter("You can go in one of 4 directions");

                    isFirstTime = false;
                }
                else
                {
                    TypeWriter("You arrive in an area with leaves on the ground");
                    TypeWriter("\"Wait!\" You say, \"I've already been here! \"");
                    TypeWriter("You have arrived back at the beginning");
                    TypeWriter("Where will you go next, "+ userName + "?");
                }
                TypeWriter("Choose a path: (left/right/back/forward/exit/inv)");

                string userChoice = Console.ReadLine().ToLower();

                switch (userChoice)
                {
                    case "left":
                        left(userName);
                        break;

                    case "right":
                        right(userName);
                        break;

                    case "exit":
                        continuePlaying = false;
                        break;

                    default:
                        TypeWriter("Invalid choice. Please choose a valid path, type 'inv' to check your inventory, or 'exit' to quit the game.");
                        break;
                }
            }

            TypeWriter("Thank you for playing! Goodbye.");
        }

        static void left(string userName)
        {
            TypeWriter("You head to the left");

            bool choice1Made = false;

            while (choice1Made == false) 
            {
                TypeWriter("There is a skeleton lying on the ground. Would you like to search it? (yes/no)");
                string choice = Console.ReadLine().ToLower();

                if (choice == "yes")
                {
                    TypeWriter("You look inside the skeleton");
                    TypeWriter("There is nothing there!");
                    TypeWriter("Now you feel bad...");
                    choice1Made = true;
                }
                else if (choice == "no") 
                {
                    TypeWriter("It wouldn't feel right to disrespect the dead like that");
                    TypeWriter("You continue ahead...");
                    choice1Made= true;
                }
                else
                {
                    TypeWriter("Invalid answer, please try again");
                }
            }

   

            
            TypeWriter("\"Help!\" you hear somebody shout");
            TypeWriter("You run towards the sound");
            TypeWriter("As you turn around the corner you see a man cornered by a lion");
            TypeWriter("You notice a stick nearby, would you like to try to fight the lion? (yes/no)");

            string choice2 = Console.ReadLine().ToLower();

            if (choice2 == "yes")
            {   

                bool choice3made = false;

                TypeWriter("You whack the lion on the head as hard as you can");
                TypeWriter("The lion runs away");
                TypeWriter("You see the man lying on the ground");

                while (choice3made == false)
                {
                  
                    TypeWriter("Would you like to talk to him? (yes/no)");
                    string choice3 = Console.ReadLine().ToLower();

                    if (choice3 == "yes")
                    {
                        TypeWriter("You go to speak to the man");
                        TypeWriter("\"Hello\", you say. \"I am " + userName + "\"");
                        TypeWriter("...");
                        TypeWriter("The man is dead");
                        TypeWriter("Well that was a huge waste of time");
                        TypeWriter("You walk around the corner...");
                        choice3made = true;
                    }

                    else if (choice3 == "no")
                    {
                        TypeWriter("You decide to leave the man alone");
                        TypeWriter("You walk around the corner...");
                        choice3made= true;
                    }

                    else
                    {
                        TypeWriter("Invalid answer, please try again");
                    }
                }
                
            }
            else
            {
                TypeWriter("You leave the man to die");
                TypeWriter("You monster");
                TypeWriter("You turn around a corner...");
            }
        }

        static void right(string userName)
        {
            
        }

        static void TypeWriter(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(0);
            }

            Thread.Sleep(0);
            Console.WriteLine();
        }
    }
}
