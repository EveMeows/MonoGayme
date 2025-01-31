using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace MonoGayme.Core.Abstractions;

public interface IUpdateableComponent
{
    void Update(GameTime time);
}
