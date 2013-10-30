using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace RpgView
{
    public partial class EncounterView : Form
    {
        private IEncounter encounter;

        public EncounterView()
        {
            InitializeComponent();
        }

        private void btnFinishEncounter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void StartEncounter(IEncounter encounter)
        {
            this.encounter = encounter;
            UpdateModel();
            UpdateEventLog();
            
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            if (encounter.AddPlayerEvent(new MightAttack()))
            {
                UpdateModel();
                UpdateEventLog();
            }
        }

        private void btnMonsterAction_Click(object sender, EventArgs e)
        {
            if (encounter.AddMonsterEvent())
            {
                UpdateModel();
                UpdateEventLog();
            }
        }

        private void UpdateEventLog()
        {
            this.tbLog.Text = string.Format("{0}\n{1}", this.encounter.LastEvent, this.tbLog.Text);
        }

        private void UpdateModel()
        {
            this.cvMonster.UpdateCharacterView(new CharacterViewModel(encounter.MonsterCharacter));   
            this.cvPlayer.UpdateCharacterView(new CharacterViewModel(encounter.PlayerCharacter));            
            if (this.encounter.Status != EncounterStatus.Running)
            {
                this.btnFinishEncounter.Enabled = true;
            }
            if (this.encounter.Inititive.CurrentCharacter() == this.encounter.PlayerCharacter)
            {
                this.btnAttack.Enabled = true;
                this.btnMonsterAction.Enabled = false;
            }
            else
            {
                  this.btnAttack.Enabled = false;
                this.btnMonsterAction.Enabled = true;
            }
        }
    }
}
