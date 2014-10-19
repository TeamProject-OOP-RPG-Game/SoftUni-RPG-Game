using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheGame
{
    public interface IUserInputInterface
    {
        event EventHandler OnRightPressed;
        event EventHandler OnLeftPressed;
        event EventHandler OnSpellOnePressed;
    }
}
