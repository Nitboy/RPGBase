using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace RpgView
{
    public class CharacterViewModel
    {
        public CharacterViewModel(ICharacter character)
        {
            this.Might = character.Might.ToString();
            this.Magic = character.Magic.ToString();
            this.MaxHealthPoints = character.MaxHealthPoints.ToString();
            this.MaxManaPoints = character.MaxManaPoints.ToString();
            this.CurrentHealthPoints = character.CurrentHealthPoints.ToString();
            this.CurrentManaPoints = character.CurrentManaPoints.ToString();
            this.HealthDisplay = string.Format("{0}/{1}", character.CurrentHealthPoints, character.MaxHealthPoints);
            this.ManaDisplay = string.Format("{0}/{1}", character.CurrentManaPoints, character.MaxManaPoints);
        }

        #region stats
        public string Might { get; set; }

        public string Magic { get; set; }

        #endregion stats


        #region Vitals
        public string ManaDisplay { get; set; }
        public string HealthDisplay { get; set; }
        public string MaxHealthPoints { get; set; }

        public string MaxManaPoints { get; set; }

        public string CurrentHealthPoints { get; set; }

        public string CurrentManaPoints { get; set; }

        #endregion Vitals
    }
}
