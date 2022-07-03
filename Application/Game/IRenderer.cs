using System.Numerics;

namespace Application.Game;

public interface IRenderer
{
    public Matrix4x4 ViewMatrix { get; }
    public Matrix4x4 ProjectionMatrix { get; }
    public Matrix4x4 ViewProjectionMatrix { get; } // view matrix * proj matrix
    public int Width { get; }
    public int Height { get; }
}