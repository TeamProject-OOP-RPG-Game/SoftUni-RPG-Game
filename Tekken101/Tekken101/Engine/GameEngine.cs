﻿

using System.Windows.Forms;

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
        private PlayerType playerType;

        public GameEngine(IUserInputInterface controller, IPaintInterface painter, PlayerType playerType)
        {
            SubscribeToUserInput(controller);
            this.playerType = playerType;
            InitializeCharacters(playerType);
            this.painter = painter;
            this.painter.AddObject(player);
            this.painter.AddObject(enemy);
        }

        private void InitializeCharacters(PlayerType playerType)
        {
            
            this.InitializePlayer(playerType);
            this.InitializeEnemy();
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

        private void InitializeEnemy()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 10);
            switch (randomNumber)
            {
                    
                case 0:
                    this.enemy = new Baek(SpriteType.Enemy, 900, "Baek", "Assassin", 100, 30, 20, 10, 10);
                    break;
                case 1:
                    this.enemy = new Christie(SpriteType.Enemy, 900, "Christie", "Assassin", 100, 30, 20, 10, 10);
                    break;
                case 2:
                    this.enemy = new Heihachi(SpriteType.Enemy, 900, "Heihachi", "Berserk", 100, 30, 20, 10, 10);
                    break;
                case 3:
                    this.enemy = new Jin(SpriteType.Enemy, 900, "Jin", "Berserk", 100, 30, 20, 10, 10);
                    break;
                case 4:
                    this.enemy = new Lee(SpriteType.Enemy, 900, "Lee", "Assassin", 100, 30, 20, 10, 10);
                    break;
                case 5:
                    this.enemy = new Leo(SpriteType.Enemy, 900, "Leo", "Assassin", 100, 30, 20, 10, 10);
                    break;
                case 6:
                    this.enemy = new Lili(SpriteType.Enemy, 900, "Lili", "Assassin", 100, 30, 20, 10, 10);
                    break;
                case 7:
                    this.enemy = new Miguel(SpriteType.Enemy, 900, "Miguel", "Berserk", 100, 30, 20, 10, 10);
                    break;
                case 8:
                    this.enemy = new Nina(SpriteType.Enemy, 900, "Nina", "Assassin", 100, 30, 20, 10, 10);
                    break;
                case 9:
                    this.enemy = new Steve(SpriteType.Enemy, 900, "Steve", "Berserk", 100, 30, 20, 10, 10);
                    break;
            }
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
            PlayEnemyTurn();
        }

        private void MovePlayerLeft()
        {
            MoveObjectIfPossible(player, enemy, -50);
            painter.RedrawObject(player);
            PlayEnemyTurn();
        }

        private void UseSpellOne()
        {
            bool isHit = player.CastSkillOne(enemy);
            painter.DrawIsHit(isHit);
            painter.RedrawObject(enemy);
            PlayEnemyTurn();
        }

        private void PlayEnemyTurn()
        {
            if (enemy.CurrentHealth == 0)
            {
                StartGame();
            }
            else
            {
                Timer timer = new Timer();
                timer.Interval = 2000;
                timer.Tick += (s, args) =>
                {
                    enemy.CastSkillOne(player);
                    PlayNextTurn();
                    timer.Stop();
                };
                timer.Start();
            }

           
        }
        private void UseSpellTwo()
        {
            player.CastSkillTwo(enemy);
            painter.RedrawObject(enemy);
            PlayEnemyTurn();
        }
        private void UseSpellThree()
        {
            player.CastSkillThree(enemy);
            painter.RedrawObject(enemy);
            PlayEnemyTurn();

        }
        private void UseSpellFour()
        {
            player.CastSkillFour(enemy);
            painter.RedrawObject(enemy);
            PlayEnemyTurn();
        }
        public void PlayNextTurn()
        {
            painter.RedrawObject(player);
            if (player.CurrentHealth == 0)
            {
                EndGame();
            }
        }

        public void StartGame()
        {
            painter.RemoveObject(this.player);
            painter.RemoveObject(this.enemy);
            InitializeCharacters(this.playerType);
            painter.AddObject(this.player);
            painter.AddObject(this.enemy);
        }

        public void EndGame()
        {
            Form LoseForm = new LoseScreen();
            LoseForm.Show();

            Timer timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += (s, args) => Environment.Exit(1);

            timer.Start();
        }
    }
}

