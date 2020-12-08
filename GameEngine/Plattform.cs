using System;
using Raylib_cs;

namespace GameEngine
{
    public class Plattform : GameObject
    {
        public Rectangle hitbox = new Rectangle();

        public Plattform(int x, int y, int width, int height){
            hitbox.x = x;
            hitbox.y = y;
            hitbox.width = width;
            hitbox.height = height;

            Character.Plattforms.Add(this);
        }

        public Plattform(){

        }
        public override void Draw(){
            Raylib.DrawRectangleRec(hitbox, Color.DARKBROWN);
        }

        

    }
}
