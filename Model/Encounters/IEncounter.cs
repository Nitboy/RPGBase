using System.Collections.Generic;

namespace Model
{
    public interface IEncounter
    {
        ICharacter PlayerCharacter { get;}

        IMonster MonsterCharacter { get; }
              Inititive Inititive { get; }

        bool AddMonsterEvent();
        bool AddPlayerEvent(IEvent playerEvent);

        EncounterStatus Status { get; }

        List<IEvent> Events { get; }

        string LastEvent { get; }
    }
}
