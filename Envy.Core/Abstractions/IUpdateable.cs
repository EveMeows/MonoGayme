using Microsoft.Xna.Framework;

namespace Envy.Core.Abstractions;

public interface IUpdateableComponent
{
	void Update(GameTime time);
}
