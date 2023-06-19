using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSnake
{
    public class Snake
    {

        public Pixel Head { get ; set; }

        public Queue<Pixel> Body { get; } = new Queue<Pixel>();
        public ConsoleColor HeadColor { get; set; }

        public ConsoleColor BodyColor { get; set; }

        public Snake (int initialX, int initialY, ConsoleColor headColor, ConsoleColor bodyColor, int bodyLength = 3)
        {
            HeadColor = headColor;
            BodyColor = bodyColor;

            Head = new Pixel (initialX, initialY, headColor);
            for (int i = bodyLength; i >= 0; i--) 
            {
                Body.Enqueue(new Pixel(Head.X-i-1, initialY, bodyColor));
            }

            Draw();
        }

        public void Draw()
        {
            Head.PixelDraw();

            foreach (var pixel in Body) 
            { 
                pixel.PixelDraw();
            }
        }

        public void Clear()
        {
            Head.PixelClear();

            foreach (var pixel in Body)
            {
                pixel.PixelClear();
            }
        }

        public void Move(Directions direction, bool eat = false)
        {
            Clear();

            Body.Enqueue(new Pixel(Head.X, Head.Y, BodyColor));

            if (!eat)

            Body.Dequeue();

            Head = direction switch
            {
                Directions.Right => new Pixel(Head.X + 1, Head.Y, HeadColor),
                Directions.Left => new Pixel(Head.X - 1, Head.Y, HeadColor),
                Directions.Up => new Pixel(Head.X, Head.Y - 1, HeadColor),
                Directions.Down => new Pixel(Head.X, Head.Y + 1, HeadColor),_=> Head
            };
            Draw();
        }
    }

}
