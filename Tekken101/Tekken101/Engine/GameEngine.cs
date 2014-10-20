

using Tekken101.Renderer;

namespace Tekken101
{
    using System;
    using Characters;
    using Interfaces;

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
            player = new Alien(SpriteType.Player, 100, "alien", "I'm The best", 100, 10, 100, 5, 5);
            enemy = new JohnTheBaptist(SpriteType.Enemy, 500, "John", "I'm The best", 100, 10, 100, 5, 5);
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
            throw new NotImplementedException();
        }

        private void MovePlayerLeft()
        {
            throw new NotImplementedException();
        }
        public void PlayNextTurn()
        {
            
        }
    }
}

