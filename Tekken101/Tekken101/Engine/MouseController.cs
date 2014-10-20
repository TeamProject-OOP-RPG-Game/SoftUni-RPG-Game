using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tekken101
{
    public class MouseController : IUserInputInterface
    {
        public event EventHandler OnRightPressed;

        public event EventHandler OnLeftPressed;

        public event EventHandler OnSpellOnePressed;

        public MouseController(Form form)
        {
            form.KeyDown += FormKeyDown;
            form.MouseClick += FormMouseClick;
        }

        private void FormMouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    if (OnSpellOnePressed != null)
                    {
//                        this.OnSpellOnePressed(
//                            this, new SpellCastEventArgs(e.X, e.Y));
                    }
                    break;
                default:
                    break;
            }
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
