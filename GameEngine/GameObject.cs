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

<<<<<<< HEAD
        public virtual void Update()
=======
        public GameObject()
>>>>>>> 6c8f710431f5b23b3ed6403a1471adbe5fc80f81
        {
            gameObjects.Add(this);
        }

        public void Update()
        {
            
        }

        public virtual void Draw()
        {

        }

        static void UpdateAll()
        {
            foreach (GameObject u in gameObjects)
            {
                u.Update();
            }
            
        }

        static void DrawAll()
        {
            foreach (GameObject d in gameObjects)
            {
                d.Draw();
            }
        }
    }

    
}
