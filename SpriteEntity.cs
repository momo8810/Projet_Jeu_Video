using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace ProjetJeuVideo;
/*
 * Class Abstraite SpriteEntity
 * 
 * qui va poser les bases de toutes de nos autres classes

 * Toutes nos entités (monstres, projectils et vaisseau du joueur) ont quelques propriétés de base comme
 * une image et une position.
 * IsExpired sera utilisé pour indiquer que l'entité a été détruite et
 * doit être supprimée de toute liste contenant une référence à celle-ci.
 */
abstract class SpriteEntity
{
    protected Texture2D image;
    protected Color color = Color.White; 
    public Vector2 Position;
    public Vector2 Velocity;
    public float Orientation;
    public float Radius = 20;
    public bool isExpired;

    public Vector2 Size
    {
        get
        {
            return image == null ? Vector2.Zero : new Vector2(image.Width, image.Height);
        }
    }

    public abstract void update();
    
    public virtual void Draw(SpriteBatch spriteBatch)

    {

        spriteBatch.Draw(image, Position, null, color, Orientation, Size / 2f, 1f, 0, 0);

    }

}


