using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Monster : Character, IMonster
    {
        public Monster(int might, int magic) : base("Monster",might, magic)
        {
        }

        public IEvent MonsterAction()
        {
            return new MightAttack();
        }

    }
}
