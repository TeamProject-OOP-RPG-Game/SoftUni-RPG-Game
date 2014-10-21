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

        public event EventHandler OnSpellTwoPressed;

        public event EventHandler OnSpellThreePressed;

        public event EventHandler OnSpellFourPressed;

        public MouseController(Form form)
        {
            form.Controls["pictureLeft"].MouseClick += LeftMove;
            form.Controls["pictureRight"].MouseClick += RightMove;
            form.Controls["pictureSpellOne"].MouseClick += UseSpellOne;
            form.Controls["pictureSpellTwo"].MouseClick += UseSpellTwo;
            form.Controls["pictureSpellThree"].MouseClick += UseSpellThree;
            form.Controls["pictureSpellFour"].MouseClick += UseSpellFour;
           // form.Controls["pictureSpellFour"].MouseHover += ShowSpellFourDescription;
            //form.MouseClick += FormMouseClick;
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

        private void UseSpellOne(object sender, MouseEventArgs e)
        {
            if (this.OnSpellOnePressed != null)
            {
                this.OnSpellOnePressed(this, new EventArgs());
            }
        }

        private void UseSpellTwo(object sender, MouseEventArgs e)
        {
            if (this.OnSpellTwoPressed != null)
            {
                this.OnSpellTwoPressed(this, new EventArgs());
            }
        }

        private void UseSpellThree(object sender, MouseEventArgs e)
        {
            if (this.OnSpellThreePressed != null)
            {
                this.OnSpellThreePressed(this, new EventArgs());
            }
        }
        private void UseSpellFour(object sender, MouseEventArgs e)
        {
            if (this.OnSpellFourPressed != null)
            {
                this.OnSpellFourPressed(this, new EventArgs());
            }
        }
        private void FormMouseClick(object sender, MouseEventArgs e)
        {
 
        }

    }
}
