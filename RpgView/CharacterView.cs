using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace RpgView
{
    public partial class CharacterView : UserControl
    {
        public CharacterView()
        {
            InitializeComponent();
        }

        public void UpdateCharacterView(CharacterViewModel character)
        {
            this.lbHealthValue.Text = character.HealthDisplay;
            this.lbManaPointsValue.Text = character.ManaDisplay;
            this.lbMagicValue.Text = character.Magic;
            this.lbMightValue.Text = character.Might;
        }
    }
}
