using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_test
{
    public class Player : BaseClass
    {
        public Player(Texture2D texture, Vector2 position) : base(texture, position){}

        public override void Update(){
            KeyboardState kstate = Keyboard.GetState();
            if(kstate.IsKeyDown(Keys.D)){
                position.X++;
            }
            if(kstate.IsKeyDown(Keys.A)){
                position.X--;
            }
            if(kstate.IsKeyDown(Keys.W)){
                position.Y--;
            }
            if(kstate.IsKeyDown(Keys.S)){
                position.Y++;
            }
        }
    }
}