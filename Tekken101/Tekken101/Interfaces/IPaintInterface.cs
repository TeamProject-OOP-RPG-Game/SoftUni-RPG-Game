﻿namespace Tekken101.Interfaces
{
    public interface IPaintInterface
    {
        void AddObject(IRenderable renderableObject);

        void RemoveObject(IRenderable renderableObject);

        void RedrawObject(IRenderable renderableObject);
    }
}
