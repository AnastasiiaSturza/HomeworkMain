using ConsoleAppSnake;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using static System.Console;

var MapWidth = 30;
var MapHeight = 20;
var NewWidth = MapWidth * 3;
var NewHeigt = MapHeight * 3;


var consolColor = ConsoleColor.Green;

Console.SetWindowSize(NewWidth,NewHeigt);
Console.SetBufferSize(NewWidth,NewHeigt);
CursorVisible = false;
ConsoleColor HeadColor = ConsoleColor.Green;
ConsoleColor BodyColor = ConsoleColor.Blue;
ConsoleColor FoodColor = ConsoleColor.Red;
Random Random = new Random();
int frameMs = 200;
int score = 0;
Directions currentMovement = Directions.Right;

DrawBorder();

var snake = new Snake(10, 5, HeadColor, BodyColor);

Pixel food = GetFood(snake);
food.PixelDraw();
 Pixel GetFood(Snake snake)
 {
    Pixel food;
    do
    {
        food = new Pixel(Random.Next(1, MapWidth - 1), Random.Next(1, MapHeight - 1), FoodColor);
    }
    while (snake.Head.X == food.X && snake.Head.Y == food.Y || snake.Body.Any(b => b.X == food.X && b.Y == food.Y));

    return food;
 }




Stopwatch sw = new Stopwatch();

while (true)
{
    sw.Restart();
    Directions oldMovement = currentMovement;
    while (sw.ElapsedMilliseconds < frameMs)
    {
        if (oldMovement == currentMovement)
        {
            currentMovement = ReadMovenent(currentMovement);
        }
    }

    if (snake.Head.X == food.X && snake .Head.Y == food.Y)
    { 
        snake.Move(currentMovement, true);

        food = GetFood(snake);
        food.PixelDraw();
        score++;
    }

    else
    {
        snake.Move(currentMovement);
    }
    

    //Thread.Sleep(200);

    if (snake.Head.X == MapWidth - 1 || snake.Head.X == 0 || snake.Head.Y == MapHeight - 1
        || snake.Head.Y == 0
        || snake.Body.Any(b => b.X == snake.Head.X && b.Y == snake.Head.Y))
        break;

    
}
snake.Clear();
SetCursorPosition(MapWidth/7, MapHeight/7);
WriteLine($"Game over and score = {score}");
ReadKey();

static Directions ReadMovenent (Directions currentDirections)
{
    if (!KeyAvailable) 
        return currentDirections;
    ConsoleKey key = ReadKey(true).Key;

    currentDirections = key switch
    {
        ConsoleKey.UpArrow when currentDirections != Directions.Down => Directions.Up,
        ConsoleKey.DownArrow when currentDirections != Directions.Up => Directions.Down,
        ConsoleKey.LeftArrow when currentDirections != Directions.Right => Directions.Left,
        ConsoleKey.RightArrow when currentDirections != Directions.Left => Directions.Right,
        _ => currentDirections
    };
    return currentDirections;
}
void DrawBorder ()
{
    for (int i = 0; i < MapWidth; i++)
    {
        new Pixel(i, 0, consolColor).PixelDraw();
        new Pixel(i, MapHeight - 1, consolColor).PixelDraw();
    }
    for (int i = 0; i < MapHeight; i++)
    {
        new Pixel(0, i, consolColor).PixelDraw();
        new Pixel(MapWidth - 1, i, consolColor).PixelDraw();
    }

}






