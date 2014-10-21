namespace Tekken101
{
    using System;
    public interface IUserInputInterface
    {
        event EventHandler OnRightPressed;
        event EventHandler OnLeftPressed;
        event EventHandler OnSpellOnePressed;
        event EventHandler OnSpellTwoPressed;
        event EventHandler OnSpellThreePressed;
        event EventHandler OnSpellFourPressed;
    }
}
