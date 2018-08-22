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

        public UserControlCharacter(Character _character)
        {
            this.character = _character;
            textBoxName.Text = Name;
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
                newItem += " ACC ";
                newItem += a.Accuracy;
                newItem += "%) [";
                newItem += a.SpCost;
                newItem += " SP]";

                comboBoxAbilities.Items.Add(newItem);
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            character.name = textBoxName.Text;
            groupBoxCharacter.Text = character.name;
        }

        private void upDownChanged(object sender, EventArgs e)
        {
            character.level = Convert.ToInt32(numericUpDownLevel.Value);
            character.ATK = Convert.ToInt32(numericUpDownAtk.Value);
            character.DEF = Convert.ToInt32(numericUpDownDef.Value);
            character.VIT = Convert.ToInt32(numericUpDownVit.Value);
            character.SKL = Convert.ToInt32(numericUpDownSkl.Value);
            character.MATK = Convert.ToInt32(numericUpDownMatk.Value);
            character.MDEF = Convert.ToInt32(numericUpDownMdef.Value);
            character.AGI = Convert.ToInt32(numericUpDownAgi.Value);
            character.LCK = Convert.ToInt32(numericUpDownLck.Value);

            character.reset();
            labelHP.Text = "HP: " + character.currentHP + "/" + character.maxHP;
            labelSP.Text = "SP: " + character.currentSP + "/" + character.maxSP;
            labelHit.Text = "Hit chance: " + (character.selectedAbility.Accuracy + 2 * character.AGI) + "%";
            labelDodge.Text = "Dodge chance: " + 2*character.AGI + "%";
        }

        private void comboBoxAbilities_SelectedIndexChanged(object sender, EventArgs e)
        {
            character.selectedAbility = character.abilities[comboBoxAbilities.SelectedIndex];
            labelHit.Text = "Hit chance: " + (character.selectedAbility.Accuracy + 2 * character.AGI) + "%";
        }
    }
}
