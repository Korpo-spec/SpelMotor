using System;
using Raylib_cs;

namespace GameEngine
{
    public class Player : Character
    {
        /*Weapon class goes here*/

        private float jumpForce =200;

        public override void Update()
        {
            float deltaTime = Raylib.GetFrameTime();
            velocity.Y += gravity * 10 * deltaTime;
            if(Raylib.IsKeyDown(KeyboardKey.KEY_D))
            {
                body.x += 1;
            }
            if(Raylib.IsKeyDown(KeyboardKey.KEY_SPACE))
            {
                velocity.Y = -jumpForce;
            }

            body.y += velocity.Y * deltaTime;

            CheckForCollision();
        }

        public override void Draw()
        {
            Raylib.DrawRectangleRec(body, Color.DARKBLUE);
        }
    }
}
