using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_test;

public class Game1 : Game
{
    Texture2D xwing;
    Player player;
    Enemy enemy;
    Bullet bullet;
    Vector2 playerPos = new Vector2(100,300);
    Vector2 enemyPos = new Vector2(500,300);

    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        // TODO: use this.Content to load your game content here
        //xwing = Content.Load<Texture2D>("xwing");
        xwing = new Texture2D(GraphicsDevice, 1, 1);
        xwing.SetData(new Color[]{Color.White});

        player = new Player(xwing, playerPos);
        enemy = new Enemy(xwing, enemyPos);
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here
        player.Update();
        enemy.Update();
        foreach (var bullet in player.Bullets){
            bullet.Update();
        }
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // TODO: Add your drawing code here
        _spriteBatch.Begin();
        player.Draw(_spriteBatch);
        enemy.Draw(_spriteBatch);
        foreach (var bullet in player.Bullets){
            bullet.Draw(_spriteBatch);
        }
        _spriteBatch.End();

        base.Draw(gameTime);
    }
}
