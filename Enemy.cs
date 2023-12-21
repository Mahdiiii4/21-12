using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace _21_12
{
    public abstract class Enemy
    {
        protected Vector2 postion;
        protected Texture2D texture;

        protected Player target;
        protected Color color;

        public Enemy(Texture2D texture, Player target)
        {
            this.texture = texture;
            this.target = target;
        }
        public abstract void Update();

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            Rectangle rec = new Rectangle();
            rec.Location = postion.ToPoint();
            rec.Width = 25;
            rec.Height = 50;
            spriteBatch.Draw(texture,rec, color);
        }

    }
}