
using System.Numerics;
using System;
using Raylib_cs;
using System.IO;
using System.Xml;
using System.Xml.Serialization;


namespace GameEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(1000, 800, "Spelmotor demo");
            Raylib.SetTargetFPS(60);

            Level testLevel = new Level("testLevel");

            GameObject.currentLevel = testLevel;

            System.Console.WriteLine(GameObject.currentLevel);
            
            Player p = new Player();
            
            new Plattform(0, 600, 1500, 200);
            
            Level.camera.zoom = 1f;
            Level.camera.target = new Vector2(0,0);
            Level.camera.offset = new Vector2(500, 400);


            
            

            while (!Raylib.WindowShouldClose())
            {
                
                
                GameObject.UpdateAll();
                

                GameObject.DrawAll();

                if(Raylib.IsKeyDown(KeyboardKey.KEY_L))
                {
                    Level.LoadLevel("shh");
                }
                
                
            }
           
            //testLevel.SaveLevel();

            

            

        }
    }
}
