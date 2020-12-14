using System;
using Console = SadConsole.Console;
using Microsoft.Xna.Framework;


namespace Infinitas.Engine
{
    public class Cursor
    {
        public int x_position { get; set; }
        public int y_position { get; set; }

        public Cursor()
        {
            x_position = 0;
            y_position = 0;
        }

    }
}
