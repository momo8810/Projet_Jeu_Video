using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace ProjetJeuVideo;

/*
 * Class Static SpriteEntityManager
 * 
 * Nous permettra de gerer le comportement de tous nos objets sur le
 * l'écran.
 * Garde une trace de toutes les entités(ici les sprites à savoir : le joeur, les monstres et les projectiles tirés par le joeur lors de son attaque ) du jeu et
 * effectue une détection de collision
 */
static class SpriteEntityManager
{
    static List<SpriteEntity> sprites = new List<SpriteEntity>();
    static bool isUpdating ;
    static List<SpriteEntity> addedsprites = new List<SpriteEntity>();
    
    public static int Count => sprites.Count;

    public static void Add(SpriteEntity sprite)
    {
        if (!isUpdating)
        {
            sprites.Add(sprite);
        }
        else
        {
            addedsprites.Add(sprite);
        }
    }

    public static void Update()
    {
        isUpdating = true;

        foreach (var sprite in sprites)
        {
            sprite.update();
        }
        
        isUpdating = false;

        foreach (var sprite in sprites)
        {
            sprite.update();
        }
        
        addedsprites.Clear();
        
        sprites = sprites.Where(x=>!x.isExpired).ToList();
    }

    public static void Draw(SpriteBatch spriteBatch)
    {
        foreach (var sprite in sprites)
        {
            sprite.Draw(spriteBatch);
            
        }
    }
    
}