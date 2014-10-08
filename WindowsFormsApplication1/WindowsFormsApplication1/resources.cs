using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class resources
    {
        public static bool turn = false;
        public static int difficulty = 0;
        public static Form1 main_menu;
        public static bool close_game = false;
        public static string location = Directory.GetCurrentDirectory();
        public static List<int> chance = new List<int>();
        public static int random_chance = 10;
        public static bool cheat_mode = false;
        public static bool chance_go = false;
        public static main_game game;
        public static win victory;
        public static loss lose;
        public static int wait_time = 4;
    }
}
