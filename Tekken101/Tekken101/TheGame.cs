using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheGame.Renderers;
using TheGame.UI;

namespace TheGame
{
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
