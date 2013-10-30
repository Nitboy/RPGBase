namespace RpgView
{
    partial class Form1
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
            this.btnCreateEncounter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateEncounter
            // 
            this.btnCreateEncounter.Location = new System.Drawing.Point(13, 12);
            this.btnCreateEncounter.Name = "btnCreateEncounter";
            this.btnCreateEncounter.Size = new System.Drawing.Size(151, 41);
            this.btnCreateEncounter.TabIndex = 3;
            this.btnCreateEncounter.Text = "Create Encounter";
            this.btnCreateEncounter.UseVisualStyleBackColor = true;
            this.btnCreateEncounter.Click += new System.EventHandler(this.btnCreateEncounter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 576);
            this.Controls.Add(this.btnCreateEncounter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateEncounter;
    }
}

