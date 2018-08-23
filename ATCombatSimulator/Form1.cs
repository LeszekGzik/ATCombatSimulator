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
            userControlCharacter1.character = new Character();
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
            userControlCharacter2.character = new Character();
            userControlCharacter2.refresh();
        }
    }
}
