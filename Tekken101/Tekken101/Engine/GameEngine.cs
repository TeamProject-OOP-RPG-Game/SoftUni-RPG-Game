

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
            enemy = new Baek(SpriteType.Enemy, 900, "John", "I'm The best", 100, 10, 100, 5, 5);
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
            userInteface.OnSpellOnePressed += (sender, args) => this.UseSpellOne();
            userInteface.OnSpellTwoPressed += (sender, args) => this.UseSpellTwo();
            userInteface.OnSpellThreePressed += (sender, args) => this.UseSpellThree();
            userInteface.OnSpellFourPressed += (sender, args) => this.UseSpellFour();
        }

        private void MovePlayerRight()
        {
            player.Move(50);
            painter.RedrawObject(player);
        }

        private void MovePlayerLeft()
        {
            player.Move(-50);
            painter.RedrawObject(player);
        }

        private void UseSpellOne()
        {
            player.CastSkillOne(enemy);
            painter.RedrawObject(enemy);
        }
        private void UseSpellTwo()
        {
            player.CastSkillTwo(enemy);
            painter.RedrawObject(enemy);
        }
        private void UseSpellThree()
        {
            player.CastSkillThree(enemy);
            painter.RedrawObject(enemy);
            
        }
        private void UseSpellFour()
        {
            player.CastSkillFour(enemy);
            painter.RedrawObject(enemy);
        }
        public void PlayNextTurn()
        {
            painter.RedrawObject(player);
        }

        public void ShowSpellFourDescription()
        {
            
        }
    }
}

