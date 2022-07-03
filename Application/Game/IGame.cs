using System.Numerics;

namespace Application.Game;

public interface IGame
{
    public float Time { get; }
    public int UnderMouseObject { get; }
    public IRenderer Renderer { get; }
}