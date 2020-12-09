using System.Numerics;
using System;
using Raylib_cs;

namespace GameEngine
{
    public class Animation
    {
        int timer; 

        Texture2D spriteSheet = Raylib.LoadTexture(@"AnimTest.png");
        Vector2 positionInTexture = new Vector2(0, 0);
        Rectangle frameSize = new Rectangle(0, 0, 16, 12); 

        /*void DrawAnimation(Texture2D spriteSheet, Rectangle frameSize, Vector2 positionInTexture)
        {
            Raylib.DrawTextureRec(spriteSheet, frameSize, positionInTexture, Color.BLANK);
        }*/
    }
}
