using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace Platformer
{
    class Player
    {
        Sprite sprite = new Sprite();
        public Player()
        {
        }
        public void Load(ContentManager content)
        {
            sprite.Load(content, "hero");
        }
        public void Update(float deltaTime)
        {

            if (Keyboard.GetState().IsKeyDown(Keys.R) == true)
            {
                sprite.position.X += sprite.speed * deltaTime;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.D) == true)
            {
                sprite.position.Y += sprite.speed * deltaTime;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.L) == true)
            {
                sprite.position.X -= sprite.speed * deltaTime;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.U) == true)
            {
                sprite.position.Y -= sprite.speed * deltaTime;
            }
            sprite.position = sprite.position;
            sprite.Update(deltaTime);
        }
        public void Draw(SpriteBatch spritebatch)
        {
            sprite.Draw(spritebatch);
        }
    }
}
