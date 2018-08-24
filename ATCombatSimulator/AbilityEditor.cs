using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATCombatSimulator
{
    public partial class AbilityEditor : Form
    {
        public Ability ability;

        public AbilityEditor(Ability _ability)
        {
            InitializeComponent();
            this.ability = _ability;
            initialize();
        }

        public AbilityEditor()
        {
            InitializeComponent();
            this.ability = new Ability();
        }

        public void initialize()
        {
            textBoxName.Text = ability.Name;
            numericUpDownSP.Value = ability.SpCost;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            ability.Name = textBoxName.Text;
            /*ability.Accuracy = (Int32)numericUpDownAccuracy.Value;
            ability.Crit = (Int32)numericUpDownCrit.Value;
            ability.Power = (Int32)numericUpDownPower.Value;
            ability.SpCost = (Int32)numericUpDownSP.Value;
            ability.Physical = radioButtonP.Checked;*/

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
