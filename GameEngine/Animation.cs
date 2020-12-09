using System.Numerics;
using System;
using Raylib_cs;

namespace GameEngine
{
    public class Animation
    {
        private Texture2D spriteSheet;
        private Vector2 frame;
        private Rectangle frameSize;
        private int timing; 

        void DrawAnimation(Texture2D spriteSheet, Rectangle frameSize, int timer, Vector2 position)
        {
            Raylib.DrawTextureEx (spriteSheet, position, 0, 0.5f, Color.BLANK);
        }
    }
}
