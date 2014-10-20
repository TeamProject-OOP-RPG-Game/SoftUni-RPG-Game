using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tekken101.Engine
{
    public class MouseController : IUserInputInterface
    {
        public event EventHandler OnRightPressed;

        public event EventHandler OnLeftPressed;

        public event EventHandler OnSpellOnePressed;

        public MouseController(Form form)
        {
            var pb = new PictureBox();
            pb.Size = new Size(400, 400);
            pb.Location = new Point(0, 0);
            form.Controls.Add(pb);
            pb.MouseClick += ButtonMouseClick;
            form.MouseClick += FormMouseClick;
        }

        private void ButtonMouseClick(object sender, MouseEventArgs e)
        {
            if (this.OnLeftPressed != null)
            {
                this.OnLeftPressed(this, new EventArgs());
            }
        }

        private void FormMouseClick(object sender, MouseEventArgs e)
        {
 
        }

        private void FormKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D:
                    if (this.OnRightPressed != null)
                    {
                        this.OnRightPressed(this, new EventArgs());
                    }
                    break;
                case Keys.A:
                    if (this.OnLeftPressed != null)
                    {
                        this.OnLeftPressed(this, new EventArgs());
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
