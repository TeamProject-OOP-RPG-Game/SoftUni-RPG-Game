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
        private PlayerType type;

        public TheGame(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
            string nameOfPlayer = pictureBox.Name;
            GetPlayerType(nameOfPlayer);
            InitializeComponent();

        }

        private void TheGame_Load(object sender, EventArgs e)
        {
            IPaintInterface painter = new PaintBrush(this);
            IUserInputInterface controller = new MouseController(this);

            IGameEngine engine = new GameEngine(controller, painter, this.type);

            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Tick += (s, args) =>
            {
                engine.PlayNextTurn();
            };

            timer.Start();
        }

        private void GetPlayerType(string nameOfPlayer)
        {
            switch (nameOfPlayer)
            {
                case "baek":
                    type = PlayerType.Baek;
                    break;
                case "christie":
                    type = PlayerType.Christie;
                    break;
                case "heihachi":
                    type = PlayerType.Heihachi;
                    break;
                case "jin":
                    type = PlayerType.Jin;
                    break;
                case "lee":
                    type = PlayerType.Lee;
                    break;
                case "leo":
                    type = PlayerType.Leo;
                    break;
                case "lili":
                    type = PlayerType.Lili;
                    break;
                case "miguel":
                    type = PlayerType.Miguel;
                    break;
                case "nina":
                    type = PlayerType.Nina;
                    break;
                case "steve":
                    type = PlayerType.Steve;
                    break;
            }
        }
    }
}
