using System.Numerics;
using System;
using Raylib_cs;
using System.Collections.Generic;

namespace GameEngine
{
    public class Character : GameObject
    {
        public static List<Platform> Plattforms = new List<Platform>();

        public Vector2 velocity = new Vector2();

        

        public Rectangle body = new Rectangle(10, 10, 50, 50);
        public int hp;

        public Character(){

        }

        protected void CheckForCollision(){

            foreach (Platform item in Plattforms)
            {
                if (Raylib.CheckCollisionRecs(item.hitbox, body))
                {
                    body.y = item.hitbox.y - body.height;
                    velocity.Y = 0;
                }
            }

        }

    }
}
