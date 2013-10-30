namespace RpgView
{
    partial class EncounterView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbLog = new System.Windows.Forms.RichTextBox();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnMonsterAction = new System.Windows.Forms.Button();
            this.btnFinishEncounter = new System.Windows.Forms.Button();
            this.cvMonster = new RpgView.CharacterView();
            this.cvPlayer = new RpgView.CharacterView();
            this.SuspendLayout();
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(12, 93);
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(500, 380);
            this.tbLog.TabIndex = 5;
            this.tbLog.Text = "";
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(104, 11);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(75, 46);
            this.btnAttack.TabIndex = 6;
            this.btnAttack.Text = "Player Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnMonsterAction
            // 
            this.btnMonsterAction.Location = new System.Drawing.Point(345, 12);
            this.btnMonsterAction.Name = "btnMonsterAction";
            this.btnMonsterAction.Size = new System.Drawing.Size(75, 45);
            this.btnMonsterAction.TabIndex = 7;
            this.btnMonsterAction.Text = "Monster Action";
            this.btnMonsterAction.UseVisualStyleBackColor = true;
            this.btnMonsterAction.Click += new System.EventHandler(this.btnMonsterAction_Click);
            // 
            // btnFinishEncounter
            // 
            this.btnFinishEncounter.Enabled = false;
            this.btnFinishEncounter.Location = new System.Drawing.Point(13, 480);
            this.btnFinishEncounter.Name = "btnFinishEncounter";
            this.btnFinishEncounter.Size = new System.Drawing.Size(75, 23);
            this.btnFinishEncounter.TabIndex = 8;
            this.btnFinishEncounter.Text = "Finish";
            this.btnFinishEncounter.UseVisualStyleBackColor = true;
            this.btnFinishEncounter.Click += new System.EventHandler(this.btnFinishEncounter_Click);
            // 
            // cvMonster
            // 
            this.cvMonster.Location = new System.Drawing.Point(426, 12);
            this.cvMonster.Name = "cvMonster";
            this.cvMonster.Size = new System.Drawing.Size(86, 76);
            this.cvMonster.TabIndex = 4;
            // 
            // cvPlayer
            // 
            this.cvPlayer.Location = new System.Drawing.Point(12, 11);
            this.cvPlayer.Name = "cvPlayer";
            this.cvPlayer.Size = new System.Drawing.Size(86, 76);
            this.cvPlayer.TabIndex = 3;
            // 
            // EncounterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 543);
            this.Controls.Add(this.btnFinishEncounter);
            this.Controls.Add(this.btnMonsterAction);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.cvMonster);
            this.Controls.Add(this.cvPlayer);
            this.Name = "EncounterView";
            this.Text = "EncounterView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbLog;
        private CharacterView cvMonster;
        private CharacterView cvPlayer;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnMonsterAction;
        private System.Windows.Forms.Button btnFinishEncounter;

    }
}