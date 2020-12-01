
using System.Numerics;
using System;
using Raylib_cs;

namespace GameEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(1000, 800, "Spelmotor demo");
            Raylib.SetTargetFPS(60);

            Vector2 position = new Vector2(1,2);
            Console.WriteLine("Hello World!" + position.Y);
            
            new Player();
            Console.WriteLine( GameObject.gameObjects.Count);
            new Plattform(0, 600, 700, 100);
            

            while (!Raylib.WindowShouldClose())
            {
                
                
                GameObject.UpdateAll();
                

                GameObject.DrawAll();

                
                
                
            }
           
            

        }
    }
}
