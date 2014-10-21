namespace Tekken101.Renderer
{

    using System.Collections.Generic;
    using System.Linq;
    using System.Drawing;
    using System.Windows.Forms;
    using Interfaces;
    using Characters;

    public class PaintBrush : IPaintInterface
    {
        private const int ProgressBarSizeX = 500;
        private const int ProgressBarSizeY = 50;
        private const int ProgressBarY = 10;
        private const int ProgressBarEnemyX = 690;
        private const int ProgressBarPlayerX = 10;

        private const int PictureBoxSizeX = 64;
        private const int PictureBoxSizeY = 64;

        private const string PlayerImagePath = "../../Images/Characters/BaekS.png";
        private const string EnemyImagePath = "../../Images/Characters/LeeRS.png";

        private Image playerImage, enemyImage;
        private Form gameWindow;
        private List<PictureBox> pictureBoxes;
        private List<ProgressBar> progressBars;

        public PaintBrush(Form form)
        {
            this.gameWindow = form;
            this.LoadResources();
            this.InitialiseButtons();
            this.pictureBoxes = new List<PictureBox>();
            this.progressBars = new List<ProgressBar>();
        }

        public void AddObject(IRenderable renderableObject)
        {
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
            picBoxLeft.Location = new Point(50, 500);
            picBoxLeft.Size = new Size(PictureBoxSizeX, PictureBoxSizeY);
            this.gameWindow.Controls.Add(picBoxLeft);

            // image right
            var imageRight = Image.FromFile("../../Images/right.png");
            var picBoxRight = new PictureBox();
            picBoxRight.Name = "pictureRight";
            picBoxRight.BackColor = Color.Transparent;
            picBoxRight.Image = imageRight;
            picBoxRight.Parent = this.gameWindow;
            picBoxRight.Location = new Point(120, 500);
            picBoxRight.Size = new Size(PictureBoxSizeX, PictureBoxSizeY);
            this.gameWindow.Controls.Add(picBoxRight);
            
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

        public void LoadResources()
        {
            this.playerImage = Image.FromFile(PlayerImagePath);
            this.enemyImage = Image.FromFile(EnemyImagePath);            
        }
    }
}
