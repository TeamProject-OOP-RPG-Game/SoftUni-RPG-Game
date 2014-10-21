namespace Tekken101
{
    using System;
    using System.Windows.Forms;
    using Interfaces;
    using Renderer;
    using Tekken101.Engine;

    public partial class TheGame : Form
    {
        private PictureBox pictureBox;

        public TheGame()
        {

        }

        public TheGame(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
            string a = pictureBox.Name;
            InitializeComponent();

        }
        private void TheGame_Load(object sender, EventArgs e)
        {
            IPaintInterface painter = new PaintBrush(this);
            IUserInputInterface controller = new MouseController(this);
            IGameEngine engine = new GameEngine(controller, painter);
            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Tick += (s, args) =>
            {
                engine.PlayNextTurn();
            };

            timer.Start();
        }
    }
}
