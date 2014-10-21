

namespace Tekken101.Engine
{
    using System;
    using Characters;
    using Interfaces;
    using Tekken101.Renderer;

    public class GameEngine : IGameEngine
    {
        private IPaintInterface painter;
        private BaseCharacter player;
        private BaseCharacter enemy;
        public GameEngine(IUserInputInterface controller, IPaintInterface painter)
        {
            SubscribeToUserInput(controller);
            InitializeCharacters();
            this.painter = painter;
            painter.AddObject(player);
            painter.AddObject(enemy);
        }

        private void InitializeCharacters()
        {
            player = new Nina(SpriteType.Player, 100, "alien", "I'm The best", 100, 10, 100, 5, 5);
            enemy = new Baek(SpriteType.Enemy, 500, "John", "I'm The best", 100, 10, 100, 5, 5);
        }

        public void StartGame()
        {
        }

        public void EndGame()
        {
            throw new NotImplementedException();
        }

        private void SubscribeToUserInput(IUserInputInterface userInteface)
        {
            userInteface.OnLeftPressed += (sender, args) => this.MovePlayerLeft();
            userInteface.OnRightPressed += (sender, args) => this.MovePlayerRight();
        }

        private void MovePlayerRight()
        {
            player.Move(50);
            painter.RedrawObject(player);
        }

        private void MovePlayerLeft()
        {
            player.Move(-50); 
            painter.RemoveObject(player);
            painter.AddObject(player);
            //painter.RedrawObject(player);
        }
        public void PlayNextTurn()
        {
            painter.RedrawObject(player);
        }
    }
}

