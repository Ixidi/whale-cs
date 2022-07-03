using System.Numerics;

namespace Application.Game;

public interface IRenderer
{
     Matrix4x4 ViewMatrix { get; }
     Matrix4x4 ProjectionMatrix { get; }
     Matrix4x4 ViewProjectionMatrix { get; } // view matrix * proj matrix
     int Width { get; }
     int Height { get; }
}