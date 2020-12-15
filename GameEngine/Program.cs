
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
                Texture2D spriteSheet = Raylib.LoadTexture(@"AnimTest.png");
                Vector2 positionInTexture = new Vector2(0, 0);
                Rectangle frameSize = new Rectangle(10, 10, 16, 12);
                Animation test = new Animation();
                Animation.DrawAnimation(spriteSheet, frameSize, positionInTexture); /*Doesn't crash, but also doesn't seem to work properly, 
                                                                                      it finds and loads the png however it doesn't show up*/
                                 

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
