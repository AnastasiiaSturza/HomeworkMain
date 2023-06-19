using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleAppSnake
{
    public struct  Pixel 
    {
        
        public int X { get; }
        public int Y { get; }
        public ConsoleColor Color { get; }
        public int PixelSize { get; }

        private const char PixelChar = '█';

        public Pixel(int x, int y, ConsoleColor color, int pixelSize = 3)
        {
            X = x;
            Y = y;
            Color = color;
            PixelSize = pixelSize;
        }

        public void PixelDraw ()
        {
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(X,Y);
            Console.Write(PixelChar);
        }

        public void PixelClear()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(' ');
        }

        //public Pixel GetFood(Snake snake)
        //{
        //    Pixel food;
        //    do
        //    {
        //        food = new Pixel(Random.Next(1, MapWidth - 1), Random.Next(1, MapHeight - 1), FoodColor);
        //    }
        //    while (snake.Head.X == food.X && snake.Head.Y == food.Y || snake.Body.Any(b => b.X == food.X && b.Y == food.Y));

        //    return food;
        //}
    }
}
