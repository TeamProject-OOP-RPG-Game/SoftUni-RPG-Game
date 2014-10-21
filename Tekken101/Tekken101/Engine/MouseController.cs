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
//            var pb = new PictureBox();
//            pb.Size = new Size(400, 400);
//            pb.Location = new Point(0, 0);
//            pb.Name = "buttonright";
//            form.Controls.Add(pb);
//            var isFound = form.Controls.Find("button1", true);
//            isFound[0].Click += Button_Click;
            form.Controls["pictureLeft"].MouseClick += LeftMove;
            form.Controls["pictureRight"].MouseClick += RightMove;
            form.MouseClick += FormMouseClick;
        }

        private void RightMove(object sender, MouseEventArgs e)
        {
            if (this.OnRightPressed != null)
            {
                this.OnRightPressed(this, new EventArgs());
            }
        }

        private void LeftMove(object sender, MouseEventArgs e)
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
