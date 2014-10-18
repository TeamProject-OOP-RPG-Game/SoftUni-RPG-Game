using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.Interfaces
{
    public interface IUnit : IGameObject
    {
        int CurrentHealthPoints { get; set; }

        int MaximumHealthPoints { get; set; }

        bool IsAlive { get; }

        int AttackPoints { get; set; }

        int DefensePoints { get; set; }

        //ReactionType ReactToSpell(Spell spell);
    }
}
