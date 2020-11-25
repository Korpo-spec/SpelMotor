using System.Numerics;
using System;
using System.Collections.Generic;
using Raylib_cs;

namespace GameEngine
{
    public class GameObject
    {
        protected Vector2 position = new Vector2(0, 0);

        protected float rotation = 0f;

        public static List<GameObject> gameObjects = new List<GameObject>();

        public GameObject()
        {
            gameObjects.Add(this);
        }

        public virtual void Update()
        {

        }

        public virtual void Draw()
        {

        }

        public static void UpdateAll()
        {
            foreach (GameObject u in gameObjects)
            {
                u.Update();
            }
        }

        public static void DrawAll()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);
            foreach (GameObject d in gameObjects)
            {
                d.Draw();
            }
            Raylib.EndDrawing();
        }
    }

    
}
