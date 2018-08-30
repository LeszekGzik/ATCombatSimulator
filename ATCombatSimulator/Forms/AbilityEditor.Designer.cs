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
            this.labelSpCost = new System.Windows.Forms.Label();
            this.numericUpDownSP = new System.Windows.Forms.NumericUpDown();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAddEffect = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnEffect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAccuracy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCritical = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRemoveButton = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnUpButton = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnDownButton = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(55, 13);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(213, 20);
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
            // labelSpCost
            // 
            this.labelSpCost.AutoSize = true;
            this.labelSpCost.Location = new System.Drawing.Point(285, 16);
            this.labelSpCost.Name = "labelSpCost";
            this.labelSpCost.Size = new System.Drawing.Size(44, 13);
            this.labelSpCost.TabIndex = 2;
            this.labelSpCost.Text = "SP cost";
            // 
            // numericUpDownSP
            // 
            this.numericUpDownSP.Location = new System.Drawing.Point(335, 14);
            this.numericUpDownSP.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownSP.Name = "numericUpDownSP";
            this.numericUpDownSP.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownSP.TabIndex = 3;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(17, 249);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(311, 249);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnEffect,
            this.ColumnPower,
            this.ColumnAccuracy,
            this.ColumnCritical,
            this.ColumnRemoveButton,
            this.ColumnUpButton,
            this.ColumnDownButton});
            this.dataGridView1.Location = new System.Drawing.Point(8, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(378, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonAddEffect
            // 
            this.buttonAddEffect.Location = new System.Drawing.Point(311, 210);
            this.buttonAddEffect.Name = "buttonAddEffect";
            this.buttonAddEffect.Size = new System.Drawing.Size(75, 23);
            this.buttonAddEffect.TabIndex = 7;
            this.buttonAddEffect.Text = "Add effect";
            this.buttonAddEffect.UseVisualStyleBackColor = true;
            this.buttonAddEffect.Click += new System.EventHandler(this.buttonAddEffect_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::ATCombatSimulator.Properties.Resources.Close_16x;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::ATCombatSimulator.Properties.Resources.GoToTop_16x;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 30;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::ATCombatSimulator.Properties.Resources.GoToBottom_16x;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.Width = 30;
            // 
            // ColumnEffect
            // 
            this.ColumnEffect.HeaderText = "Effect";
            this.ColumnEffect.Name = "ColumnEffect";
            this.ColumnEffect.ReadOnly = true;
            this.ColumnEffect.Width = 60;
            // 
            // ColumnPower
            // 
            this.ColumnPower.HeaderText = "Power";
            this.ColumnPower.Name = "ColumnPower";
            this.ColumnPower.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnPower.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnPower.Width = 60;
            // 
            // ColumnAccuracy
            // 
            this.ColumnAccuracy.HeaderText = "Accuracy";
            this.ColumnAccuracy.Name = "ColumnAccuracy";
            this.ColumnAccuracy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnAccuracy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnAccuracy.Width = 60;
            // 
            // ColumnCritical
            // 
            this.ColumnCritical.HeaderText = "Critical";
            this.ColumnCritical.Name = "ColumnCritical";
            this.ColumnCritical.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnCritical.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnCritical.Width = 60;
            // 
            // ColumnRemoveButton
            // 
            this.ColumnRemoveButton.HeaderText = "";
            this.ColumnRemoveButton.Image = global::ATCombatSimulator.Properties.Resources.Close_16x;
            this.ColumnRemoveButton.Name = "ColumnRemoveButton";
            this.ColumnRemoveButton.ReadOnly = true;
            this.ColumnRemoveButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnRemoveButton.Width = 30;
            // 
            // ColumnUpButton
            // 
            this.ColumnUpButton.HeaderText = "";
            this.ColumnUpButton.Image = global::ATCombatSimulator.Properties.Resources.GoToTop_16x;
            this.ColumnUpButton.Name = "ColumnUpButton";
            this.ColumnUpButton.ReadOnly = true;
            this.ColumnUpButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnUpButton.Width = 30;
            // 
            // ColumnDownButton
            // 
            this.ColumnDownButton.HeaderText = "";
            this.ColumnDownButton.Image = global::ATCombatSimulator.Properties.Resources.GoToBottom_16x;
            this.ColumnDownButton.Name = "ColumnDownButton";
            this.ColumnDownButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnDownButton.Width = 30;
            // 
            // AbilityEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 284);
            this.Controls.Add(this.buttonAddEffect);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.numericUpDownSP);
            this.Controls.Add(this.labelSpCost);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Name = "AbilityEditor";
            this.Text = "Ability editor";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSpCost;
        private System.Windows.Forms.NumericUpDown numericUpDownSP;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAddEffect;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEffect;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPower;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAccuracy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCritical;
        private System.Windows.Forms.DataGridViewImageColumn ColumnRemoveButton;
        private System.Windows.Forms.DataGridViewImageColumn ColumnUpButton;
        private System.Windows.Forms.DataGridViewImageColumn ColumnDownButton;
    }
}