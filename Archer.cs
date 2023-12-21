using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace _21_12
{
    public class Archer : Enemy
    {
        public Archer(Texture2D texture, Player target):base(texture,target)
        {
            postion = new Vector2(500, 500);
            color = Color.DarkGreen;
        }

        public override void Update()
        {
            Vector2 direciton = target.Postion - postion;
            direciton.Normalize();
            if(Vector2.Distance(target.Postion, postion) > 100)
            {
                postion += direciton;
            }
            else if(Vector2.Distance(target.Postion, postion) < 100)
            {
                postion -= direciton;
            }
        }

    }
}