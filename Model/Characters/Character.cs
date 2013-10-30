using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Characters;

namespace Model
{
    public class Character : ICharacter
    {
        public Character(string name, int might, int magic)
        {
            Name = name;
            Might = might;
            Magic = magic;
            CurrentHealthPoints = MaxHealthPoints;
            CurrentManaPoints = MaxManaPoints;
        }

        public string Name { get; set; }

        #region stats
        public int Might { get; set; }

        public int Magic { get; set; }

        public int Vitality { get; set; }
 
        public int CurrentStaminaPoints { get; set; }

        #endregion stats


        #region Vitals

        public int MaxHealthPoints
        {
            get
            {
                var maxHP = 0;
                maxHP += CharacterConstants.BaseHealth + 2*Vitality;
                return maxHP;
            } 
        }

        public int MaxManaPoints
        {
            get
            {
                var maxMP = 0;
                maxMP +=CharacterConstants.BaseMana + 2*Magic;
                return maxMP;
            }
        }

        public int MaxStaminaPoints
        {
            get
            {
                var maxSP = 0;
                maxSP += CharacterConstants.BaseStamina + 2 * Might;
                return maxSP;
            }
        }

        public int CurrentHealthPoints { get; set; }

        public int CurrentManaPoints { get; set; }

        #endregion Vitals

        public int MightAttack()
        {
            return Might;
        }

        public int MagicAttack()
        {
            return Magic;
        }

        public bool IsReady()
        {
            return CurrentHealthPoints > 0;
        }

        public bool IsDead()
        {
            return CurrentHealthPoints <= 0;
        }

        public CharacterStatus GetCharacterStatus()
        {
            throw new NotImplementedException();
        }
    }
}
