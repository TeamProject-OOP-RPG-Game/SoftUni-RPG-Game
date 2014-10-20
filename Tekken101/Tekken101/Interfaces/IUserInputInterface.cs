namespace Tekken101
{
    using System;
    public interface IUserInputInterface
    {
        event EventHandler OnRightPressed;
        event EventHandler OnLeftPressed;
        event EventHandler OnSpellOnePressed;
    }
}
