using System;
using Raylib_cs;

namespace GameEngine
{
    public class Player : Character
    {
        /*Weapon class goes here*/

        Rectangle body = new Rectangle(10, 10, 50, 50);

        public override void Update()
        {
            if(Raylib.IsKeyDown(KeyboardKey.KEY_D))
            {
                body.x += 1;
            }
        }

        public override void Draw()
        {
            Raylib.DrawRectangleRec(body, Color.DARKBLUE);
        }
    }
}
