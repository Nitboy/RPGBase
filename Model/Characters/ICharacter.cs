using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface ICharacter
    {
        string Name { get; set; }

        #region stats
        int Might { get; set; }

        int Magic { get; set; }
        int Vitality { get; set; }

        #endregion stats


        #region Vitals
        int MaxHealthPoints { get;  }

        int MaxManaPoints { get; }
        int MaxStaminaPoints { get; }

        int CurrentHealthPoints { get; set; }

        int CurrentManaPoints { get; set; }
        int CurrentStaminaPoints { get; set; }

        #endregion Vitals

        #region Actions

        int MightAttack();
        int MagicAttack();

        #endregion Actions

        #region Character Status

        bool IsReady();

        bool IsDead();

        CharacterStatus GetCharacterStatus();

        #endregion
    }
}
