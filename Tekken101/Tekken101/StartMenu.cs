using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tekken101
{
    public partial class StartMenu : Form
    {       
        public StartMenu()
        {
            InitializeComponent();
           
        }

        private void StartGame(object sender, System.Windows.Forms.MouseEventArgs e)
        {

            Form theGame = new TheGame((PictureBox)sender);
            theGame.Show();
            this.Hide();
        }

    }
}
