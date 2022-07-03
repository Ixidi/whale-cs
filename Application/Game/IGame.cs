using System.Numerics;

namespace Application.Game;

public interface IGame
{
    float Time { get; }
    int UnderMouseObject { get; }
   IRenderer Renderer { get; }
}