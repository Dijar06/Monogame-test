using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Monogame_test
{
    public class Bullet : BaseClass
    {
        Vector2 velocity;
        float speed = 2;

        public Bullet(Texture2D texture, Vector2 position, Color color, Vector2 velocity) : base(texture, position, color){
            this.velocity = velocity;
            hitbox.Size = new Point(100,100);
        }

        public override void Update(){
            position += velocity * speed;
            hitbox.Location = position.ToPoint();
        }
    }
}