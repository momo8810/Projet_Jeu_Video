using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
namespace ProjetJeuVideo;

static class Art
{
    public static Texture2D Joueur { get; private set; }
    public static Texture2D Feu{get; private set;}
    public static Texture2D Monstre { get; private set; }
    public static Texture2D Monstre2 { get; private set; } 

    public static void Load(ContentManager content)
    {
        Joueur = content.Load<Texture2D>("dragon");
        Feu = content.Load<Texture2D>("feu");
        Monstre = content.Load<Texture2D>("monstre");
        Monstre2 = content.Load<Texture2D>("monstre(1)");
        
    }
    
}