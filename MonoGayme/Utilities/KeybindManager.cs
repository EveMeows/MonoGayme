using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;

namespace MonoGayme.Utilities;

public abstract record Keybind(string Name);

public sealed record KeyboardKeybind(string Name, Keys Key) : Keybind(Name);
public sealed record ControllerKeybind(string Name, Buttons Key) : Keybind(Name);

public static class KeybindManager
{
    private static readonly List<Keybind> _keybinds = [];

    public static void Add<T>(T keybind) where T : Keybind
        => _keybinds.Add(keybind);

    public static Keys? GetKey(string name)
    {
        Keybind? bind = _keybinds.FirstOrDefault(x => x.Name == name);
        if (bind is null) return null;

        if (bind is KeyboardKeybind keybind) return keybind.Key;
        return null;
    }

    public static Buttons? GetButton(string name)
    {
        Keybind? bind = _keybinds.FirstOrDefault(x => x.Name == name);
        if (bind is null) return null;

        if (bind is ControllerKeybind keybind) return keybind.Key;
        return null;
    }
}
