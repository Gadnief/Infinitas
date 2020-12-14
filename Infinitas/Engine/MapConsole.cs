using System;
using Console = SadConsole.Console;
using SadConsole;


namespace Infinitas.Engine
{
    public class MapConsole
    {
        public Console Map_Console { get; set; }

        public MapConsole()
        {
            Map_Console = new Console(100, 50);          
        }       

        public void RenderMapConsole(Map map)
        {
            for(int x=0; x<Map_Console.Width; x++)
            {
                for(int y=0; y<Map_Console.Height; y++)
                {
                    switch (map.mapMatrix[x,y])
                    {
                        case 0:
                            Map_Console.Print(x, y, new SadConsole.ColoredGlyph(44));
                            break;
                        case 1:
                            Map_Console.Print(x, y, new SadConsole.ColoredGlyph(59));
                            break;
                    }
                }
            }
        }

        
    }
}
