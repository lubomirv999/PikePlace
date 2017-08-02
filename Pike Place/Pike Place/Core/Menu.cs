using Pike_Place.Heroes;
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
                            CreateHero();
                        }
                        break;
                }
                Console.Clear();
            }
        }

        private static void CreateHero()
        {
            Console.Clear();
            Console.WriteLine("Choose your hero type:");
            Console.WriteLine("Mage - 0, Warrior - 1, Marksman - 2");
            var heroType = int.Parse(Console.ReadLine());
            string name;
            string type;
            
            switch (heroType)
            {
                case 0:
                    type = "Mage";
                    Console.Write("Enter name for your hero: ");
                    name = Console.ReadLine();
                    Mage mage = new Mage(name);
                    Console.WriteLine(HeroCreatedSuccesfully(name, type));
                    break;
                case 1:
                    type = "Warrior";
                    Console.Write("Enter name for your hero: ");
                    name = Console.ReadLine();
                    Warrior warrior = new Warrior(name);
                    Console.WriteLine(HeroCreatedSuccesfully(name, type));
                    break;
                case 2:
                    type = "Marksman";
                    Console.Write("Enter name for your hero: ");
                    name = Console.ReadLine();
                    Marksman marksman = new Marksman(name);
                    Console.WriteLine(HeroCreatedSuccesfully(name, type));
                    break;
            }

            ClearConsole();
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