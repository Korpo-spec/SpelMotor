using System;
using Raylib_cs;

namespace GameEngine
{
    public class Platform : Collider
    {
        //public Rectangle hitbox = new Rectangle();

        public Platform(int x, int y, int width, int height){ //A constructor that creates the variables for the platform size and position
            hitbox.x = x;
            hitbox.y = y;
            hitbox.width = width;
            hitbox.height = height;
        }

        public Platform() //A constructor without parameters to be able to serialize tha class
        {

        }

        public override void Draw() //A draw override that draws out the platforms and their hitboxes
        {
            Raylib.DrawRectangleRec(hitbox, Color.DARKBROWN);
        }

        

    }
}
