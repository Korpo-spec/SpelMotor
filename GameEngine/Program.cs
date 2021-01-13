
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
                
                //Vector2 positionInTexture = new Vector2(100, 200);
                //Rectangle frameSize = new Rectangle(0, 0, 16, 12);
                
               
                                 

                GameObject.UpdateAll();
                

                GameObject.DrawAll();
                //Animation.DrawAnimation(spriteSheet, frameSize, positionInTexture); /*Doesn't crash, but also doesn't seem to work properly, 
                                                                                      /*it finds and loads the png however it doesn't show up*/

                if(Level.changeLevel){
                    Level.LoadNextLevel();
                }
                
                
            }
           
            //testLevel.SaveLevel();

            

            

        }
    }
}
