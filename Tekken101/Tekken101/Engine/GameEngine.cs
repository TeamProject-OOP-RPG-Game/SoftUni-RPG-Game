

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
        public GameEngine(IUserInputInterface controller, IPaintInterface painter, PlayerType playerType)
        {
            SubscribeToUserInput(controller);
            InitializeCharacters(playerType);
            this.painter = painter;
            painter.AddObject(player);
            painter.AddObject(enemy);
        }

        private void InitializeCharacters(PlayerType playerType)
        {
            InitializePlayer(playerType);
            InitializeEnemy(playerType);
        }

        private void InitializePlayer(PlayerType playerType)
        {
            switch (playerType)
            {
                case PlayerType.Baek:
                    this.player = new Baek(SpriteType.Player, 100, "Baek", "Assassin", 100, 30, 20, 10, 10);
                    break;
                case PlayerType.Christie:
                    this.player = new Christie(SpriteType.Player, 100, "Christie", "Assassin", 100, 30, 20, 10, 10);
                    break;
                case PlayerType.Heihachi:
                    this.player = new Heihachi(SpriteType.Player, 100, "Heihachi", "Berserk", 100, 30, 20, 10, 10);
                    break;
                case PlayerType.Jin:
                    this.player = new Jin(SpriteType.Player, 100, "Jin", "Berserk", 100, 30, 20, 10, 10);
                    break;
                case PlayerType.Lee:
                    this.player = new Lee(SpriteType.Player, 100, "Lee", "Assassin", 100, 30, 20, 10, 10);
                    break;
                case PlayerType.Leo:
                    this.player = new Leo(SpriteType.Player, 100, "Leo", "Assassin", 100, 30, 20, 10, 10);
                    break;
                case PlayerType.Lili:
                    this.player = new Lili(SpriteType.Player, 100, "Lili", "Assassin", 100, 30, 20, 10, 10);
                    break;
                case PlayerType.Miguel:
                    this.player = new Miguel(SpriteType.Player, 100, "Miguel", "Berserk", 100, 30, 20, 10, 10);
                    break;
                case PlayerType.Nina:
                    this.player = new Nina(SpriteType.Player, 100, "Nina", "Assassin", 100, 30, 20, 10, 10);
                    break;
                case PlayerType.Steve:
                    this.player = new Steve(SpriteType.Player, 100, "Steve", "Berserk", 100, 30, 20, 10, 10);
                    break;
            }
        }

        private void InitializeEnemy(PlayerType playerType)
        {
            // TODO: Enemy List all characters expect player 
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

        private void MoveObjectIfPossible(ICharacter player, ICharacter enemy, int distance)
        {
            if ((player.X + distance) >= (enemy.X - 160))
            {
                player.Move(0);
            }
            else if (player.X + distance <= 0)
            {
                player.X = 0;
            }
            else
            {
                player.Move(distance);
            }
        }

        private void MovePlayerRight()
        {
            MoveObjectIfPossible(player, enemy, 50);
            painter.RedrawObject(player);
        }

        private void MovePlayerLeft()
        {
            MoveObjectIfPossible(player, enemy, -50);
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

