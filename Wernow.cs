using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.MediaFoundation;

namespace _21_12
{
    public class Wernow : Enemy
    {
        public Wernow(Texture2D texture, Player target):base(texture,target)
        {
            postion = new Vector2(500, 500);
            color = Color.Red;
        }

        public override void Update()
        {
            Vector2 direciton = target.Postion - postion;
            direciton.Normalize();

            postion += direciton;
        }

    }
}