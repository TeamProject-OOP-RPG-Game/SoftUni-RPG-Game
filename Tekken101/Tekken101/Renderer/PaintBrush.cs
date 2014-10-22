namespace Tekken101.Renderer
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Drawing;
    using System.Windows.Forms;
    using Interfaces;
    using Characters;
    using Engine;

    public class PaintBrush : IPaintInterface
    {
        private const int ProgressBarSizeX = 500;
        private const int ProgressBarSizeY = 50;
        private const int ProgressBarY = 10;
        private const int ProgressBarEnemyX = 690;
        private const int ProgressBarPlayerX = 10;

        private const int PictureBoxSizeX = 64;
        private const int PictureBoxSizeY = 64;

        private const string BaekImagePathP = "../../Images/Characters/baekS.png";
        private const string ChristieImagePathP = "../../Images/Characters/christieS.png";
        private const string HeihachiImagePathP = "../../Images/Characters/heihachiS.png";
        private const string JinImagePathP = "../../Images/Characters/jinRS.png";
        private const string LeeImagePathP = "../../Images/Characters/leeS.png";
        private const string LeoImagePathP = "../../Images/Characters/leoS.png";
        private const string LiliImagePathP = "../../Images/Characters/liliRS.png";
        private const string MiguelImagePathP = "../../Images/Characters/miguelS.png";
        private const string NinaImagePathP = "../../Images/Characters/ninaS.png";
        private const string SteveImagePathP = "../../Images/Characters/steveRS.png";

        private const string BaekImagePathE = "../../Images/Characters/baekRS.png";
        private const string ChristieImagePathE = "../../Images/Characters/christieRS.png";
        private const string HeihachiImagePathE = "../../Images/Characters/heihachiRS.png";
        private const string JinImagePathE = "../../Images/Characters/jinS.png";
        private const string LeeImagePathE = "../../Images/Characters/leeRS.png";
        private const string LeoImagePathE = "../../Images/Characters/leoRS.png";
        private const string LiliImagePathE = "../../Images/Characters/liliS.png";
        private const string MiguelImagePathE = "../../Images/Characters/miguelRS.png";
        private const string NinaImagePathE = "../../Images/Characters/ninaRS.png";
        private const string SteveImagePathE = "../../Images/Characters/steveS.png";

        private Image playerImage, enemyImage;
        private Form gameWindow;
        private List<PictureBox> pictureBoxes;
        private List<ProgressBar> progressBars;

        public string PlayerImagePath { get; private set; }
        public string EnemyImagePath { get; private set; }
        public PaintBrush(Form form)
        {
            this.gameWindow = form;
            this.InitialiseButtons();
            this.pictureBoxes = new List<PictureBox>();
            this.progressBars = new List<ProgressBar>();
        }

        private Image GetPlayerImage(PlayerType playerType) 
        {
            switch (playerType)
            {
                case PlayerType.Baek:
                    PlayerImagePath = BaekImagePathP;
                    break;
                case PlayerType.Christie:
                    PlayerImagePath = ChristieImagePathP;
                    break;
                case PlayerType.Heihachi:
                    PlayerImagePath = HeihachiImagePathP;
                    break;
                case PlayerType.Jin:
                    PlayerImagePath = JinImagePathP;
                    break;
                case PlayerType.Lee:
                    PlayerImagePath = LeeImagePathP;
                    break;
                case PlayerType.Leo:
                    PlayerImagePath = LeoImagePathP;
                    break;
                case PlayerType.Lili:
                    PlayerImagePath = LiliImagePathP;
                    break;
                case PlayerType.Miguel:
                    PlayerImagePath = MiguelImagePathP;
                    break;
                case PlayerType.Nina:
                    PlayerImagePath = NinaImagePathP;
                    break;
                case PlayerType.Steve:
                    PlayerImagePath = SteveImagePathP;
                    break;
            }
            this.playerImage = Image.FromFile(PlayerImagePath);
            return playerImage;
        }

        private Image GetEnemyImage(PlayerType playerType)
        {
            switch (playerType)
            {
                case PlayerType.Baek:
                    EnemyImagePath = BaekImagePathE;
                    break;
                case PlayerType.Christie:
                    EnemyImagePath = ChristieImagePathE;
                    break;
                case PlayerType.Heihachi:
                    EnemyImagePath = HeihachiImagePathE;
                    break;
                case PlayerType.Jin:
                    EnemyImagePath = JinImagePathE;
                    break;
                case PlayerType.Lee:
                    EnemyImagePath = LeeImagePathE;
                    break;
                case PlayerType.Leo:
                    EnemyImagePath = LeoImagePathE;
                    break;
                case PlayerType.Lili:
                    EnemyImagePath = LiliImagePathE;
                    break;
                case PlayerType.Miguel:
                    EnemyImagePath = MiguelImagePathE;
                    break;
                case PlayerType.Nina:
                    EnemyImagePath = NinaImagePathE;
                    break;
                case PlayerType.Steve:
                    EnemyImagePath = SteveImagePathE;
                    break;
            }
            this.enemyImage = Image.FromFile(EnemyImagePath);
            return enemyImage;
        }

        public void AddObject(IRenderable renderableObject)
        {
            if ((renderableObject as BaseCharacter).SpriteType == SpriteType.Player)
            {
                GetPlayerImage((renderableObject as BaseCharacter).PlayerType);
            }
            else 
            {
                GetEnemyImage((renderableObject as BaseCharacter).PlayerType);
            }
            this.CreatePictureBox(renderableObject);
            if (renderableObject is BaseCharacter)
            {
                if (renderableObject.SpriteType == SpriteType.Player)
                {
                    this.CreateProgressBar(renderableObject as BaseCharacter, ProgressBarPlayerX);
                }
                else if (renderableObject.SpriteType == SpriteType.Enemy)
                {
                    this.CreateProgressBar(renderableObject as BaseCharacter, ProgressBarEnemyX);
                }
            }
        }

        public void RemoveObject(IRenderable renderableObject)
        {
            var picBox = GetPictureBoxByObject(renderableObject);
            this.gameWindow.Controls.Remove(picBox);
            this.pictureBoxes.Remove(picBox);
            if (renderableObject is BaseCharacter)
            {
                var progressBar = GetProgressBarByObject(renderableObject as BaseCharacter);
                this.gameWindow.Controls.Remove(progressBar);
                this.progressBars.Remove(progressBar);
            }
        }

        public void RedrawObject(IRenderable objectToBeRedrawn)
        {
            var newCoordinates = new Point(objectToBeRedrawn.X, objectToBeRedrawn.Y);
            var picBox = GetPictureBoxByObject(objectToBeRedrawn);
            picBox.Location = newCoordinates;
            if (objectToBeRedrawn is BaseCharacter)
            {
                var character = objectToBeRedrawn as BaseCharacter;
                var progressBar = GetProgressBarByObject(character);
                progressBar.Value = character.CurrentHealth;
            }
        }

        private void CreateProgressBar(BaseCharacter character, int prograssBarX)
        {
            var progressBar = new ProgressBar();
            progressBar.Size = new Size(ProgressBarSizeX, ProgressBarSizeY);
            progressBar.Location = new Point(prograssBarX, ProgressBarY);
            progressBar.Maximum = character.MaxHealth;
            progressBar.Value = character.CurrentHealth;
            progressBar.Tag = character;
            progressBars.Add(progressBar);
            this.gameWindow.Controls.Add(progressBar);
        }

        private void CreatePictureBox(IRenderable renderableObject)
        {
            var spriteImage = GetSpriteImage(renderableObject);
            var picBox = new PictureBox();
            picBox.BackColor = Color.Transparent;
            picBox.Image = spriteImage;
            picBox.Parent = this.gameWindow;
            picBox.Location = new Point(renderableObject.X, renderableObject.Y);
            picBox.Size = new Size(renderableObject.SizeX, renderableObject.SizeY);
            picBox.Tag = renderableObject;
            this.pictureBoxes.Add(picBox);
            this.gameWindow.Controls.Add(picBox);
        }

        private void InitialiseButtons()
        {
            //image left
            var imageleft = Image.FromFile("../../Images/left.png");
            var picBoxLeft = new PictureBox();
            picBoxLeft.Name = "pictureLeft";
            picBoxLeft.BackColor = Color.Transparent;
            picBoxLeft.Image = imageleft;
            picBoxLeft.Parent = this.gameWindow;
            picBoxLeft.Location = new Point(50, 530);
            picBoxLeft.Size = new Size(PictureBoxSizeX, PictureBoxSizeY);
            this.gameWindow.Controls.Add(picBoxLeft);

            // image right
            var imageRight = Image.FromFile("../../Images/right.png");
            var picBoxRight = new PictureBox();
            picBoxRight.Name = "pictureRight";
            picBoxRight.BackColor = Color.Transparent;
            picBoxRight.Image = imageRight;
            picBoxRight.Parent = this.gameWindow;
            picBoxRight.Location = new Point(120, 530);
            picBoxRight.Size = new Size(PictureBoxSizeX, PictureBoxSizeY);
            this.gameWindow.Controls.Add(picBoxRight);

            // image spellOne
            var imageSpellOne = Image.FromFile("../../Images/Spells/01-01.png");
            var picBoxSpellOne = new PictureBox();
            picBoxSpellOne.Name = "pictureSpellOne";
            picBoxSpellOne.BackColor = Color.Transparent;
            picBoxSpellOne.Image = imageSpellOne;
            picBoxSpellOne.Parent = this.gameWindow;
            picBoxSpellOne.Location = new Point(190, 530);
            picBoxSpellOne.Size = new Size(PictureBoxSizeX, PictureBoxSizeY);
            this.gameWindow.Controls.Add(picBoxSpellOne);

            // image spellTwo
            var imageSpellTwo = Image.FromFile("../../Images/Spells/01-02.png");
            var picBoxSpellTwo = new PictureBox();
            picBoxSpellTwo.Name = "pictureSpellTwo";
            picBoxSpellTwo.BackColor = Color.Transparent;
            picBoxSpellTwo.Image = imageSpellTwo;
            picBoxSpellTwo.Parent = this.gameWindow;
            picBoxSpellTwo.Location = new Point(260, 530);
            picBoxSpellTwo.Size = new Size(PictureBoxSizeX, PictureBoxSizeY);
            this.gameWindow.Controls.Add(picBoxSpellTwo);

            // image spellThree
            var imageSpellThree = Image.FromFile("../../Images/Spells/01-03.png");
            var picBoxSpellThree = new PictureBox();
            picBoxSpellThree.Name = "pictureSpellThree";
            picBoxSpellThree.BackColor = Color.Transparent;
            picBoxSpellThree.Image = imageSpellThree;
            picBoxSpellThree.Parent = this.gameWindow;
            picBoxSpellThree.Location = new Point(330, 530);
            picBoxSpellThree.Size = new Size(PictureBoxSizeX, PictureBoxSizeY);
            this.gameWindow.Controls.Add(picBoxSpellThree);

            // image spellFour
            var imageSpellFour = Image.FromFile("../../Images/Spells/01-04.png");
            var picBoxSpellFour = new PictureBox();
            picBoxSpellFour.Name = "pictureSpellFour";
            picBoxSpellFour.BackColor = Color.Transparent;
            picBoxSpellFour.Image = imageSpellFour;
            picBoxSpellFour.Parent = this.gameWindow;
            picBoxSpellFour.Location = new Point(400, 530);
            picBoxSpellFour.Size = new Size(PictureBoxSizeX, PictureBoxSizeY);
           // picBoxSpellFour.MouseHover();
            this.gameWindow.Controls.Add(picBoxSpellFour);
            
        }

        private Image GetSpriteImage(IRenderable renderableObject)
        {
            Image image;
            switch (renderableObject.SpriteType)
            {
                case SpriteType.Player:
                    image = this.playerImage;
                    break;
                case SpriteType.Enemy:
                    image = this.enemyImage;
                    break;
                default:
                    image = this.playerImage;
                    break;
            }
            return image;
        }

        private PictureBox GetPictureBoxByObject(IRenderable renderableObject)
        {
            return this.pictureBoxes.First(p => p.Tag == renderableObject);
        }

        private ProgressBar GetProgressBarByObject(BaseCharacter character)
        {
            return this.progressBars.First(p => p.Tag == character);
        }
    }
}
