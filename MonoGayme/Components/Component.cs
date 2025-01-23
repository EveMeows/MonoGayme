using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGayme.Entities;

namespace MonoGayme.Components;

public abstract class Component
{
    public Entity Parent { get; private set; } = null!;
    public string? Name { get; set; }

    public void SetParent(Entity parent) => Parent = parent;

    public virtual void Update(GameTime time) {}
    public virtual void Draw(SpriteBatch batch, Camera2D? camera = null) {}
}
