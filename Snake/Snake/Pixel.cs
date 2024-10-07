using System;
using System.Drawing;

namespace SnakeGame
{
    public readonly struct Pixel
    {
        //private const char PixelChar = '█';
        private const char BorderChar = '█';
        private const char FoodChar = 'o';
        private const char BombChar = '*';

        public Pixel(int x, int y, ConsoleColor color, char pixelChar = BorderChar)
        {
            X = x;
            Y = y;
            Color = color;
            PixelChar = pixelChar;
        }

        public int X { get; }

        public int Y { get; }

        public ConsoleColor Color { get; }

        private char PixelChar { get; }

        //public int PixelSize { get; }

        public void Draw()
        {
            Console.ForegroundColor = Color;

            Console.SetCursorPosition(X, Y);
            Console.Write(PixelChar);
            //for (int x = 0; x < PixelSize; x++)
            //{
            //    for (int y = 0; y < PixelSize; y++)
            //    {
            //        Console.SetCursorPosition(X * PixelSize + x, Y * PixelSize + y);
            //        Console.Write(PixelChar);
            //    }
            //}
        }

        public void Clear()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(' ');
        }
    }
}
