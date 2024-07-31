using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using static System.Net.Mime.MediaTypeNames;


namespace Labyrinth
{

    public class Program
    {

        

        static string[] items = { "Key", "Dagger", "Lantern" };

        static bool[] itemAvailability = { false, false, false };

        static bool rightFirstTime = true;

        static bool fateSealed = false;


        static void Main(string[] args)
        {

            Console.SetWindowSize(336, 189);
            Console.ForegroundColor = ConsoleColor.Yellow;
            


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



            Console.ForegroundColor = ConsoleColor.Gray;

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



            while (continuePlaying == true)

            {

                if (isFirstTime == true)

                {

                    TypeWriter("You wake up on a pile of leaves");

                    TypeWriter("\"Where am I?\" you say");

                    TypeWriter("As you look around you realise you are in some kind of maze");

                    TypeWriter("You can go in one of 4 directions");

                    isFirstTime = false;

                }



                if (afterPath == true)

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
                        afterPath = true;
                        left(userName);

                        

                        break;

                    case "forward":
                        afterPath = true;
                        forward(userName);

                        

                        break;

                    case "right":

                        right(userName);

                        break;

                    case "back":
                        afterPath = false;
                        back(userName);

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

                    TypeWriter("Inventory updated.");

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



            TypeWriter("\"Hey! Over here!\" you hear somebody shout");

            TypeWriter("You look in the direction of the sound");

            TypeWriter("You see an old man hobbling towards you");

            bool choice3Made = false;

            while (choice3Made == false)

            {

                if (itemAvailability[1] == true)

                {

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

                        TalkToMan();

                        choice3Made = true;

                    }

                    else if (choice3 == "stab")

                    {

                        TypeWriter("You stab the man in the stomach with the dagger in your inventory");

                        TypeWriter("Now why would you do that?");

                        TypeWriter("You leave the man dying on the floor with a dagger in his stomach");

                        fateSealed = true;

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

                        TalkToMan();

                        choice3Made = true;

                    }

                    else

                    {

                        TypeWriter("Invalid answer, please try again.");

                    }

                }

            }

        }

        static void back(string userName)
        {

            TypeWriter("You go to the path behind you");

            bool choice1Made = false;

            if (itemAvailability[2] == false)
            {
                TypeWriter("It's too dark to see anything");
                TypeWriter("Maybe you should try and find something to brighten up the path?");
                TypeWriter("You go back the way you came");
                
            }

            else
            {
                while (choice1Made == false)
                {
                    TypeWriter("You shine your lantern to brighten up the way");
                    TypeWriter("You notice some writing on the walls, would you like to look closer? (yes/no)");

                    string choice = Console.ReadLine().ToLower();

                    if (choice == "yes")
                    {

                        TypeWriter("You shine the lantern at the walls");
                        TypeWriter("The secret you seek lies hidden, guarded by murmurs in the shadows.");
                        
                        if (itemAvailability[0] == true)
                        {
                            TypeWriter("This seems to be referring to the key, which you have already found");
                        }

                        else
                        {
                            TypeWriter("You don't know what this is referring to, but you hope you find it soon");
                        }
                        
                       

                        choice1Made = true;

                    }

                    else if (choice == "no")
                    {

                        TypeWriter("The writing probably wasn't important anyways");
                        TypeWriter("You continue ahead...");

                        choice1Made = true;

                    }

                    else
                    {

                        TypeWriter("Invalid answer, please try again");

                    }

                    



                    TypeWriter("You notice some bats on the ceiling");



                    bool choice2Made = false;



                    while (choice2Made == false)

                    {

                        TypeWriter("You are feeling kind of hungry, would you like to catch and eat the bats? (yes/no)");

                        string choice2 = Console.ReadLine().ToLower();

                        if (choice2 == "yes")
                        {

                            TypeWriter("You try to catch and eat the bats");
                            TypeWriter(". . .");
                            TypeWriter("They fly away when they notice you coming");
                            TypeWriter("Now you feel stupid");
                            TypeWriter("You continue ahead");
                            choice2Made = true;

                        }

                        else if (choice2 == "no")
                        {
                            TypeWriter("You don't want to eat bat anyways");
                            TypeWriter("You continue ahead");
                            choice2Made = true;

                        }

                        else
                        {

                            TypeWriter("Invalid answer, please try again");

                        }


                    }

                    TypeWriter("You walk ahead for a little while");
                    TypeWriter("Eventually, you reach a dead end");
                    TypeWriter("You go back the way you came");


                }
            }
        }

