using System.Numerics;
using System;
using Raylib_cs;
using System.Collections.Generic;

namespace GameEngine
{
    public class Character : GameObject
    {
        public static List<Plattform> Plattforms = new List<Plattform>();

        public Vector2 velocity = new Vector2();

        

        public Rectangle body = new Rectangle(10, 10, 50, 50);
        private int hp;

        public Character(){

        }

        protected void CheckForCollision(){

            foreach (Plattform item in Plattforms)
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
