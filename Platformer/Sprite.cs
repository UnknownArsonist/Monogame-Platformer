using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace Platformer
{
    class Sprite
    {
        public Vector2 position = Vector2.Zero;
        public Vector2 offset = Vector2.Zero;
        public int speed = 50;
        Texture2D texture;
        public Sprite()
        {
        }
        public void Load(ContentManager content, string asset)
        {
            texture = content.Load<Texture2D>(asset);
        }
        public void Update(float deltaTime)
        {
        }
        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(texture, position + offset, Color.White);
        }
    }
}
