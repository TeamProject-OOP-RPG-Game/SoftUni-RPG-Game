using System;
using TheGame.Renderers;
using TheGame.UI;

namespace TheGame
{
    public class GameEngine : IGameEngine
    {
        private IPaintInterface painter;
        public GameEngine(IUserInputInterface controller, IPaintInterface painter)
        {
            this.SubscribeToUserInput(controller);
            this.painter = painter;

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
            userInteface.OnLeftPressed += (sender, args) =>
            {
                this.MovePlayerLeft();
            };
            userInteface.OnRightPressed += (sender, args) =>
            {
                this.MovePlayerRight();
            };
//            userInteface.OnSpellOnePressed += (sender, args) =>
//            {
//                var spellArgs = args as SpellCastEventArgs;
//                this.CastPlayerSpell(0, spellArgs.CastX, spellArgs.CastY);
//            };
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
    }
}

