using TheGame.Interfaces;
using TheGame.Structure;

namespace TheGame.Renderers
{
    public interface IRenderable : IGameObject
    {
        SpriteType SpriteType { get; set; }
    }
}
