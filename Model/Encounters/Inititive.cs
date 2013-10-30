using System.Collections.Generic;

namespace Model
{
    public class Inititive
    {
        public List<ICharacter> InititiveList { get; set; }
        public int InitiativeIndex { get; set; }

        public Inititive()
        {
            InititiveList = new List<ICharacter>();
            InitiativeIndex = 0;
        }

        public void Add(ICharacter character)
        {
            InititiveList.Add(character);
        }

        public ICharacter CurrentCharacter()
        {
            return InititiveList[InitiativeIndex];
        }


        public ICharacter MoveNext()
        {
            InitiativeIndex = (InitiativeIndex+1) % InititiveList.Count;

            return InititiveList[InitiativeIndex];
        }
    }
}
