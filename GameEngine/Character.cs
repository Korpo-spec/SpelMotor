using System.Numerics;
using System;
using Raylib_cs;
using System.Collections.Generic;

namespace GameEngine
{
    public class Character : Collider
    {
        public static List<Platform> Plattforms = new List<Platform>();//list of all the platforms

        

        

        
        public int hp;

        public Character(){
            
        }
        /*
        protected void CheckForCollision(){

            foreach (Platform item in Plattforms)
            {
                if (Raylib.CheckCollisionRecs(item.hitbox, hitbox))//Checks if a character is colliding with plattforms and makes then not fall through it also calls for OnCollision()
                {
                    hitbox.y = item.hitbox.y - hitbox.height;
                    velocity.Y = 0;
                    OnCollision(item);
                }
            }

        }

        
        protected virtual void OnCollision(GameObject collisionObj)//Can be overrided to write what will happen when something is colliding with the object in hand
        {

        }
        */
    }
}
