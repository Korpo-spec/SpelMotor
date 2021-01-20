using System;
using Raylib_cs;
using System.Numerics;
using System.Collections.Generic;

namespace GameEngine
{
    public abstract class Collider : GameObject
    {
        public Vector2 velocity = new Vector2();//Velocity, used for gravity

        public Rectangle hitbox; // The hitbox of the collider object

        public static List<Collider> colliderObjects = new List<Collider>(); // A list of all objects with colliders

        public Collider()
        {
            colliderObjects.Add(this);// when object is created add to colliderObjects list
        }
        protected void CheckForCollision(){

            

            foreach (Collider item in colliderObjects)//for every collider
            {   
                if(item != this){//we dont want to check collision between itself so if its not itself
                    
                    if (Raylib.CheckCollisionRecs(item.hitbox, hitbox))//Checks if a character is colliding with plattforms and makes then not fall through it also calls for OnCollision()
                    {
                        
                        Rectangle colliding = Raylib.GetCollisionRec(item.hitbox,hitbox);//gets the colliding box between the two colliding objects
                          
                        if(colliding.width <= colliding.height)//if the height of the colliding object is greater than the width we want to shove the box out of the colliding object to the side
                        {
                            if(colliding.x > hitbox.x + (hitbox.width/2)){//checks wich way the object is supposed to be shoved, is it to the right or left?
                                hitbox.x -= colliding.width;
                                position.X -= colliding.width;
                            }
                            else{
                                hitbox.x += colliding.width;
                                position.X += colliding.width;
                            }
                        }

                        if(colliding.height <= colliding.width)//if the width of the colliding object is greater than the height we want to shove the box out of the colliding object to the top
                        {
                            /*
                            if(colliding.y > hitbox.y + (hitbox.height/2)){
                                hitbox.y += colliding.height;
                            }
                            else{
                                
                            }
                            */
                            hitbox.y -= colliding.height;
                            velocity.Y = 0;//makes sure we dont get an infinate amount of velocity so the player doesnt fall through the ground
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
