
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
            
            new Platform(0, 600, 1500, 200);
            new Platform(300, 400, 500,100);
            
            Level.camera.zoom = 1f;
            Level.camera.target = new Vector2(0,0);
            Level.camera.offset = new Vector2(500, 400);



            Texture2D spriteSheet = Raylib.LoadTexture(@"AnimTest.png");
            Animation test = new Animation();

            

            

            while (!Raylib.WindowShouldClose())
            {                     
                
                GameObject.UpdateAll();
                

                GameObject.DrawAll();
                

                if(Level.changeLevel){
                    Level.LoadNextLevel();
                }
                
                
            }
           
            //testLevel.SaveLevel();

            

            

        }
    }
}
