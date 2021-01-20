
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
            Raylib.InitWindow(1000, 800, "Spelmotor demo"); //Sets the size and framerate of the game window
            Raylib.SetTargetFPS(60);

            Level testLevel = new Level("testLevel"); //Creates a level where the gameobjects can be drawn

            GameObject.currentLevel = testLevel; //Sets GameObjects level variable to match the current level

            System.Console.WriteLine(GameObject.currentLevel); //Writes out the current level in the console
            
            Player p = new Player(); //Creates a new level
            
            new Platform(0, 600, 1500, 200); //Creates two platforms of different sizes
            new Platform(300, 400, 500,100);
            
            Level.camera.zoom = 1f; //A zoom variable for the camera to work
            Level.camera.target = new Vector2(0,0); // Where the camera is pointed at
            Level.camera.offset = new Vector2(500, 400); //Makes sure tha camer is in the middle of the screen

            while (!Raylib.WindowShouldClose()) //The game loop that updates and draws all gamobjects in the current scene
            {                     
                
                GameObject.UpdateAll();
                

                GameObject.DrawAll();
                

                if(Level.changeLevel) //Functionality to change level manually inside of the program
                {   
                    Level.LoadNextLevel();
                }
                
                
            }
           
            //testLevel.SaveLevel();

            

            

        }
    }
}
