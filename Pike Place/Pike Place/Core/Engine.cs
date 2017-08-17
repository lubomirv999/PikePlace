namespace Pike_Place.Core
{
    public class Engine
    {
        public void Run()
        {
            var menu = new Menu();
            Menu.Draw(Constants.Constants.StartMenuItems);
        }
    }
}