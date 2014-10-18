using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGame.Interfaces;
using TheGame.Structure;

namespace TheGame.Renderers
{
    public interface IRenderable : IGameObject
    {
        SpriteType SpriteType { get; set; }
    }
}
