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
        private const int ProgressBarSizeX = 60;
        private const int ProgressBarSizeY = 8;
        private const int ProgressBarOffsetX = -3;
        private const int ProgressBarOffsetY = -10;

        private const string PlayerImagePath = "../../Images/asukaS.png";
        private const string EnemyImagePath = "../../Images/KidGoku.png";

        private Image playerImage, enemyImage;
        private Form gameWindow;
        private List<PictureBox> pictureBoxes;
        private List<ProgressBar> progressBars;

        public PaintBrush(Form form)
        {
            this.gameWindow = form;
            this.LoadResources();
            this.pictureBoxes = new List<PictureBox>();
            this.progressBars = new List<ProgressBar>();
        }

        public void AddObject(IRenderable renderableObject)
        {
            this.CreatePictureBox(renderableObject);
            if (renderableObject is BaseCharacter)
            {
                this.CreateProgressBar(renderableObject as BaseCharacter);
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
                this.SetProgressBarLocation(character, progressBar);
                progressBar.Value = character.CurrentHealthPoints;
            }
        }

        private void CreateProgressBar(BaseCharacter character)
        {
            var progressBar = new ProgressBar();
            progressBar.Size = new Size(ProgressBarSizeX, ProgressBarSizeY);
            this.SetProgressBarLocation(character, progressBar);
            progressBar.Maximum = character.MaxHealthPoints;
            progressBar.Value = character.CurrentHealthPoints;
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

        private void SetProgressBarLocation(BaseCharacter character, ProgressBar progressBar)
        {
            progressBar.Location = new Point(character.X + ProgressBarOffsetX, character.Y + ProgressBarOffsetY);
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
