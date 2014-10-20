namespace Tekken101.Interfaces
{
    using Renderer;

    public interface IRenderable : IGameObject
    {
        SpriteType SpriteType { get; set; }
    }
}
