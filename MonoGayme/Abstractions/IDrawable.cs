using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGayme.Components;

namespace MonoGayme.Abstractions;

public interface IDrawableComponent
{
    void Draw(SpriteBatch batch, Camera2D? camera = null);
}
