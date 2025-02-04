using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Monogame_test
{
    public class Bullet : BaseClass
    {
        Vector2 velocity;

        public Bullet(Texture2D texture, Vector2 position) : base(texture, position){}


        public override void Update(){
            position.Y--;
        }
    }
}