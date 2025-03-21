using Envy.Core.Components;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Envy.Core.UI;

public interface IElement
{
	Color Colour { get; set; }

	void RunAction();

	void Update(Vector2 mouse);
	void Draw(SpriteBatch batch, Camera2D? camera);
}