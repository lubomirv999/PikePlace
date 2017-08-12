using Pike_Place.Heroes;
using Pike_Place.Levels;
using Pike_Place.Models;
using System;
using System.Data;
using Pike_Place.Models.Mobs;

namespace Pike_Place.Core
{
    public class Menu
    {
        public static void Draw(string[] menuItems)
        {
            
            Console.CursorVisible = false;
            int selecteditem = 0;
            bool gameStarted = false;
            DrawFrame();
            ClearMenu(menuItems);
            while (!gameStarted)
            {
                for (int i = 0; i < menuItems.Length; i++)
                {
                    Console.SetCursorPosition(45, 20 + i); //TODO: add it to const
                    if (selecteditem == i)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(menuItems[i]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(menuItems[i]);
                    }
                }

                var key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        ClearMenu(menuItems);
                        if (selecteditem == 0)
                        {
                            selecteditem = menuItems.Length - 1;
                        }
                        else
                        {
                            selecteditem--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        ClearMenu(menuItems);
                        if (selecteditem == menuItems.Length - 1)
                        {
                            selecteditem = 0;
                        }
                        else
                        {
                            selecteditem++;
                        }
                        break;
                    case ConsoleKey.Enter:
                        if (selecteditem == 2)
                        {
                            Environment.Exit(0);
                        }
                        else if (selecteditem == 1)
                        {
                            ShowCredits(menuItems);
                        }
                        else if (selecteditem == 0)
                        {
                            CreateHero(new string[] {"Mage", "Warrior", "Marksman", "back"}, ref gameStarted,
                                menuItems);
                        }
                        break;
                    default: 
                        ClearMenu(menuItems);
                        break;
                }
            }
        }

        private static void ClearMenu(string[] menuItems)
        {
            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.SetCursorPosition(45, 20 + i); //TODO: add it to const
                Console.Write(new string(' ', menuItems[i].Length+20));
            }
        }

        private static void CreateHero(string[] herotype, ref bool started, string[] menuItems)
        {
            ClearMenu(menuItems);
            Console.CursorVisible = false;
            int selecteditem = 0;
            bool goBack = false;
            while (started == false && goBack == false)
            {
                Console.SetCursorPosition(45, 19);
                Console.WriteLine("Choose your hero type:");
                for (int i = 0; i < herotype.Length; i++)
                {
                    Console.SetCursorPosition(45, 20 + i);

                    if (selecteditem == i)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(" " + herotype[i]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(" " + herotype[i]);
                    }
                }
                var key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        ClearMenu(herotype);

                        if (selecteditem == 0)
                        {
                            selecteditem = herotype.Length - 1;
                        }
                        else
                        {
                            selecteditem--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        ClearMenu(herotype);


                        if (selecteditem == herotype.Length - 1)
                        {
                            selecteditem = 0;
                        }
                        else
                        {
                            selecteditem++;
                        }
                        break;
                    case ConsoleKey.Enter:
                        if (selecteditem == 0)
                        {
                            var hero = new Mage(NameHero());
                            var startlevel = new Level1();
                            startlevel.Start(hero);
                            started = true;
                        }
                        else if (selecteditem == 1)
                        {
                            var hero = new Warrior(NameHero());
                            var startlevel = new Level1();
                            startlevel.Start(hero);

                            started = true;
                        }
                        else if (selecteditem == 2)
                        {
                            var name = NameHero();
                            var hero = new Marksman(name);
                            var startlevel = new Level1();
                            startlevel.Start(hero);
                            started = true;
                        }
                        else if (selecteditem == 3)
                        {
                            Console.SetCursorPosition(45, 19);
                            Console.Write(new string(' ',30));
                            ClearMenu(herotype);
                            goBack = true;
                        }
                        break;
                    default:
                        ClearMenu(herotype);
                        break;
                }
            }
        }

        private static string NameHero()
        {
            Console.Clear();
            DrawFrame();
            Console.SetCursorPosition(45, 20);

            Console.Write("Name your hero: ");
            Console.SetCursorPosition(50, 21);

            var name = Console.ReadLine();
            return name;
        }


        private static void ShowCredits(string[] menuItems)
        {
            ClearMenu(menuItems);
            Console.SetCursorPosition(45, 20);
            Console.WriteLine("Po proekta sa rabotili:");
            Console.SetCursorPosition(45, 21);
            Console.WriteLine("Lyubomir Valev");
            Console.SetCursorPosition(45, 22);
            Console.WriteLine("Nikolai Bonev");
            Console.SetCursorPosition(45, 23);
            Console.WriteLine("Martin Todorov");
            Console.SetCursorPosition(45, 24);
            Console.WriteLine("Maria Velikova");

            ClearConsole();
        }

        private static void ClearConsole()
        {
            Console.SetCursorPosition(45, 26);

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Press enter to back");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Black;
            var key = Console.ReadKey();
            while (key.Key != ConsoleKey.Enter)
            {
                key = Console.ReadKey();
            }
            for (int index = 0; index < 7; index++)
            {
                Console.SetCursorPosition(45, 20 + index); //TODO to const 
                Console.Write(new string(' ', 30));
            }
            Console.ResetColor();
        }

        private static string HeroCreatedSuccesfully(string name, string type)
        {
            return $"Hero with name: {name} from class {type} was succesfully created";
        }

        public static void DrawFrame()
        {
            Console.WriteLine('\u2554' + new String('\u2550', Constants.PlayBoxWidth) + '\u2557');
            for (int i = 0; i < Constants.PlayBoxHeight; i++)
            {
                Console.WriteLine('\u2551' + new String(' ', Constants.PlayBoxWidth) + '\u2551');
            }

            Console.WriteLine('\u255A' + new String('\u2550', Constants.PlayBoxWidth) + '\u255D');
//            Console.WriteLine('\u2551' + "       " + string.Format("Health: " + new string('\u2665', health)).PadRight(16) +
//                              '\u2551' + new String('#', 40) + '\u2551' + "    " + string.Format("Missed: {0}", missed) + "   " + string.Format("Score: {0:d15}", score).PadRight(25) + "  " + '\u2551');
//            Console.WriteLine('\u255A' + new String('\u2550', Constants.PlayBoxWidth) + '\u255D');
        }
        public static void DrawScores(Hero hero ,Mob mob )
        {
            Console.SetCursorPosition(2, 2);
            Console.Write($"{hero.Name}: Health:{hero.Health} | Mana:{hero.Mana} | Atack:{hero.AttackPower}");
            Console.SetCursorPosition(55, 2);
            Console.Write("VS" + new string(' ', 15));
            Console.Write($"{mob.GetType().Name}: Health:{mob.Health} | Mana:{mob.Attack} | Atack:{mob.Experience}");
            Console.SetCursorPosition(0, 3);
            Console.WriteLine(new String('\u2550', Constants.PlayBoxWidth+2));

        }
    }
}