using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ZAD5
{
    public class Background : Sprite
    {
        public Background(Texture2D spriteTexture, int width, int height)
        : base(spriteTexture, width, height)
        {
        }
    }


    public class Ball : Sprite
    {
        /// <summary>
        /// Initial ball speed. Constant
        /// </summary>
        public const float InitialSpeed = 0.4f;
        /// <summary>
        /// Defines a factor of speed increase when bumping on the paddle.
        /// Constant
        /// </summary>
        public const float BumpSpeedIncreaseFactor = 1.01f;
        /// <summary>
        /// Defines ball size. Constant
        /// </summary>
        public const int BallSize = 50;
        /// <summary>
        /// Defines current ball speed in time.
        /// </summary>
        public float Speed { get; set; }
        /// <summary>
        /// Defines ball direction.
        /// Valid values (-1,-1), (1,1), (1,-1), (-1,1).
        /// Using Vector2 to simplify game calculation. Potentially
        /// dangerous because vector 2 can swallow other values as well.
        /// Think about creating your own, more suitable type.
        /// </summary>
        public Vector2 Direction;
        public Ball(Texture2D spriteTexture)
        : base(spriteTexture, BallSize, BallSize)
        {
            Speed = InitialSpeed;
            // Initial direction
            Direction = new Vector2(1, 1);
        }
    }



    public class Paddle : Sprite
    {
        /// <summary>
        /// Initial paddle speed. Constant
        /// </summary>
        private const float InitialSpeed = 0.9f;
        /// <summary>
        /// Paddle height. Constant
        /// </summary>
        private const int PaddleHeight = 20;
        /// <summary>
        /// Paddle width. Constant
        /// </summary>
        private const int PaddleWidth = 200;
        /// <summary>
        /// Current paddle speed in time
        /// </summary>
        public float Speed { get; set; }
        public Paddle(Texture2D spriteTexture)
        : base(spriteTexture, PaddleWidth, PaddleHeight)
        {
            Speed = InitialSpeed;
        }
        /// <summary>
        /// Overriding draw method. Masking paddle texture with black color.
        /// </summary>
        /// <param name="spriteBatch"></param>
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, Size, Color.Black);
        }
    }

}
