using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGayme.Core.Components;

namespace MonoGayme.Core.Abstractions;

public interface IDrawableComponent
{
    void Draw(SpriteBatch batch, Camera2D? camera = null);
}
