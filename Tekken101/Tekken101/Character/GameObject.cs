namespace Tekken101
{

    using Interfaces;
    using Renderer;

    public abstract class GameObject : IGameObject, IRenderable
    {
        private int x;
        public GameObject(int X, int Y, int SizeX, int SizeY)
        {
            this.X = X;
            this.Y = Y;
            this.SizeX = SizeX;
            this.SizeY = SizeY;
        }

        public int X
        {
            get
            {
                return this.x;
            }

            set
            {
                this.x = value;
            }
        }

        public int Y { get; set; }

        public int SizeX { get; set; }

        public int SizeY { get; set; }

        public SpriteType SpriteType { get; set; }
    }
}
