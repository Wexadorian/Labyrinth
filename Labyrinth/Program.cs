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
        static string[] items = { "Key", "Dagger", "Treasure" };
        static bool[] itemAvailability = { false, false, false };

        static void Main(string[] args)
        {

            Console.SetWindowSize(1920, 1080);

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
            bool afterPath = false;

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

                if (afterPath)
                {
                    TypeWriter("You arrive in an area with leaves on the ground");
                    TypeWriter("\"Wait!\" You say, \"I've already been here!\"");
                    TypeWriter("You have arrived back at the beginning");
                    TypeWriter("Where will you go next, " + userName + "?");

                }

                else 
                {
                    TypeWriter("Which way will you go, " + userName + "?");
                }

                TypeWriter("Choose a path: (left/right/back/forward/exit/inv)");

                string userChoice = Console.ReadLine().ToLower();

                switch (userChoice)
                {
                    case "left":
                        left(userName);
                        afterPath = true;
                        break;

                    case "forward":
                        forward(userName);
                        afterPath = true;
                        break;

                    case "right":
                        right(userName);
                        break;

                    case "inv":
                        ShowInventory();
                        afterPath = false;
                        break;

                    case "exit":
                        continuePlaying = false;
                        break;

                    default:
                        TypeWriter("Invalid choice. Please choose a valid path, type 'inv' to check your inventory, or 'exit' to quit the game.");
                        isFirstTime = true;
                        break;

                }

            }

            TypeWriter("Thank you for playing! Goodbye.");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue. . .");
            Console.ReadKey();
        }

        static void left(string userName)
        {
            TypeWriter("You head to the left");
            bool choice1Made = false;
            while (choice1Made == false)
            {
                TypeWriter("You notice a dagger lying on the ground next to a skeleton, would you like to grab it? (yes/no)");
                string choice = Console.ReadLine().ToLower();

                if (choice == "yes")
                {
                    TypeWriter("You grab the dagger off of the ground");
                    itemAvailability[1] = true;
                    TypeWriter("Inventory updated."); ;
                    choice1Made = true;
                }

                else if (choice == "no")
                {
                    TypeWriter("You don't feel like having a weapon is a good idea");
                    TypeWriter("You continue ahead...");
                    choice1Made = true;
                }

                else
                {
                    TypeWriter("Invalid answer, please try again");
                }

            }

            TypeWriter("\"Help!\" you hear somebody shout");
            TypeWriter("You run towards the sound");
            TypeWriter("As you turn around the corner you see a man cornered by a lion");

            bool choice2Made = false;

            while (choice2Made == false)
            {
                TypeWriter("Would you like to try to fight the lion? (yes/no)");
                string choice2 = Console.ReadLine().ToLower();

                if (choice2 == "yes")
                {
                    bool choice3made = false;

                    if (itemAvailability[1] == true)
                    {
                        TypeWriter("You stab the lion with the dagger");
                        TypeWriter("The lion runs away, injured");
                        TypeWriter("You see the man lying on the ground");
                    }

                    else
                    {
                        TypeWriter("You try to fight the lion");
                        TypeWriter("You didn't have a weapon, so you die a horrible death");
                        TypeWriter("Game Over");
                        TypeWriter("Thanks for playing!");
                        Console.WriteLine("Press any key to continue. . .");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }

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
                            TypeWriter("That was a waste of time");
                            TypeWriter("You walk around the corner...");
                            choice3made = true;
                        }

                        else if (choice3 == "no")

                        {

                            TypeWriter("You decide to leave the man alone");

                            TypeWriter("You walk around the corner...");

                            choice3made = true;

                        }

                        else

                        {

                            TypeWriter("Invalid answer, please try again");

                        }

                    }



                    choice2Made = true;

                }

                else if (choice2 == "no")

                {

                    TypeWriter("You leave the man to die");

                    TypeWriter("You monster");

                    TypeWriter("You turn around a corner...");



                    choice2Made = true;

                }

                else

                {

                    TypeWriter("Invalid answer, please try again");

                }

            }

        }





        static void forward(string userName)

        {

            TypeWriter("You head directly forward");



            bool choice1Made = false;



            while (choice1Made == false)

            {

                TypeWriter("You see an old wooden door in front of you. Would you like to open it? (yes/no)");

                string choice = Console.ReadLine().ToLower();



                if (choice == "yes")

                {

                    TypeWriter("You slowly open the door, and it creaks loudly.");

                    TypeWriter("Inside, you find a dusty room filled with ancient books and scrolls.");

                    choice1Made = true;

                }

                else if (choice == "no")

                {

                    TypeWriter("You decide not to open the door and continue walking.");



                    choice1Made = true;

                }

                else

                {

                    TypeWriter("Invalid answer, please try again.");

                }

            }



            TypeWriter("As you proceed, you hear a faint whispering sound.");



            bool choice2Made = false;


           
            while (choice2Made == false)

            {

                TypeWriter("Would you like to follow the whispering sound? (yes/no)");

                string choice2 = Console.ReadLine().ToLower();



                if (choice2 == "yes")

                {

                    TypeWriter("You follow the whispering and find a hidden passage behind a tapestry.");

                    TypeWriter("You enter the passage and find a glowing key on a pedestal.");

                    TypeWriter("You take the key");

                    TypeWriter("This feels... important");

                    itemAvailability[0] = true;

                    TypeWriter("Inventory updated.");



                    choice2Made = true;



                }

                else if (choice2 == "no")

                {

                    TypeWriter("You ignore the whispering and continue forward.");

                    TypeWriter("You feel like you might have missed something important");

                    TypeWriter("You come across a large hall filled with treasure chests.");

                    TypeWriter("You look inside one");

                    TypeWriter("...It's empty");

                    TypeWriter("This seems to be a storage room of some sort");



                    choice2Made = true;

                }

                else

                {

                    TypeWriter("Invalid answer, please try again.");

                }

            }



            TypeWriter("Suddenly, you hear a loud roar.");



            bool choice3Made = false;



            while (choice3Made == false)
            {

                if (itemAvailability[1] == true)
                {

                    TypeWriter("\"Hey! Over here!\" you hear somebody shout");
                    TypeWriter("You look in the direction of the sound");
                    TypeWriter("You see an old man hobbling towards you");
                    TypeWriter("What would you like to do? (ignore/talk/stab)");

                    string choice3 = Console.ReadLine().ToLower();



                    if (choice3 == "ignore")

                    {

                        TypeWriter("You choose to ignore the man");

                        TypeWriter("\"Wait!\" you hear him shout as you walk the other way");

                        TypeWriter("You turn around a corner");

                        choice3Made = true;

                    }

                    else if (choice3 == "talk")

                    {

                        TypeWriter("You decide to talk to the man");

                        TypeWriter("");

                        TypeWriter("");

                        choice3Made = true;

                    }

                    else if (choice3 == "stab")

                    {

                        TypeWriter("You stab the man in the stomach with the dagger in your inventory");

                        TypeWriter("Now why would you think that would be a good idea?");

                        TypeWriter("You leave the man dying on the floor with a dagger in his stomach");

                        itemAvailability[1] = false;

                        TypeWriter("Inventory Updated");

                        TypeWriter("You walk around the corner...");

                        choice3Made = true;

                    }

                    else

                    {

                        TypeWriter("Invalid answer, please try again.");

                    }


                }

                else
                {

                    TypeWriter("\"Hey! Over here!\" you hear somebody shout");
                    TypeWriter("You look in the direction of the sound");
                    TypeWriter("You see an old man hobbling towards you");
                    TypeWriter("What would you like to do? (ignore/talk)");

                    string choice3 = Console.ReadLine().ToLower();



                    if (choice3 == "ignore")

                    {

                        TypeWriter("You choose to ignore the man");

                        TypeWriter("\"Wait!\" you hear him shout as you walk the other way");

                        TypeWriter("You turn around a corner");

                        choice3Made = true;

                    }

                    else if (choice3 == "talk")

                    {

                        TypeWriter("You decide to talk to the man");

                        TypeWriter("");

                        TypeWriter("");

                        choice3Made = true;

                    }

                    else

                    {

                        TypeWriter("Invalid answer, please try again.");

                    }

                }
            }
        }



        static void right(string userName)

        {

            TypeWriter("You head to the right");

            TypeWriter("It is eerily quiet");

            TypeWriter("You walk down a long hallway");

            TypeWriter("...");

            TypeWriter("This is a VERY long hallway");

            TypeWriter("You finally get to a door");

            TypeWriter("You can hear a quiet humming behind it");

            TypeWriter("You try opening the door");





            if (itemAvailability[0] == true)
            {

                TypeWriter("...");

                TypeWriter("It's locked");

                TypeWriter("\"Oh wait\" you say, \"I have a key!\"");

                TypeWriter("You insert the key into the door");

            }



            else
            {

                TypeWriter("...");

                TypeWriter("It's locked, maybe you should try to find a key?");

                TypeWriter("You go back down the hallway");

            }

        }



        static void ShowInventory()

        {

            TypeWriter("Inventory:");



            for (int i = 0; i < items.Length; i++)

            {

                if (itemAvailability[i])

                {

                    TypeWriter(items[i] + " - Available");

                }



                else



                {

                    TypeWriter(items[i] + " - Not Available");

                }

            }

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

