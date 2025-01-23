using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGayme.Entities;

namespace MonoGayme.Components;

public abstract class Component
{
    public Entity Parent { get; internal set; } = null!;
    public string? Name { get; set; }
}
