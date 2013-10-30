namespace RpgView
{
    partial class CharacterView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbName = new System.Windows.Forms.Label();
            this.lbMight = new System.Windows.Forms.Label();
            this.lbMagic = new System.Windows.Forms.Label();
            this.lbMightValue = new System.Windows.Forms.Label();
            this.lbMagicValue = new System.Windows.Forms.Label();
            this.lbHealthText = new System.Windows.Forms.Label();
            this.lbHealthValue = new System.Windows.Forms.Label();
            this.lbManaPointsValue = new System.Windows.Forms.Label();
            this.lbManaPoints = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(4, 4);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(57, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "CharName";
            // 
            // lbMight
            // 
            this.lbMight.AutoSize = true;
            this.lbMight.Location = new System.Drawing.Point(7, 21);
            this.lbMight.Name = "lbMight";
            this.lbMight.Size = new System.Drawing.Size(33, 13);
            this.lbMight.TabIndex = 1;
            this.lbMight.Text = "Physical";
            // 
            // lbMagic
            // 
            this.lbMagic.AutoSize = true;
            this.lbMagic.Location = new System.Drawing.Point(7, 34);
            this.lbMagic.Name = "lbMagic";
            this.lbMagic.Size = new System.Drawing.Size(36, 13);
            this.lbMagic.TabIndex = 2;
            this.lbMagic.Text = "Magic";
            // 
            // lbMightValue
            // 
            this.lbMightValue.AutoSize = true;
            this.lbMightValue.Location = new System.Drawing.Point(47, 21);
            this.lbMightValue.Name = "lbMightValue";
            this.lbMightValue.Size = new System.Drawing.Size(33, 13);
            this.lbMightValue.TabIndex = 3;
            this.lbMightValue.Text = "Physical";
            // 
            // lbMagicValue
            // 
            this.lbMagicValue.AutoSize = true;
            this.lbMagicValue.Location = new System.Drawing.Point(47, 34);
            this.lbMagicValue.Name = "lbMagicValue";
            this.lbMagicValue.Size = new System.Drawing.Size(36, 13);
            this.lbMagicValue.TabIndex = 4;
            this.lbMagicValue.Text = "Magic";
            // 
            // lbHealthText
            // 
            this.lbHealthText.AutoSize = true;
            this.lbHealthText.Location = new System.Drawing.Point(7, 47);
            this.lbHealthText.Name = "lbHealthText";
            this.lbHealthText.Size = new System.Drawing.Size(22, 13);
            this.lbHealthText.TabIndex = 5;
            this.lbHealthText.Text = "HP";
            // 
            // lbHealthValue
            // 
            this.lbHealthValue.AutoSize = true;
            this.lbHealthValue.Location = new System.Drawing.Point(47, 47);
            this.lbHealthValue.Name = "lbHealthValue";
            this.lbHealthValue.Size = new System.Drawing.Size(38, 13);
            this.lbHealthValue.TabIndex = 6;
            this.lbHealthValue.Text = "Health";
            // 
            // lbManaPointsValue
            // 
            this.lbManaPointsValue.AutoSize = true;
            this.lbManaPointsValue.Location = new System.Drawing.Point(47, 60);
            this.lbManaPointsValue.Name = "lbManaPointsValue";
            this.lbManaPointsValue.Size = new System.Drawing.Size(23, 13);
            this.lbManaPointsValue.TabIndex = 8;
            this.lbManaPointsValue.Text = "MP";
            // 
            // lbManaPoints
            // 
            this.lbManaPoints.AutoSize = true;
            this.lbManaPoints.Location = new System.Drawing.Point(7, 60);
            this.lbManaPoints.Name = "lbManaPoints";
            this.lbManaPoints.Size = new System.Drawing.Size(23, 13);
            this.lbManaPoints.TabIndex = 7;
            this.lbManaPoints.Text = "MP";
            // 
            // CharacterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbManaPointsValue);
            this.Controls.Add(this.lbManaPoints);
            this.Controls.Add(this.lbHealthValue);
            this.Controls.Add(this.lbHealthText);
            this.Controls.Add(this.lbMagicValue);
            this.Controls.Add(this.lbMightValue);
            this.Controls.Add(this.lbMagic);
            this.Controls.Add(this.lbMight);
            this.Controls.Add(this.lbName);
            this.Name = "CharacterView";
            this.Size = new System.Drawing.Size(86, 76);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbMight;
        private System.Windows.Forms.Label lbMagic;
        private System.Windows.Forms.Label lbMightValue;
        private System.Windows.Forms.Label lbMagicValue;
        private System.Windows.Forms.Label lbHealthText;
        private System.Windows.Forms.Label lbHealthValue;
        private System.Windows.Forms.Label lbManaPointsValue;
        private System.Windows.Forms.Label lbManaPoints;
    }
}
