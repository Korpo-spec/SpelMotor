using System.Numerics;
using System;
using System.Collections.Generic;
using Raylib_cs;

namespace GameEngine
{
    public class GameObject
    {
        public Vector2 position = new Vector2(0, 0);

        public float rotation = 0f;

        public static Level currentLevel;

        public GameObject()
        {
            currentLevel.gameObjectsInScene.Add(this);
            Console.WriteLine(this);
        }

        
        public virtual void Update()
        {

        }

        public virtual void Draw()
        {

        }

        public static void UpdateAll()
        {
            foreach (GameObject u in currentLevel.gameObjectsInScene)
            {
                u.Update();
            }
        }

        public static void DrawAll()
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
