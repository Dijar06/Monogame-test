using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Monogame_test
{
    public abstract class BaseClass
    {
        protected Texture2D texture;
        protected Vector2 position;
        protected Rectangle hitbox = new Rectangle();

        public Rectangle Hitbox{
            get {return hitbox;}
        }

        public BaseClass(Texture2D texture, Vector2 position){
            this.texture = texture;
            this.position = position;
        }

        public abstract void Update();

        public virtual void Draw(SpriteBatch spriteBatch){
            Rectangle rectangle = new Rectangle((int)position.X, (int)position.Y, 10, 10);
            spriteBatch.Draw(texture, rectangle, Color.White);
        }
    }
}