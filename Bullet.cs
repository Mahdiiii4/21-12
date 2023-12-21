using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace _21_12
{
    public class Bullet : Entity
    {
        private Rectangle hitbox;
        private Vector2 direaction;
        private float speed = 8;
        
        public Bullet(Texture2D texture, Vector2 startPosition):base(texture)
        {
            hitbox.Width= 10;
            hitbox.Height= 10;
            color = Color.Black;
            position = startPosition;
            MouseState mouse = Mouse.GetState();
            direaction = mouse.Position.ToVector2() - startPosition;
            direaction.Normalize();
        }

        public void Update()
        {
            position+= direaction * speed;
        }


    }
}