namespace ATCombatSimulator
{
    partial class AbilityEditor
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPower = new System.Windows.Forms.Label();
            this.numericUpDownPower = new System.Windows.Forms.NumericUpDown();
            this.labelAccuracy = new System.Windows.Forms.Label();
            this.numericUpDownAccuracy = new System.Windows.Forms.NumericUpDown();
            this.labelCrit = new System.Windows.Forms.Label();
            this.numericUpDownCrit = new System.Windows.Forms.NumericUpDown();
            this.labelSpCost = new System.Windows.Forms.Label();
            this.numericUpDownSP = new System.Windows.Forms.NumericUpDown();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.radioButtonP = new System.Windows.Forms.RadioButton();
            this.radioButtonM = new System.Windows.Forms.RadioButton();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccuracy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCrit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSP)).BeginInit();
            this.groupBoxType.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(55, 13);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(146, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(14, 16);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelPower
            // 
            this.labelPower.AutoSize = true;
            this.labelPower.Location = new System.Drawing.Point(12, 46);
            this.labelPower.Name = "labelPower";
            this.labelPower.Size = new System.Drawing.Size(37, 13);
            this.labelPower.TabIndex = 2;
            this.labelPower.Text = "Power";
            // 
            // numericUpDownPower
            // 
            this.numericUpDownPower.Location = new System.Drawing.Point(122, 44);
            this.numericUpDownPower.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownPower.Name = "numericUpDownPower";
            this.numericUpDownPower.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownPower.TabIndex = 3;
            // 
            // labelAccuracy
            // 
            this.labelAccuracy.AutoSize = true;
            this.labelAccuracy.Location = new System.Drawing.Point(12, 72);
            this.labelAccuracy.Name = "labelAccuracy";
            this.labelAccuracy.Size = new System.Drawing.Size(95, 13);
            this.labelAccuracy.TabIndex = 2;
            this.labelAccuracy.Text = "Base accuracy (%)";
            // 
            // numericUpDownAccuracy
            // 
            this.numericUpDownAccuracy.Location = new System.Drawing.Point(122, 70);
            this.numericUpDownAccuracy.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownAccuracy.Name = "numericUpDownAccuracy";
            this.numericUpDownAccuracy.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownAccuracy.TabIndex = 3;
            // 
            // labelCrit
            // 
            this.labelCrit.AutoSize = true;
            this.labelCrit.Location = new System.Drawing.Point(12, 97);
            this.labelCrit.Name = "labelCrit";
            this.labelCrit.Size = new System.Drawing.Size(104, 13);
            this.labelCrit.TabIndex = 2;
            this.labelCrit.Text = "Base crit chance (%)";
            // 
            // numericUpDownCrit
            // 
            this.numericUpDownCrit.Location = new System.Drawing.Point(122, 95);
            this.numericUpDownCrit.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownCrit.Name = "numericUpDownCrit";
            this.numericUpDownCrit.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownCrit.TabIndex = 3;
            // 
            // labelSpCost
            // 
            this.labelSpCost.AutoSize = true;
            this.labelSpCost.Location = new System.Drawing.Point(12, 123);
            this.labelSpCost.Name = "labelSpCost";
            this.labelSpCost.Size = new System.Drawing.Size(44, 13);
            this.labelSpCost.TabIndex = 2;
            this.labelSpCost.Text = "SP cost";
            // 
            // numericUpDownSP
            // 
            this.numericUpDownSP.Location = new System.Drawing.Point(122, 121);
            this.numericUpDownSP.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownSP.Name = "numericUpDownSP";
            this.numericUpDownSP.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownSP.TabIndex = 3;
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.radioButtonM);
            this.groupBoxType.Controls.Add(this.radioButtonP);
            this.groupBoxType.Location = new System.Drawing.Point(222, 39);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(164, 102);
            this.groupBoxType.TabIndex = 4;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "Ability type";
            // 
            // radioButtonP
            // 
            this.radioButtonP.AutoSize = true;
            this.radioButtonP.Location = new System.Drawing.Point(7, 28);
            this.radioButtonP.Name = "radioButtonP";
            this.radioButtonP.Size = new System.Drawing.Size(120, 17);
            this.radioButtonP.TabIndex = 0;
            this.radioButtonP.TabStop = true;
            this.radioButtonP.Text = "Physical (ATK/DEF)";
            this.radioButtonP.UseVisualStyleBackColor = true;
            // 
            // radioButtonM
            // 
            this.radioButtonM.AutoSize = true;
            this.radioButtonM.Location = new System.Drawing.Point(6, 60);
            this.radioButtonM.Name = "radioButtonM";
            this.radioButtonM.Size = new System.Drawing.Size(136, 17);
            this.radioButtonM.TabIndex = 0;
            this.radioButtonM.TabStop = true;
            this.radioButtonM.Text = "Magical (MATK/MDEF)";
            this.radioButtonM.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(17, 188);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(289, 188);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // AbilityEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 256);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxType);
            this.Controls.Add(this.numericUpDownSP);
            this.Controls.Add(this.numericUpDownCrit);
            this.Controls.Add(this.numericUpDownAccuracy);
            this.Controls.Add(this.numericUpDownPower);
            this.Controls.Add(this.labelSpCost);
            this.Controls.Add(this.labelCrit);
            this.Controls.Add(this.labelAccuracy);
            this.Controls.Add(this.labelPower);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Name = "AbilityEditor";
            this.Text = "Ability editor";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccuracy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCrit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSP)).EndInit();
            this.groupBoxType.ResumeLayout(false);
            this.groupBoxType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPower;
        private System.Windows.Forms.NumericUpDown numericUpDownPower;
        private System.Windows.Forms.Label labelAccuracy;
        private System.Windows.Forms.NumericUpDown numericUpDownAccuracy;
        private System.Windows.Forms.Label labelCrit;
        private System.Windows.Forms.NumericUpDown numericUpDownCrit;
        private System.Windows.Forms.Label labelSpCost;
        private System.Windows.Forms.NumericUpDown numericUpDownSP;
        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.RadioButton radioButtonM;
        private System.Windows.Forms.RadioButton radioButtonP;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}