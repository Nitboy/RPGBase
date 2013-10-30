using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameController;
using Model;

namespace RpgView
{
    public partial class Form1 : Form
    {
            Game game = new Game();

        public Form1()
        {
            InitializeComponent();

        
        }

        private void btnCreateEncounter_Click(object sender, EventArgs e)
        {
            EncounterView ev = new EncounterView();
            var ec = game.CreateNewEncounter();
            ev.StartEncounter(ec);
            ev.Show(this);
        }
    }
}
