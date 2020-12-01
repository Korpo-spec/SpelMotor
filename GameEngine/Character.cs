using System;
using Raylib_cs;
using System.Collections.Generic;

namespace GameEngine
{
    public class Character : GameObject
    {
        public static List<Plattform> Plattforms = new List<Plattform>();

        protected Rectangle body = new Rectangle(10, 10, 50, 50);
        private int hp;

        protected void CheckForCollision(){

            foreach (Plattform item in Plattforms)
            {
                if (Raylib.CheckCollisionRecs(item.hitbox, body))
                {
                    body.y = item.hitbox.y - body.height;
                }
            }

        }

    }
}
