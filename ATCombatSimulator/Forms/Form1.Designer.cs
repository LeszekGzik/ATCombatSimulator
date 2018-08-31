namespace ATCombatSimulator
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
            this.buttonAttack1 = new System.Windows.Forms.Button();
            this.buttonAttack2 = new System.Windows.Forms.Button();
            this.richTextBoxResults = new System.Windows.Forms.RichTextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonStartFight = new System.Windows.Forms.Button();
            this.buttonSaveCharacter2 = new System.Windows.Forms.Button();
            this.buttonLoadCharacter2 = new System.Windows.Forms.Button();
            this.buttonSaveCharacter1 = new System.Windows.Forms.Button();
            this.buttonNewCharacter2 = new System.Windows.Forms.Button();
            this.buttonLoadCharacter1 = new System.Windows.Forms.Button();
            this.buttonNewCharacter1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.userControlCharacter1 = new ATCombatSimulator.UserControlCharacter();
            this.userControlCharacter2 = new ATCombatSimulator.UserControlCharacter();
            this.SuspendLayout();
            // 
            // buttonAttack1
            // 
            this.buttonAttack1.Enabled = false;
            this.buttonAttack1.Location = new System.Drawing.Point(86, 431);
            this.buttonAttack1.Name = "buttonAttack1";
            this.buttonAttack1.Size = new System.Drawing.Size(164, 23);
            this.buttonAttack1.TabIndex = 2;
            this.buttonAttack1.Text = "Attack!";
            this.buttonAttack1.UseVisualStyleBackColor = true;
            this.buttonAttack1.Click += new System.EventHandler(this.buttonAttack1_Click);
            // 
            // buttonAttack2
            // 
            this.buttonAttack2.Enabled = false;
            this.buttonAttack2.Location = new System.Drawing.Point(693, 431);
            this.buttonAttack2.Name = "buttonAttack2";
            this.buttonAttack2.Size = new System.Drawing.Size(164, 23);
            this.buttonAttack2.TabIndex = 2;
            this.buttonAttack2.Text = "Attack!";
            this.buttonAttack2.UseVisualStyleBackColor = true;
            this.buttonAttack2.Click += new System.EventHandler(this.buttonAttack2_Click);
            // 
            // richTextBoxResults
            // 
            this.richTextBoxResults.Location = new System.Drawing.Point(320, 65);
            this.richTextBoxResults.Name = "richTextBoxResults";
            this.richTextBoxResults.Size = new System.Drawing.Size(280, 372);
            this.richTextBoxResults.TabIndex = 3;
            this.richTextBoxResults.Text = "";
            this.richTextBoxResults.TextChanged += new System.EventHandler(this.richTextBoxResults_TextChanged);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(320, 7);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(279, 23);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonStartFight
            // 
            this.buttonStartFight.Location = new System.Drawing.Point(320, 36);
            this.buttonStartFight.Name = "buttonStartFight";
            this.buttonStartFight.Size = new System.Drawing.Size(279, 23);
            this.buttonStartFight.TabIndex = 4;
            this.buttonStartFight.Text = "Start fight";
            this.buttonStartFight.UseVisualStyleBackColor = true;
            this.buttonStartFight.Click += new System.EventHandler(this.buttonStartFight_Click);
            // 
            // buttonSaveCharacter2
            // 
            this.buttonSaveCharacter2.Image = global::ATCombatSimulator.Properties.Resources.Save_16x;
            this.buttonSaveCharacter2.Location = new System.Drawing.Point(679, 7);
            this.buttonSaveCharacter2.Name = "buttonSaveCharacter2";
            this.buttonSaveCharacter2.Size = new System.Drawing.Size(24, 24);
            this.buttonSaveCharacter2.TabIndex = 1;
            this.buttonSaveCharacter2.UseVisualStyleBackColor = true;
            this.buttonSaveCharacter2.Click += new System.EventHandler(this.buttonSaveCharacter2_Click);
            // 
            // buttonLoadCharacter2
            // 
            this.buttonLoadCharacter2.Image = global::ATCombatSimulator.Properties.Resources.Folder_16x;
            this.buttonLoadCharacter2.Location = new System.Drawing.Point(649, 7);
            this.buttonLoadCharacter2.Name = "buttonLoadCharacter2";
            this.buttonLoadCharacter2.Size = new System.Drawing.Size(24, 24);
            this.buttonLoadCharacter2.TabIndex = 1;
            this.buttonLoadCharacter2.UseVisualStyleBackColor = true;
            this.buttonLoadCharacter2.Click += new System.EventHandler(this.buttonLoadCharacter2_Click);
            // 
            // buttonSaveCharacter1
            // 
            this.buttonSaveCharacter1.Image = global::ATCombatSimulator.Properties.Resources.Save_16x;
            this.buttonSaveCharacter1.Location = new System.Drawing.Point(72, 7);
            this.buttonSaveCharacter1.Name = "buttonSaveCharacter1";
            this.buttonSaveCharacter1.Size = new System.Drawing.Size(24, 24);
            this.buttonSaveCharacter1.TabIndex = 1;
            this.buttonSaveCharacter1.UseVisualStyleBackColor = true;
            this.buttonSaveCharacter1.Click += new System.EventHandler(this.buttonSaveCharacter1_Click);
            // 
            // buttonNewCharacter2
            // 
            this.buttonNewCharacter2.Image = global::ATCombatSimulator.Properties.Resources.NewFile_16x;
            this.buttonNewCharacter2.Location = new System.Drawing.Point(619, 7);
            this.buttonNewCharacter2.Name = "buttonNewCharacter2";
            this.buttonNewCharacter2.Size = new System.Drawing.Size(24, 24);
            this.buttonNewCharacter2.TabIndex = 1;
            this.buttonNewCharacter2.UseVisualStyleBackColor = true;
            this.buttonNewCharacter2.Click += new System.EventHandler(this.buttonNewCharacter2_Click);
            // 
            // buttonLoadCharacter1
            // 
            this.buttonLoadCharacter1.Image = global::ATCombatSimulator.Properties.Resources.Folder_16x;
            this.buttonLoadCharacter1.Location = new System.Drawing.Point(42, 7);
            this.buttonLoadCharacter1.Name = "buttonLoadCharacter1";
            this.buttonLoadCharacter1.Size = new System.Drawing.Size(24, 24);
            this.buttonLoadCharacter1.TabIndex = 1;
            this.buttonLoadCharacter1.UseVisualStyleBackColor = true;
            this.buttonLoadCharacter1.Click += new System.EventHandler(this.buttonLoadCharacter1_Click);
            // 
            // buttonNewCharacter1
            // 
            this.buttonNewCharacter1.Image = global::ATCombatSimulator.Properties.Resources.NewFile_16x;
            this.buttonNewCharacter1.Location = new System.Drawing.Point(12, 7);
            this.buttonNewCharacter1.Name = "buttonNewCharacter1";
            this.buttonNewCharacter1.Size = new System.Drawing.Size(24, 24);
            this.buttonNewCharacter1.TabIndex = 1;
            this.buttonNewCharacter1.UseVisualStyleBackColor = true;
            this.buttonNewCharacter1.Click += new System.EventHandler(this.buttonNewCharacter1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // userControlCharacter1
            // 
            this.userControlCharacter1.Location = new System.Drawing.Point(12, 36);
            this.userControlCharacter1.Name = "userControlCharacter1";
            this.userControlCharacter1.Size = new System.Drawing.Size(302, 388);
            this.userControlCharacter1.TabIndex = 5;
            // 
            // userControlCharacter2
            // 
            this.userControlCharacter2.Location = new System.Drawing.Point(619, 36);
            this.userControlCharacter2.Name = "userControlCharacter2";
            this.userControlCharacter2.Size = new System.Drawing.Size(302, 388);
            this.userControlCharacter2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 475);
            this.Controls.Add(this.userControlCharacter2);
            this.Controls.Add(this.userControlCharacter1);
            this.Controls.Add(this.buttonStartFight);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.richTextBoxResults);
            this.Controls.Add(this.buttonAttack2);
            this.Controls.Add(this.buttonAttack1);
            this.Controls.Add(this.buttonSaveCharacter2);
            this.Controls.Add(this.buttonLoadCharacter2);
            this.Controls.Add(this.buttonSaveCharacter1);
            this.Controls.Add(this.buttonNewCharacter2);
            this.Controls.Add(this.buttonLoadCharacter1);
            this.Controls.Add(this.buttonNewCharacter1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonNewCharacter1;
        private System.Windows.Forms.Button buttonLoadCharacter1;
        private System.Windows.Forms.Button buttonSaveCharacter1;
        private System.Windows.Forms.Button buttonNewCharacter2;
        private System.Windows.Forms.Button buttonLoadCharacter2;
        private System.Windows.Forms.Button buttonSaveCharacter2;
        private System.Windows.Forms.Button buttonAttack1;
        private System.Windows.Forms.Button buttonAttack2;
        private System.Windows.Forms.RichTextBox richTextBoxResults;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonStartFight;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private UserControlCharacter userControlCharacter1;
        private UserControlCharacter userControlCharacter2;
    }
}

