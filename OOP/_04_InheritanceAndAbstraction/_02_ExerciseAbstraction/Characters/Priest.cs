using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    using Interfaces;
    public class Priest : Character, IHeal
    {
        public Priest()
            : base(125,200,100)
        {
        }
        public override void Attack(Character target)
        {
            this.Mana -= 100;//hit1 using 100 mana
            target.Health -= this.Damage;//1xDamage
            this.Health += this.Damage / 10;//10% vampiric
        }
        public void Heal(Character target)
        {
            this.Mana -= 100;//Heal1 using 100 mana
            target.Health += 150;//Heal target 1.5 Mana
        }
    }
}
