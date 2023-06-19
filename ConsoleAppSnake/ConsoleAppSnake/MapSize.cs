using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleAppSnake
{
    public class MapSize
    {

        public int MapWidth { get; set; }
        public int MapHeight { get; set; }

        public bool CursorVisible { get; set; }

        public MapSize() { }
        public MapSize(int mapWidth, int mapHeight) 
        {  
            MapWidth = mapWidth; 
            MapHeight = mapHeight;
        }


        //public void SetWindowSize(int width, int height)
        //{
        //    width = MapWidth; 
        //    height = MapHeight;
        //}

        //public void SetBufferSize(int width, int height)
        //{
        //    width = MapWidth;
        //    height = MapHeight;
        //}

    }
}
