using System.Collections.Generic;

namespace Model
{
    public class Encounter : IEncounter
    {
        public ICharacter PlayerCharacter { get; private set; }

        public IMonster MonsterCharacter { get; private set; }
        public Inititive Inititive { get; private set; }
        public EncounterStatus Status { get; private set; }

        public List<IEvent> Events { get; private set; }

        public string LastEvent { get; private set; }

        public Encounter(ICharacter playerCharacter, IMonster monsterCharacter)
        {
            Events = new List<IEvent>();

            PlayerCharacter = playerCharacter;
            MonsterCharacter = monsterCharacter;

            Inititive = new Inititive();
            Inititive.Add(playerCharacter);
            Inititive.Add(monsterCharacter);

            this.LastEvent = string.Format("{0} has encountered a {1}.", playerCharacter.Name, monsterCharacter.Name);
        }

        public bool AddMonsterEvent()
        {
            bool eventAdded = false;
            if (Inititive.CurrentCharacter() == MonsterCharacter)
            {
                ResolveMonsterAction();
                eventAdded = true;
            }
            return eventAdded;
        }

        private void MoveInitiative()
        {
            if (this.Status == EncounterStatus.Running)
            {
                Inititive.MoveNext();
            }
        }

        public bool AddPlayerEvent(IEvent playerEvent)
        {
            bool eventAdded = false;
            if (Inititive.CurrentCharacter() == PlayerCharacter)
            {
            
            MightAttack attack = playerEvent as MightAttack;
            if (attack != null)
            {
                attack.Actor = PlayerCharacter;
                attack.Target = MonsterCharacter;
                attack.Power = this.PlayerCharacter.MightAttack();
                this.Events.Add(attack);
                this.LastEvent = attack.EventString();

                this.MonsterCharacter.CurrentHealthPoints -= this.PlayerCharacter.MightAttack();


                if (this.MonsterCharacter.IsDead())
                {
                    this.Status = EncounterStatus.Won;
                }
            }

            MoveInitiative();
            eventAdded = true;
            }
            return eventAdded;
        }

        private void ResolveMonsterAction()
        {
            // get monster default event
            var monsterAction = this.MonsterCharacter.MonsterAction();

            // resolve event
            MightAttack attack = monsterAction as MightAttack;
            if (attack != null)
            {
                attack.Actor = MonsterCharacter;
                attack.Target = PlayerCharacter;
                attack.Power = this.MonsterCharacter.MightAttack();
                this.Events.Add(attack);
                this.LastEvent = attack.EventString();

                this.PlayerCharacter.CurrentHealthPoints -= this.MonsterCharacter.MightAttack();
                if (this.PlayerCharacter.IsDead())
                {
                    this.Status = EncounterStatus.Lost;
                }
            }

            // move initiative
            MoveInitiative();
        }
    }
}
