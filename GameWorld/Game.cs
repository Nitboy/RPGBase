using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace GameController
{
    public class Game
    {
        private ICharacter player;
        private IMonster monster;
        private IEncounter encounter;

        public Game()
        {
        }

        public IEncounter CreateNewEncounter()
        {
            player =  CharacterFactory.CreatePlayerCharacter();
            monster = CharacterFactory.CreateMonster();
            encounter = new Encounter(player, monster);
            return encounter;
        }

        public IEncounter CreateNewEncounter()
        {
            player = CharacterFactory.CreatePlayerCharacter();
            monster = CharacterFactory.CreateMonster();
            encounter = new Encounter(player, monster);
            return encounter;
        }
    }
}
