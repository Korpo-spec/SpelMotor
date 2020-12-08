
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

            Vector2 position = new Vector2(1,2);
            Console.WriteLine("Hello World!" + position.Y);
            
            new Player();
            Console.WriteLine( GameObject.gameObjects.Count);
            new Plattform(0, 600, 1500, 100);
            
            Level.camera.zoom = 1f;
            Level.camera.target = new Vector2(0,0);
            Level.camera.offset = new Vector2(500, 400);

            Level testLevel = new Level("testLevel");

            
            

            while (!Raylib.WindowShouldClose())
            {
                
                
                GameObject.UpdateAll();
                

                GameObject.DrawAll();

                
                
                
            }
           
            testLevel.SaveLevel();

            XmlSerializer levelSerializer = new XmlSerializer (typeof(Level));
            
            FileStream file = File.Open(@"testLevel.xml", FileMode.OpenOrCreate);

            levelSerializer.Serialize(file, testLevel);

            file.Close();

            Console.ReadLine();

        }
    }
}
