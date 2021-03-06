﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATCombatSimulator.Forms
{
    public partial class EffectSelector : Form
    {
        public String effectType;

        public EffectSelector()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if(radioButtonPdmg.Checked)
            {
                effectType = "pdmg";
            }
            else if (radioButtonMdmg.Checked)
            {
                effectType = "mdmg";
            }
            else if (radioButtonHeal.Checked)
            {
                effectType = "heal";
            }
            else if (radioButtonSpd.Checked)
            {
                effectType = "spd";
            }
            else if (radioButtonSpr.Checked)
            {
                effectType = "spr";
            }
            else if (radioButtonPsn.Checked)
            {
                effectType = "psn";
            }
            else if (radioButtonPsnself.Checked)
            {
                effectType = "psnself";
            }
            else if (radioButtonPar.Checked)
            {
                effectType = "par";
            }
            else if (radioButtonParself.Checked)
            {
                effectType = "parself";
            }
            else if (radioButtonBli.Checked)
            {
                effectType = "bli";
            }
            else if (radioButtonBliself.Checked)
            {
                effectType = "bliself";
            }
            else if (radioButtonCleanse.Checked)
            {
                effectType = "cleanse";
            }


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
