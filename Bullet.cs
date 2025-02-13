using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Monogame_test
{
    public class Bullet : BaseClass
    {
        Vector2 velocity;

        public Bullet(Texture2D texture, Vector2 position, Vector2 velocity) : base(texture, position){
            this.velocity = velocity;
            hitbox.Size = new Point(10,10);
        }

        public override void Update(){
            position += velocity;
            hitbox.Location = position.ToPoint();
        }
    }
}