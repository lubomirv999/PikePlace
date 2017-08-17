namespace Pike_Place.Constants
{
    public static class Constants
    {
        //Mage
        public static readonly string[] MagePicture = new string[] { "(\\ _ /)", "(' x ')", "c(\")(\")" };
        public const int MageHeight = 3;
        public const int MageWidth = 7;
        //Warrior
        public static readonly string[] WarriorPicture = new string[] { "  /\\_/\\  ", "=( °w° )=", "  )   ( " , " (__|__)" };
        public const int WarriorHeight = 4;
        public const int WarriorWidth = 9;

        //Marksman
         public static readonly string[] MarksmanPicture = new string[] { "   \\\\ ", "   (o>", "\\\\_//)", " \\_/_)", "  _|_ " };
        public const int MarksmanHeight = 5;
        public const int MarksmanWidth = 6;

        //Hero
        public const int HeroSpawnPositionX = 48;
        public const int HeroSpawnPositionY = 30;
        public const int MainShipSpeedX = 3;
        public const int MainShipSpeedY = 2;

        //mobs
        public static readonly string[] DoomPicture = new string[] { "________", "|(.)(.)|", "|  __  |", "|______|" };
        public static readonly string[] SkullPicture = new string[] { "________", "|(x)(x)|", "|  \\/  |", "|______|" };
        public static readonly string[] ViperPicture = new string[] { "________", "|(o)(o)|", "|  o   |", "|______|" };
        public const int MobSpawnPositionX = 90;
        public const int MobSpawnPositionY = 25;


        //menu
        public static readonly string[] StartMenuItems = new string[] {"Create Hero", "Credits", "Exit"};
        public static readonly string[] ChooseHeroMenuItems = new string[] {"Mage", "Warrior", "Marksman", "back"};
        
        
        // Console window size
        public const int ConsoleWindowWidth = 120;
        public const int ConsoleWindowHeight = 41;

        public const int PlayBoxWidth = 116;
        public const int PlayBoxHeight = 38;


        //Frame 
        public const int FrameWidth = 1;
    
       
     

    }
}