using System;
using Raylib_cs;
using System.Numerics;


namespace GameEngine
{
    public class Player : Character
    {
        /*Weapon class goes here*/

        private float jumpForce =200;

        public override void Update()
        {
            float deltaTime = Raylib.GetFrameTime();
            velocity.Y += currentLevel.gravity * 10 * deltaTime;
            if(Raylib.IsKeyDown(KeyboardKey.KEY_D))
            {
                body.x += 4;
                position.X += 4;
            }
            if(Raylib.IsKeyDown(KeyboardKey.KEY_A))
            {
                body.x -= 4;
                position.X -= 4;
            }
            if(Raylib.IsKeyDown(KeyboardKey.KEY_SPACE))
            {
                velocity.Y = -jumpForce;
            }
            if(Raylib.IsKeyDown(KeyboardKey.KEY_L)){
                Level.LoadLevel("testLevel");
            }
            

            body.x = position.X;
            body.y += velocity.Y * deltaTime;
            
            CheckForCollision();

            position.Y = body.y;
            Level.camera.target = position + new Vector2(25, 25);
        }

        public override void Draw()
        {
            
            Raylib.DrawRectangleRec(body, Color.DARKBLUE);
            
        }

        public void AddToInventory(Item item)
        {

        }

        public void RemoveFromInventory(int n)
        {

        }

        public void UseItem(int n)
        {
            
        }

        /*public string GetItemInfo(int n) 
        {
            return;
        }*/

        /*public int GetInventoryLength()
        {
            return;
        }*/
    }
}
