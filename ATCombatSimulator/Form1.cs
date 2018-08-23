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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "XML Files|*.xml";
            openFileDialog1.FileName = "";
            saveFileDialog1.Filter = "XML Files|*.xml";
            saveFileDialog1.FileName = "";
        }

        private void buttonLoadCharacter1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Character character = new Character();
                character.loadFromXML(openFileDialog1.FileName);
                userControlCharacter1.initializeWith(character);
            }
        }

        private void buttonNewCharacter1_Click(object sender, EventArgs e)
        {
            userControlCharacter1.initializeWith(new Character());
            userControlCharacter1.refresh();
        }

        private void buttonSaveCharacter1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                userControlCharacter1.character.saveToXML(saveFileDialog1.FileName);
            }
        }

        private void buttonLoadCharacter2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Character character = new Character();
                character.loadFromXML(openFileDialog1.FileName);
                userControlCharacter2.initializeWith(character);
            }
        }

        private void buttonSaveCharacter2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                userControlCharacter2.character.saveToXML(saveFileDialog1.FileName);
            }
        }

        private void buttonNewCharacter2_Click(object sender, EventArgs e)
        {
            userControlCharacter2.initializeWith(new Character());
            userControlCharacter2.refresh();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            userControlCharacter1.character.reset();
            userControlCharacter1.refresh();
            userControlCharacter1.enableEdit();
            userControlCharacter2.character.reset();
            userControlCharacter2.refresh();
            userControlCharacter2.enableEdit();
            buttonAttack1.Enabled = false;
            buttonAttack2.Enabled = false;
            buttonStartFight.Enabled = true;
            richTextBoxResults.Clear();
        }

        private void buttonStartFight_Click(object sender, EventArgs e)
        {
            Character c1 = userControlCharacter1.character;
            Character c2 = userControlCharacter2.character;
            userControlCharacter1.disableEdit();
            userControlCharacter2.disableEdit();
            buttonStartFight.Enabled = false;
            richTextBoxResults.Clear();
            richTextBoxResults.Text += "Battle starts! " + c1.name + " vs " + c2.name + "!\n";
            if (c1.AGI >= c2.AGI)
            {
                richTextBoxResults.Text += c1.name + " goes first.\n";
                buttonAttack1.Enabled = true;
            }
            else
            {
                richTextBoxResults.Text += c2.name + " goes first.\n";
                buttonAttack2.Enabled = true;
            }
        }

        private void buttonAttack1_Click(object sender, EventArgs e)
        {
            Character c1 = userControlCharacter1.character;
            Character c2 = userControlCharacter2.character;
            if (c1.hasEnoughSP())
            {
                richTextBoxResults.Text += c1.attack(c2);
                userControlCharacter1.refresh();
                userControlCharacter2.refresh();
                if (c2.isDead())
                {
                    richTextBoxResults.Text += c2.name + " is knocked out. " + c1.name + " wins!\n";
                    buttonAttack1.Enabled = false;
                }
                else
                {
                    buttonAttack1.Enabled = false;
                    buttonAttack2.Enabled = true;
                }
            }
            else
            {
                richTextBoxResults.Text += c1.name + " doesn't have enough SP to use " + c1.selectedAbility.Name + ".\n";
            }
        }

        private void buttonAttack2_Click(object sender, EventArgs e)
        {
            Character c1 = userControlCharacter1.character;
            Character c2 = userControlCharacter2.character;
            if (c2.hasEnoughSP())
            {
                richTextBoxResults.Text += c2.attack(c1);
                userControlCharacter1.refresh();
                userControlCharacter2.refresh();
                if (c1.isDead())
                {
                    richTextBoxResults.Text += c1.name + " is knocked out. " + c2.name + " wins!\n";
                    buttonAttack2.Enabled = false;
                }
                else
                {
                    buttonAttack2.Enabled = false;
                    buttonAttack1.Enabled = true;
                }
            }
            else
            {
                richTextBoxResults.Text += c2.name + " doesn't have enough SP to use " + c2.selectedAbility.Name + ".\n";
            }
        }
    }
}
