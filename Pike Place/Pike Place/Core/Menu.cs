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

                        }
                        break;
                }
                Console.Clear();
            }
        }
        private static void ShowCredits()
        {
            Console.Clear();
            Console.WriteLine("По проекта са работили:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine();
            }
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
    }
}
