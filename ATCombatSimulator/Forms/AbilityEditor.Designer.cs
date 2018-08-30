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
            this.ColumnPower = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnAccuracy = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnCritical = new System.Windows.Forms.DataGridViewComboBoxColumn();
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
            this.ColumnPower.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.ColumnPower.Name = "ColumnPower";
            this.ColumnPower.Width = 60;
            // 
            // ColumnAccuracy
            // 
            this.ColumnAccuracy.HeaderText = "Accuracy";
            this.ColumnAccuracy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "126",
            "127",
            "128",
            "129",
            "130",
            "131",
            "132",
            "133",
            "134",
            "135",
            "136",
            "137",
            "138",
            "139",
            "140",
            "141",
            "142",
            "143",
            "144",
            "145",
            "146",
            "147",
            "148",
            "149",
            "150",
            "151",
            "152",
            "153",
            "154",
            "155",
            "156",
            "157",
            "158",
            "159",
            "160",
            "161",
            "162",
            "163",
            "164",
            "165",
            "166",
            "167",
            "168",
            "169",
            "170",
            "171",
            "172",
            "173",
            "174",
            "175",
            "176",
            "177",
            "178",
            "179",
            "180",
            "181",
            "182",
            "183",
            "184",
            "185",
            "186",
            "187",
            "188",
            "189",
            "190",
            "191",
            "192",
            "193",
            "194",
            "195",
            "196",
            "197",
            "198",
            "199",
            "200"});
            this.ColumnAccuracy.Name = "ColumnAccuracy";
            this.ColumnAccuracy.Width = 60;
            // 
            // ColumnCritical
            // 
            this.ColumnCritical.HeaderText = "Critical";
            this.ColumnCritical.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.ColumnCritical.Name = "ColumnCritical";
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
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnPower;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnAccuracy;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnCritical;
        private System.Windows.Forms.DataGridViewImageColumn ColumnRemoveButton;
        private System.Windows.Forms.DataGridViewImageColumn ColumnUpButton;
        private System.Windows.Forms.DataGridViewImageColumn ColumnDownButton;
    }
}