using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public static class CharacterFactory
    {
        static Random rand = new Random();

        public static ICharacter CreatePlayerCharacter()
        {
            return new Character("Player", rand.Next(5,10), rand.Next(5, 10));
        }

        public static IMonster CreateMonster()
        {
            return new Monster(rand.Next(2,5), rand.Next(2,5));
        }

        public static ICharacter CreateRandomCharacter()
        {
            return new Character("Random",rand.Next(10), rand.Next(10));
        }
    }
}
