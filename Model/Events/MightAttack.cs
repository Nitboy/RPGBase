using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MightAttack : IEvent
    {

        public ICharacter Actor  { get; set; }
        public ICharacter Target  { get; set; }
        public int Power  { get; set; }


        public string EventString()
        {
            if (Actor == null)
            {
                throw new ArgumentNullException("Actor");
            }
            if (Target == null)
            {
                throw new ArgumentNullException("Target");
            }

            return string.Format("{0} hit {1} for {2} damage.", Actor.Name, Target.Name, Power);
        }

    }
}
