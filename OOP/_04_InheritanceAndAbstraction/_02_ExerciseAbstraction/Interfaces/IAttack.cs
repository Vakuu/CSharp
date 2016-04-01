using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    using Characters;
    public interface IAttack
    {
        void Attack(Character target);
    }
}
