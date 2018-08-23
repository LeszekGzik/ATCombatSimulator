using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATCombatSimulator
{
    public partial class UserControlCharacter : UserControl
    {
        public int hitChance;
        public int dodgeChance;
        public Character character;

        public UserControlCharacter()
        {
            character = new Character();
            InitializeComponent();
        }

        public void initializeWith(Character _character)
        {
            this.character = _character;
            textBoxName.Text = character.name;
            numericUpDownLevel.Value = character.level;
            numericUpDownAtk.Value = character.ATK;
            numericUpDownDef.Value = character.DEF;
            numericUpDownMatk.Value = character.MATK;
            numericUpDownMdef.Value = character.MDEF;
            numericUpDownVit.Value = character.VIT;
            numericUpDownSkl.Value = character.SKL;
            numericUpDownAgi.Value = character.AGI;
            numericUpDownLck.Value = character.LCK;

            foreach(Ability a in character.abilities)
            {
                String newItem = a.Name + " (";
                if (a.Physical == true) newItem += "Phy. POW ";
                else newItem += "Mag. POW ";
                newItem += a.Power;
                newItem += ", SP ";
                newItem += a.SpCost;
                newItem += ")";

                comboBoxAbilities.Items.Add(newItem);
            }
            comboBoxAbilities.SelectedIndex = 0;
            refresh();
        }

        public void refresh()
        {
            character.reset();
            labelHP.Text = "HP: " + character.currentHP + "/" + character.maxHP;
            labelSP.Text = "SP: " + character.currentSP + "/" + character.maxSP;
            labelHit.Text = "Hit chance: " + (character.selectedAbility.Accuracy + 2 * character.AGI) + "%";
            labelDodge.Text = "Dodge chance: " + 2 * character.AGI + "%";
            labelCrit.Text = "Critical hit chance: " + (character.selectedAbility.Crit + character.LCK) + "%";
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            character.name = textBoxName.Text;
            groupBoxCharacter.Text = character.name;
        }

        private void comboBoxAbilities_SelectedIndexChanged(object sender, EventArgs e)
        {
            character.selectedAbility = character.abilities[comboBoxAbilities.SelectedIndex];
            labelHit.Text = "Hit chance: " + (character.selectedAbility.Accuracy + 2 * character.AGI) + "%";
            labelCrit.Text = "Critical hit chance: " + (character.selectedAbility.Crit + character.LCK) + "%";
        }

        private void numericUpDownLevel_ValueChanged(object sender, EventArgs e)
        {
            character.level = Convert.ToInt32(numericUpDownLevel.Value);
            refresh();
        }

        private void numericUpDownAtk_ValueChanged(object sender, EventArgs e)
        {
            character.ATK = Convert.ToInt32(numericUpDownAtk.Value);
            refresh();
        }

        private void numericUpDownDef_ValueChanged(object sender, EventArgs e)
        {
            character.DEF = Convert.ToInt32(numericUpDownDef.Value);
            refresh();
        }

        private void numericUpDownVit_ValueChanged(object sender, EventArgs e)
        {
            character.VIT = Convert.ToInt32(numericUpDownVit.Value);
            refresh();
        }

        private void numericUpDownSkl_ValueChanged(object sender, EventArgs e)
        {
            character.SKL = Convert.ToInt32(numericUpDownSkl.Value);
            refresh();
        }

        private void numericUpDownMatk_ValueChanged(object sender, EventArgs e)
        {
            character.MATK = Convert.ToInt32(numericUpDownMatk.Value);
            refresh();
        }

        private void numericUpDownMdef_ValueChanged(object sender, EventArgs e)
        {
            character.MDEF = Convert.ToInt32(numericUpDownMdef.Value);
            refresh();
        }

        private void numericUpDownAgi_ValueChanged(object sender, EventArgs e)
        {
            character.AGI = Convert.ToInt32(numericUpDownAgi.Value);
            refresh();
        }

        private void numericUpDownLck_ValueChanged(object sender, EventArgs e)
        {
            character.LCK = Convert.ToInt32(numericUpDownLck.Value);
            refresh();
        }

        private void buttonAddAbility_Click(object sender, EventArgs e)
        {
            AbilityEditor ae = new AbilityEditor();
            if(ae.ShowDialog() == DialogResult.OK)
            {
                character.abilities.Add(ae.ability);
                String newItem = ae.ability.Name + " (";
                if (ae.ability.Physical == true) newItem += "Phy. POW ";
                else newItem += "Mag. POW ";
                newItem += ae.ability.Power;
                newItem += ", SP ";
                newItem += ae.ability.SpCost;
                newItem += ")";

                comboBoxAbilities.Items.Add(newItem);
                comboBoxAbilities.SelectedIndex = comboBoxAbilities.Items.Count - 1;
                refresh();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int index = comboBoxAbilities.SelectedIndex;
            AbilityEditor ae = new AbilityEditor(character.abilities[index]);
            if (ae.ShowDialog() == DialogResult.OK)
            {
                character.abilities.RemoveAt(index);
                character.abilities.Add(ae.ability);
                comboBoxAbilities.Items.RemoveAt(index);
                String newItem = ae.ability.Name + " (";
                if (ae.ability.Physical == true) newItem += "Phy. POW ";
                else newItem += "Mag. POW ";
                newItem += ae.ability.Power;
                newItem += ", SP ";
                newItem += ae.ability.SpCost;
                newItem += ")";

                comboBoxAbilities.Items.Add(newItem);
                comboBoxAbilities.SelectedIndex = comboBoxAbilities.Items.Count - 1;
                refresh();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = comboBoxAbilities.SelectedIndex;
            comboBoxAbilities.Items.RemoveAt(index);
            character.abilities.RemoveAt(index);
        }

        public void disableEdit()
        {
            textBoxName.Enabled = false;
            numericUpDownAgi.Enabled = false;
            numericUpDownAtk.Enabled = false;
            numericUpDownDef.Enabled = false;
            numericUpDownLck.Enabled = false;
            numericUpDownLevel.Enabled = false;
            numericUpDownMatk.Enabled = false;
            numericUpDownMdef.Enabled = false;
            numericUpDownSkl.Enabled = false;
            numericUpDownVit.Enabled = false;
            buttonAddAbility.Enabled = false;
            buttonDelete.Enabled = false;
            buttonEdit.Enabled = false;
        }

        public void enableEdit()
        {
            textBoxName.Enabled = true;
            numericUpDownAgi.Enabled = true;
            numericUpDownAtk.Enabled = true;
            numericUpDownDef.Enabled = true;
            numericUpDownLck.Enabled = true;
            numericUpDownLevel.Enabled = true;
            numericUpDownMatk.Enabled = true;
            numericUpDownMdef.Enabled = true;
            numericUpDownSkl.Enabled = true;
            numericUpDownVit.Enabled = true;
            buttonAddAbility.Enabled = true;
            buttonDelete.Enabled = true;
            buttonEdit.Enabled = true;
        }
    }
}
