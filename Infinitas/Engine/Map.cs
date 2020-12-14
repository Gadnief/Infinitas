using System;
namespace Infinitas.Engine
{
    public class Map
    {
        public int[,] mapMatrix { get; set; }

        public Map()
        {
            mapMatrix = new int[100, 100];

            FillMapRandom();
        }

        public void FillMapRandom()
        {
            Random rnd = new Random();
            for (int x = 0; x < mapMatrix.GetLength(0); x++)
            {
                for (int y = 0; y < mapMatrix.GetLength(1); y++)
                {
                    mapMatrix[x, y] = rnd.Next(0, 2);
                }
            }
        }
    }
}
