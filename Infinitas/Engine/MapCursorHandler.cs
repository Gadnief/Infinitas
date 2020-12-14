using System;
using SadConsole.Components;
using SadConsole.Input;
using Microsoft.Xna.Framework;
using Console = SadConsole.Console;

namespace Infinitas.Engine
{
    public class MapCursorHandler : KeyboardConsoleComponent
    {
        public Cursor cursor;
        public Console cursor_Console;

        public MapCursorHandler(Console console)
        {
            cursor = new Cursor();
            cursor_Console = console;
        }

        public override void ProcessKeyboard(SadConsole.Console console, Keyboard info, out bool handled)
        {
            int increment = 0;

            if (info.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.LeftShift))
            {
                increment = 5;
            }
            else { increment = 1; }

           
            if (info.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Right))
            {
                cursor.x_position+=increment;
            }
            else if (info.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Left))
            {
                cursor.x_position-=increment;
            }
            else if (info.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Up))
            {
                cursor.y_position-=increment;
            }
            else if (info.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Down))
            {
                cursor.y_position+=increment;
            }
            


            handled = true;
        }

        public void RenderCursor()
        {
            cursor_Console.Print(cursor.x_position, cursor.y_position, "X", ColorAnsi.YellowBright);
        }

    }
}
