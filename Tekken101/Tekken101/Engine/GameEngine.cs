using System;
using TheGame.Renderers;
using TheGame.UI;

namespace TheGame
{
    public class GameEngine : IGameEngine
    {
        private IPaintInterface painter;
        private Character player;
        private Character enemy;
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
            player = new Player.Player(100, 100, 200, 140);
            enemy = new Enemy.Enemy(200, 100, 200, 100);
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

        public void Draw(IRenderable item)
        {
             painter.AddObject(item);
        }


        public void PlayNextTurn()
        {
            
        }
    }
}

