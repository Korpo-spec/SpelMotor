using System;
using Raylib_cs;

namespace GameEngine
{
    public class Platform : GameObject
    {
        public Rectangle hitbox = new Rectangle();

        public Platform(int x, int y, int width, int height){
            hitbox.x = x;
            hitbox.y = y;
            hitbox.width = width;
            hitbox.height = height;

            Character.Plattforms.Add(this);
        }

        public Platform(){

        }
        public override void Draw(){
            Raylib.DrawRectangleRec(hitbox, Color.DARKBROWN);
        }

        

    }
}