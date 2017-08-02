namespace Pike_Place.Core
{
    public class Engine
    {
        public void Run()
        {
            var menuItems = new string[] { "Create Hero", "Credits", "Exit" };
            var menu = new Menu();
            Menu.Draw(menuItems);
        }
    }
}