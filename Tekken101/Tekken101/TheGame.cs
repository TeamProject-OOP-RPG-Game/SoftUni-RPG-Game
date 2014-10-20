namespace Tekken101
{
    using System;
    using System.Windows.Forms;
    using Interfaces;
    using Renderer;

    public partial class TheGame : Form
    {
        public TheGame()
        {
            InitializeComponent();
        }
        private void TheGame_Load(object sender, EventArgs e)
        {
            IUserInputInterface controller = new MouseController(this);
            IPaintInterface painter = new PaintBrush(this);
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
