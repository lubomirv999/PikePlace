using Pike_Place.Heroes;
using Pike_Place.Levels;
using Pike_Place.Models;
using System;

namespace Pike_Place.Core
{
    class Menu
    {
        public static void Draw(string[] menuItems)
        {
            Console.CursorVisible = false;
            int selecteditem = 0;
            while (true)
            {
                for (int i = 0; i < menuItems.Length; i++)
                {
                    if (selecteditem == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("->");
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(menuItems[i]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine(menuItems[i]);
                    }
                }
                var key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
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
                            ShowCredits();
                        }
                        else if (selecteditem == 0)
                        {
                            CreateHero(new string[] { "Mage", "Warrior", "Marksman", "back" });
                        }
                        break;
                }
                Console.Clear();
            }
        }

        private static void CreateHero(string[] herotype)
        {
            Console.Clear();
            Console.CursorVisible = false;
            int selecteditem = 0;
            while (true)
            {
                Console.WriteLine("Choose your hero type:");
                for (int i = 0; i < herotype.Length; i++)
                {
                    if (selecteditem == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("->");
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(" " + herotype[i]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine("- " + herotype[i]);
                    }
                }
                var key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
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
                            NameHero();
                            var name = Console.ReadLine();
                            var hero = new Mage(name);
                            var startlevel = new Level1();
                            startlevel.Start(hero);

                        }
                        else if (selecteditem == 1)
                        {
                            NameHero();
                            var name = Console.ReadLine();
                            var hero = new Warrior(name);
                            var startlevel = new Level1();
                            startlevel.Start(hero);
                        }
                        else if (selecteditem == 2)
                        {
                            NameHero();
                            var name = Console.ReadLine();
                            var hero = new Marksman(name);
                            var startlevel = new Level1();
                            startlevel.Start(hero);
                        }
                        else if (selecteditem == 3)
                        {
                            Console.Clear();
                            Draw(new string[] { "Create Hero", "Credits", "Exit" });
                        }
                        break;
                }
                Console.Clear();
            }
        }

        private static void NameHero()
        {
            Console.Clear();
            Console.Write("Name your hero: ");
        }
            
           

        private static void ShowCredits()
        {
            Console.Clear();
            Console.WriteLine("По проекта са работили:");
            Console.WriteLine("Lyubomir Valev");
            Console.WriteLine("Nikolai Bonev");
            Console.WriteLine("Martin Todorov");
            Console.WriteLine("Maria Velikova");

            ClearConsole();
        }

        private static void ClearConsole()
        {
            Console.WriteLine();
            Console.Write("    ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Press enter to back");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Black;
            var key = Console.ReadKey();
            while (key.Key != ConsoleKey.Enter)
            {
                key = Console.ReadKey();
            }
            Console.ResetColor();
        }

        private static string HeroCreatedSuccesfully(string name, string type)
        {
            return $"Hero with name: {name} from class {type} was succesfully created";
        }
    }
}