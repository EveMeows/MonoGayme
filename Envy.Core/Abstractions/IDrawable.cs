using Envy.Core.Components;
using Microsoft.Xna.Framework.Graphics;

namespace Envy.Core.Abstractions;

public interface IDrawableComponent
{
	void Draw(SpriteBatch batch, Camera2D? camera = null);
}
