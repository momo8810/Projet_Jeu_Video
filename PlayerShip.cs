using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ProjetJeuVideo;

    class PlayerShip : SpriteEntity
    {
        private static PlayerShip _instance;
        public static PlayerShip Instance => _instance ?? (_instance = new PlayerShip());

        private PlayerShip()
        {
            image = Art.Joueur;
            Position = MyGame.ScreenSize / 2;
            Radius = 10;
        }

        public override void update()
        {
           // throw new System.NotImplementedException();
        }
    }


