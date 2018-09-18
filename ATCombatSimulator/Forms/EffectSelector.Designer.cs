namespace ATCombatSimulator.Forms
{
    partial class EffectSelector
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
            this.radioButtonPdmg = new System.Windows.Forms.RadioButton();
            this.radioButtonMdmg = new System.Windows.Forms.RadioButton();
            this.radioButtonHeal = new System.Windows.Forms.RadioButton();
            this.radioButtonSpd = new System.Windows.Forms.RadioButton();
            this.radioButtonSpr = new System.Windows.Forms.RadioButton();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.radioButtonPsn = new System.Windows.Forms.RadioButton();
            this.radioButtonPsnself = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radioButtonPdmg
            // 
            this.radioButtonPdmg.AutoSize = true;
            this.radioButtonPdmg.Checked = true;
            this.radioButtonPdmg.Location = new System.Drawing.Point(13, 13);
            this.radioButtonPdmg.Name = "radioButtonPdmg";
            this.radioButtonPdmg.Size = new System.Drawing.Size(129, 17);
            this.radioButtonPdmg.TabIndex = 0;
            this.radioButtonPdmg.TabStop = true;
            this.radioButtonPdmg.Text = "Deal physical damage";
            this.radioButtonPdmg.UseVisualStyleBackColor = true;
            // 
            // radioButtonMdmg
            // 
            this.radioButtonMdmg.AutoSize = true;
            this.radioButtonMdmg.Location = new System.Drawing.Point(13, 36);
            this.radioButtonMdmg.Name = "radioButtonMdmg";
            this.radioButtonMdmg.Size = new System.Drawing.Size(127, 17);
            this.radioButtonMdmg.TabIndex = 0;
            this.radioButtonMdmg.Text = "Deal magical damage";
            this.radioButtonMdmg.UseVisualStyleBackColor = true;
            // 
            // radioButtonHeal
            // 
            this.radioButtonHeal.AutoSize = true;
            this.radioButtonHeal.Location = new System.Drawing.Point(13, 59);
            this.radioButtonHeal.Name = "radioButtonHeal";
            this.radioButtonHeal.Size = new System.Drawing.Size(66, 17);
            this.radioButtonHeal.TabIndex = 0;
            this.radioButtonHeal.Text = "Heal self";
            this.radioButtonHeal.UseVisualStyleBackColor = true;
            // 
            // radioButtonSpd
            // 
            this.radioButtonSpd.AutoSize = true;
            this.radioButtonSpd.Location = new System.Drawing.Point(13, 82);
            this.radioButtonSpd.Name = "radioButtonSpd";
            this.radioButtonSpd.Size = new System.Drawing.Size(120, 17);
            this.radioButtonSpd.TabIndex = 0;
            this.radioButtonSpd.Text = "Drain SP from target";
            this.radioButtonSpd.UseVisualStyleBackColor = true;
            // 
            // radioButtonSpr
            // 
            this.radioButtonSpr.AutoSize = true;
            this.radioButtonSpr.Location = new System.Drawing.Point(13, 105);
            this.radioButtonSpr.Name = "radioButtonSpr";
            this.radioButtonSpr.Size = new System.Drawing.Size(83, 17);
            this.radioButtonSpr.TabIndex = 0;
            this.radioButtonSpr.Text = "Recover SP";
            this.radioButtonSpr.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(13, 192);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(147, 192);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // radioButtonPsn
            // 
            this.radioButtonPsn.AutoSize = true;
            this.radioButtonPsn.Location = new System.Drawing.Point(13, 128);
            this.radioButtonPsn.Name = "radioButtonPsn";
            this.radioButtonPsn.Size = new System.Drawing.Size(91, 17);
            this.radioButtonPsn.TabIndex = 2;
            this.radioButtonPsn.Text = "Poison enemy";
            this.radioButtonPsn.UseVisualStyleBackColor = true;
            // 
            // radioButtonPsnself
            // 
            this.radioButtonPsnself.AutoSize = true;
            this.radioButtonPsnself.Location = new System.Drawing.Point(13, 151);
            this.radioButtonPsnself.Name = "radioButtonPsnself";
            this.radioButtonPsnself.Size = new System.Drawing.Size(76, 17);
            this.radioButtonPsnself.TabIndex = 2;
            this.radioButtonPsnself.Text = "Poison self";
            this.radioButtonPsnself.UseVisualStyleBackColor = true;
            // 
            // EffectSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 236);
            this.Controls.Add(this.radioButtonPsnself);
            this.Controls.Add(this.radioButtonPsn);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.radioButtonSpr);
            this.Controls.Add(this.radioButtonSpd);
            this.Controls.Add(this.radioButtonHeal);
            this.Controls.Add(this.radioButtonMdmg);
            this.Controls.Add(this.radioButtonPdmg);
            this.Name = "EffectSelector";
            this.Text = "Select effect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonPdmg;
        private System.Windows.Forms.RadioButton radioButtonMdmg;
        private System.Windows.Forms.RadioButton radioButtonHeal;
        private System.Windows.Forms.RadioButton radioButtonSpd;
        private System.Windows.Forms.RadioButton radioButtonSpr;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.RadioButton radioButtonPsn;
        private System.Windows.Forms.RadioButton radioButtonPsnself;
    }
}