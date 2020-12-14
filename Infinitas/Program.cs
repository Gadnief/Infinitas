using System;
using SadConsole;
using Microsoft.Xna.Framework;
using Console = SadConsole.Console;
using MenuMainClass = Infinitas.Menu.MenuMainClass;
using Microsoft.Extensions.Configuration;
using Infinitas.Engine;

namespace Infinitas
{
    class Program
    {
        static Console mainConsole;
        static MenuMainClass mainMenu;
        static MapConsole mapConsole;
        static MapCursorHandler mapCursorHandler;
        static Map map;

        static void Main()
        {
            // Setup the engine and create the main window.
            SadConsole.Game.Create(80, 25);

            // Hook the start event so we can add consoles to the system.
            SadConsole.Game.OnInitialize = Init;

            SadConsole.Game.OnUpdate = Update;

            // Start the game.
            SadConsole.Game.Instance.Run();
            SadConsole.Game.Instance.Dispose();
        }

        static void Init()
        {
            InitWindow();

            InitGame();

            mapConsole.Map_Console.IsFocused = true;

            //Initialize the cursor
            mapCursorHandler = new MapCursorHandler(mapConsole.Map_Console);
            mapConsole.Map_Console.Components.Add(mapCursorHandler);

        }

        static void Update(GameTime time)
        {
            mainConsole.Clear();

            //mainConsole.FillWithRandomGarbage();
            mapConsole.RenderMapConsole(map);
            mainMenu.RenderConsole();
            mapCursorHandler.RenderCursor();
        }

        
        private static void Program_WindowResized(object sender, EventArgs e)
        {
            mainMenu.MenuMainConsole.Position = new Point(mainConsole.Width - 50, 0);
            mapConsole.Map_Console.Position = new Point(0, 0);

            mainConsole.Resize(Global.WindowWidth / mainConsole.Font.Size.X, Global.WindowHeight / mainConsole.Font.Size.Y, false);
            mainConsole.Fill(new Rectangle(3, 3, 23, 3), Color.Violet, Color.Black, 0, 0);

        }

        private static void InitWindow()
        {
            //Read the settings from application.json
            var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json").Build();

            //Set the main settings for window
            var window_config = config.GetSection("Window");
            var main_heigth = Convert.ToInt32(window_config["Heigth"]);
            var main_width = Convert.ToInt32(window_config["Width"]);

            var menu_config = config.GetSection("Menu");

            //Settings.ResizeWindow(main_width, main_heigth);

            //Init cosoles
            mainConsole = new Console(10, 10);
            mainMenu = new MenuMainClass(50, 15);
            mapConsole = new MapConsole();

            //mainConsole.Resize(Global.WindowWidth / mainConsole.Font.Size.X, Global.WindowHeight / mainConsole.Font.Size.Y, false);

            //Add component consoles
            mainConsole.Children.Add(mainMenu.MenuMainConsole);
            mainConsole.Children.Add(mapConsole.Map_Console);

            Global.CurrentScreen = mainConsole;

            //Scale the window and console
            ((SadConsole.Game)SadConsole.Game.Instance).WindowResized += Program_WindowResized;
            Settings.ResizeMode = Settings.WindowResizeOptions.None;
            Settings.ResizeWindow(main_width, main_heigth);
            mainConsole.Resize(Global.WindowWidth / mainConsole.Font.Size.X, Global.WindowHeight / mainConsole.Font.Size.Y, false);
            //Settings.ToggleFullScreen();

            //Position child consoles
            mainMenu.MenuMainConsole.Position = new Point(mainConsole.Width - 50, 0);
            mapConsole.Map_Console.Position = new Point(0, 0);
        }

        private static void InitGame()
        {
            map = new Map();
        }
    }
}