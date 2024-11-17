using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ProjetJeuVideo;

public class MyGame : Game
{ 
    public static MyGame Instance {get; private set;}
    public static Viewport Viewport {get { return Instance.GraphicsDevice.Viewport;} }
    public static Vector2 ScreenSize { get {return new Vector2(Viewport.Width, Viewport.Height); }}
    
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
   
   

    public MyGame()
    {
        Instance = this;
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
        _graphics.PreferredBackBufferHeight = 1500;
        _graphics.PreferredBackBufferWidth = 1900;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
        SpriteEntityManager.Add(PlayerShip.Instance);
    }

    protected override void LoadContent()
    {
       Art.Load(Content);
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
            Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here
        SpriteEntityManager.Update();
        base.Update(gameTime);
      
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.Black);

        // TODO: Add your drawing code here
        _spriteBatch.Begin(SpriteSortMode.Texture, BlendState.Additive);
       SpriteEntityManager.Draw(_spriteBatch);
       _spriteBatch.End();

        base.Draw(gameTime);
    }
}