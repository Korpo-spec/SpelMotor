using System.Numerics;
using System;
using System.Collections.Generic;
using Raylib_cs;

namespace GameEngine
{
    public class GameObject
    {
        public Vector2 position = new Vector2(0, 0); //Variables for the position and rotation of the objects

        public float rotation = 0f;

        public static Level currentLevel; //A refernce to which level is currently displayed

        public GameObject() //This constructor adds in the current game object in question to the scene
        {
            currentLevel.gameObjectsInScene.Add(this);
            Console.WriteLine(this);
        }

        
        public virtual void Update() //Overridable update and draw methods
        {

        }

        public virtual void Draw()
        {

        }

        public static void UpdateAll()  //Updates all gameobjects in the current scene
        {
            foreach (GameObject u in currentLevel.gameObjectsInScene)
            {
                u.Update();
            }
        }

        public static void DrawAll() //Draws all gameobjects in the current scene, and a beginmode2D to draw everything relative to the in game camera.
        {
            Raylib.BeginDrawing();
            Raylib.BeginMode2D(Level.camera);
            Raylib.ClearBackground(Color.WHITE);
            
            foreach (GameObject d in currentLevel.gameObjectsInScene)
            {
                d.Draw();
            }
            Raylib.EndMode2D();
            Raylib.EndDrawing();
        }
    }

    
}
