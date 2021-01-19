using Spectre.Console;
using System;

namespace MazeRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maze Runner!");
            AnsiConsole.Markup("[underline red]Hello[/] World!");
            Console.WriteLine("Canvas:");
            // Create a canvas
            var canvas = new Canvas(16, 16);

            // Draw some shapes
            for (var i = 0; i < canvas.Width; i++)
            {
                // Cross
                canvas.SetPixel(i, i, Color.White);
                canvas.SetPixel(canvas.Width - i - 1, i, Color.Yellow);

                // Border
                canvas.SetPixel(i, 0, Color.Red);
                canvas.SetPixel(0, i, Color.Green);
                canvas.SetPixel(i, canvas.Height - 1, Color.Yellow);
                canvas.SetPixel(canvas.Width - 1, i, Color.Yellow);
            }

            // Render the canvas
            AnsiConsole.Render(canvas);

            ConsoleKeyInfo keypress = Console.ReadKey();
            while (keypress.Key != ConsoleKey.Escape)
            {
                if (keypress.Key == ConsoleKey.LeftArrow)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                }
                else
                {
                    Console.WriteLine("What's that key?");
                }
                keypress = Console.ReadKey(); // read keystrokes  
            }
        }
    }
}
