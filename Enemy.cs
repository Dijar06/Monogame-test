using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Monogame_test
{
    public class Enemy : BaseClass
    {
        float velocity = -1;
        float timer = 0;
        public Enemy(Texture2D texture, Vector2 position) : base(texture, position){
            hitbox.Size = new Point(10,10);
        }

        public override void Update(){
            timer += 1f/60f;
            if(position.Y <= 0 || position.Y >= 460){
                velocity *= -1;
            }
            if(timer >= 100){
                velocity = 0;
            }
            position.Y += velocity;
            hitbox.Location = position.ToPoint();
            // y = y + (+1) = y + 1
        }
    }
}