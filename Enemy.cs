using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace _21_12
{
    public abstract class Enemy : Entity
    {
        protected Vector2 postion;
        protected Player target;

        public Enemy(Texture2D texture, Player target):base(texture)
        {
            this.target = target;
        }
        public abstract void Update();

    }
}