        static void right(string userName)

        {

            if (rightFirstTime == true)

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

                    GameFinishSequence();

                    rightFirstTime = false;

                }

                else

                {

                    TypeWriter("...");

                    TypeWriter("It's locked, maybe you should try to find a key?");

                    TypeWriter("You go back down the hallway");

                    rightFirstTime = false;

                }

               

            }

            else

            {

                TypeWriter("You go back down the hallway");

                if (itemAvailability[0] == true)

                {

                    TypeWriter("You insert the key you found into the door");
                    GameFinishSequence();
                }

                else

                {

                    TypeWriter("...");

                    TypeWriter("The door is still locked");

                }

            }

        }

        static void GameFinishSequence()
        {
            TypeWriter("You turn the handle");
            TypeWriter("It's too dark to see anything");
            TypeWriter("You take a step through");

            if (fateSealed == true)
            {
                //string full of 'intentionally' corny one-liners
                string[] oneLiners = 
                {
                   "Looks like you’ve been... *outplayed*!",
                   "Did you think it was *game over*? Guess again!",
                   "You’ve just been served a *slice of revenge*!",
                   "Hope you’re ready for a *stab in the back*!",
                   "I guess you could say... you’ve been *skewered*!",
                   "Surprise! Here’s a little *twist* for you!",
                   "You thought you had the last laugh... *not quite*!",
                   "It’s a *painful plot twist* just for you!",
                   "Looks like you’ve just been *backstabbed*!",
                   "And with that, you’ve met your *gruesome end*!",
                   "Your story ends with a *painful surprise*!",
                   "Did you think you could *escape*? Think again!",
                   "Looks like your *final move* was a little off!",
                   "You’re about to experience a *stabbing revelation*!",
                   "Guess who’s got the last laugh now? *Me*!",
                   "Your journey ends with a *painful punctuation*!",
                   "You’ve just been *stabbed* with a side of drama!",
                   "How’s that for a *plot twist*? Painful, isn’t it?",
                   "I hope you enjoyed the ride... because it’s over!",
                   "You’ve been *backstabbed* and it’s a *wrap*!",
                   "You've been punked, labyrinth style!"
                };

                //selects a random one liner to output when needed
                Random random = new Random();
                int randomIndex = random.Next(oneLiners.Length);

                TypeWriter("Suddenly, you feel a sharp pain. The old man appears and stabs you in the back.");
                TypeWriter("With a smirk, he says, \"" + oneLiners[randomIndex] + "\"");
                TypeWriter("You collapse, realizing that you probably shouldn't have stabbed a defenseless old man just because you felt like it.");
                Console.WriteLine();
                TypeWriter("Game Over. Thank you for playing!");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue. . .");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                TypeWriter("You find yourself in a beautiful garden, safe at last.");
                TypeWriter("Congratulations, you've escaped the labyrinth!");
                TypeWriter("Thank you for playing!");
                
                Console.WriteLine();
                Console.WriteLine("Press any key to continue. . .");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

        static void TalkToMan()
        {

            TypeWriter("You decide to talk to the man.");

            TypeWriter("He looks at you with a mixture of fear and hope.");

            TypeWriter("\"Can you help me find a way out of this labyrinth?\" he asks.");



            if (rightFirstTime == false)

            {

                TypeWriter("\"I've been to the right,\" you say. \"There’s a door that might lead somewhere, but it’s locked. That might be worth checking out.\"");

                TypeWriter("\"Thank you for that,\" he says. \"I’ll check that direction. If you find anything else, please let me know.\"");

            }

            else

            {

                TypeWriter("\"I'm not sure where the exits are,\" you reply. \"I haven’t explored everywhere yet.\"");

                TypeWriter("\"Alright,\" the man says. \"I’ll keep searching. If you come across anything useful, please let me know.\"");

            }

            TypeWriter("\"Here\", the man says. \"Take this, I don't need it anymore\"");
            TypeWriter("The man hands you a lantern");
            itemAvailability[2] = true;
            TypeWriter("Inventory updated");
            TypeWriter("The man hurries off to continue his search.");

            TypeWriter("You go around the corner");

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

                Thread.Sleep(1);
                

            }

            Thread.Sleep(25);

            Console.WriteLine();

        }

    }

}

