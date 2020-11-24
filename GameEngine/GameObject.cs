using System.Numerics;
using System;
using System.Collections.Generic;

namespace GameEngine
{
    public class GameObject
    {
        private Vector2 position = new Vector2(0, 0);

        private float rotation = 0f;

        public static List<GameObject> gameObjects = new List<GameObject>();

        public virtual void Update()
        {


        }

        public virtual void Draw()
        {

        }

        static void UpdateAll()
        {

        }

        static void DrawAll()
        {
            
        }
    }

    
}
