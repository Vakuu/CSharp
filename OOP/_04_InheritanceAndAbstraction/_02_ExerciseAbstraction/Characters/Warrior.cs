using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    public class Warrior : Character
    {
        public Warrior()
            : base(150,100,125)
        {
        }
        public override void Attack(Character target)
        {
            this.Mana -= 50;//hit1 using 100 mana
            target.Health -= this.Damage;//1xDamage
            this.Health += this.Damage / 2;//50% vampiric
        }
    }
}
