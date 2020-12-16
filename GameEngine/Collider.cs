using System;
using Raylib_cs;
using System.Numerics;
using System.Collections.Generic;

namespace GameEngine
{
    public class Collider : GameObject
    {
        public Vector2 velocity = new Vector2();//Velocity, used for gravity

        public Rectangle hitbox = new Rectangle(10, 10, 50, 50);//basically the hitbox

        public static List<Collider> colliderObjects = new List<Collider>();

        public Collider()
        {
            colliderObjects.Add(this);
        }
        protected void CheckForCollision(){

            foreach (Collider item in colliderObjects)
            {
                if (Raylib.CheckCollisionRecs(item.hitbox, hitbox))//Checks if a character is colliding with plattforms and makes then not fall through it also calls for OnCollision()
                {
                    Rectangle colliding = Raylib.GetCollisionRec(item.hitbox,hitbox);

                    hitbox.y -= colliding.height;
                    
                    velocity.Y = 0;
                    OnCollision(item);
                }
            }

        }

        protected virtual void OnCollision(GameObject collisionObj)//Can be overrided to write what will happen when something is colliding with the object in hand
        {

        }


    }
}
