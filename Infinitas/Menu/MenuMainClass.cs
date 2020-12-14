using System;
using Console = SadConsole.Console;
using Microsoft.Xna.Framework;

namespace Infinitas.Menu
{
    public class MenuMainClass
    {
        public Console MenuMainConsole { get; set; }

        /// <summary>
        /// Initilize the main manu
        /// </summary>
        /// <param name="x">Heigth </param>
        /// <param name="y"></param>
        public MenuMainClass(int width, int height)
        {
            MenuMainConsole = new Console(width, height);
        }

        public void RenderConsole()
        {
            MenuMainConsole.Fill(ColorAnsi.Black, Color.Gray, 0);

            //Render horizontal line
            MenuMainConsole.DrawLine(new Point(0, 0), new Point(MenuMainConsole.Width,0), ColorAnsi.Blue, null, 205);
            MenuMainConsole.DrawLine(new Point(0, MenuMainConsole.Height / 3), new Point(MenuMainConsole.Width, MenuMainConsole.Height / 3), ColorAnsi.Blue,null,205);
            //MenuMainConsole.DrawLine(new Point(2, 4), new Point(20, 6), Color.BlueViolet, Color., 0);
        }
    }
}
