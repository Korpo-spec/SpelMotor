using System;
using Raylib_cs;
using System.Numerics;
using System.Collections.Generic;

namespace GameEngine
{
    public abstract class Collider : GameObject
    {
        public Vector2 velocity = new Vector2();//Velocity, used for gravity

        public Rectangle hitbox;

        public static List<Collider> colliderObjects = new List<Collider>();

        public Collider()
        {
            colliderObjects.Add(this);
        }
        protected void CheckForCollision(){

            

            foreach (Collider item in colliderObjects)
            {   
                if(item != this){
                    
                    if (Raylib.CheckCollisionRecs(item.hitbox, hitbox))//Checks if a character is colliding with plattforms and makes then not fall through it also calls for OnCollision()
                    {
                        
                        Rectangle colliding = Raylib.GetCollisionRec(item.hitbox,hitbox);
                          
                        if(colliding.width <= colliding.height)
                        {
                            if(colliding.x > hitbox.x + (hitbox.width/2)){
                                hitbox.x -= colliding.width;
                                position.X -= colliding.width;
                            }
                            else{
                                hitbox.x += colliding.width;
                                position.X += colliding.width;
                            }
                        }

                        if(colliding.height <= colliding.width)//Checks if the box between the
                        {
                            /*
                            if(colliding.y > hitbox.y + (hitbox.height/2)){
                                hitbox.y += colliding.height;
                            }
                            else{
                                
                            }
                            */
                            hitbox.y -= colliding.height;
                            velocity.Y = 0;
                        }

                        OnCollision(item);
                    }
                }
                
            }

        }

        protected virtual void OnCollision(GameObject collisionObj)//Can be overrided to write what will happen when something is colliding with the object in hand
        {

        }


    }
}
