﻿using ATCombatSimulator.Effects;
using ATCombatSimulator.Forms;
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
            foreach(Effect e in ability.Effects)
            {
                dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[dataGridView1.RowCount - 1];
                row.Cells[0].Value = e.Type;
                switch(e.Type)
                {
                    case "pdmg":
                        row.Cells[1].Value = ((PhysicalDamage)e).Power.ToString();
                        row.Cells[2].Value = ((PhysicalDamage)e).Accuracy.ToString();
                        row.Cells[3].Value = ((PhysicalDamage)e).Crit.ToString();
                        break;
                    case "mdmg":
                        row.Cells[1].Value = ((MagicalDamage)e).Power.ToString();
                        row.Cells[2].Value = ((MagicalDamage)e).Accuracy.ToString();
                        row.Cells[3].Value = ((MagicalDamage)e).Crit.ToString();
                        break;
                    case "heal":
                        row.Cells[1].Value = ((Heal)e).Power.ToString();
                        row.Cells[2].Value = ((Heal)e).Accuracy.ToString();
                        row.Cells[3].Value = ((Heal)e).Crit.ToString();
                        break;
                    case "spd":
                        row.Cells[1].Value = ((SPDrain)e).Power.ToString();
                        row.Cells[2].Value = ((SPDrain)e).Accuracy.ToString();
                        row.Cells[3].Value = ((SPDrain)e).Crit.ToString();
                        break;
                    case "spr":
                        row.Cells[1].Value = ((SPRecovery)e).Power.ToString();
                        row.Cells[2].Value = ((SPRecovery)e).Accuracy.ToString();
                        row.Cells[3].Value = ((SPRecovery)e).Crit.ToString();
                        break;
                    case "psn":
                        disableCell(row, 1);
                        row.Cells[2].Value = ((PoisonEnemy)e).Accuracy.ToString();
                        disableCell(row, 3);
                        break;
                    case "psnself":
                        disableCell(row, 1);
                        row.Cells[2].Value = ((PoisonSelf)e).Accuracy.ToString();
                        disableCell(row, 3);
                        break;
                    case "par":
                        disableCell(row, 1);
                        row.Cells[2].Value = ((ParalyzeEnemy)e).Accuracy.ToString();
                        disableCell(row, 3);
                        break;
                    case "parself":
                        disableCell(row, 1);
                        row.Cells[2].Value = ((ParalyzeSelf)e).Accuracy.ToString();
                        disableCell(row, 3);
                        break;
                    case "bli":
                        disableCell(row, 1);
                        row.Cells[2].Value = ((BlindEnemy)e).Accuracy.ToString();
                        disableCell(row, 3);
                        break;
                    case "bliself":
                        disableCell(row, 1);
                        row.Cells[2].Value = ((BlindSelf)e).Accuracy.ToString();
                        disableCell(row, 3);
                        break;
                    case "cleanse":
                        disableCell(row, 1);
                        disableCell(row, 2);
                        disableCell(row, 3);
                        break;
                }
            }
        }

        private void buttonOK_Click(object sender, EventArgs eventArgs)
        {
            ability.Name = textBoxName.Text;
            ability.SpCost = (Int32)numericUpDownSP.Value;
            ability.Effects.Clear();
            Effect e = null;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                String _type = row.Cells[0].Value.ToString();
                int _pow = Int32.Parse(row.Cells[1].Value.ToString());
                int _acc = Int32.Parse(row.Cells[2].Value.ToString());
                int _crit = Int32.Parse(row.Cells[3].Value.ToString());
                switch (_type)
                {
                    case "pdmg":
                        e = new PhysicalDamage(_pow, _acc, _crit);
                        break;
                    case "mdmg":
                        e = new MagicalDamage(_pow, _acc, _crit);
                        break;
                    case "heal":
                        e = new Heal(_pow, _acc, _crit);
                        break;
                    case "spd":
                        e = new SPDrain(_pow, _acc, _crit);
                        break;
                    case "spr":
                        e = new SPRecovery(_pow, _acc, _crit);
                        break;
                    case "psn":
                        e = new PoisonEnemy(_acc);
                        break;
                    case "psnself":
                        e = new PoisonSelf(_acc);
                        break;
                    case "par":
                        e = new ParalyzeEnemy(_acc);
                        break;
                    case "parself":
                        e = new ParalyzeSelf(_acc);
                        break;
                    case "bli":
                        e = new BlindEnemy(_acc);
                        break;
                    case "bliself":
                        e = new BlindSelf(_acc);
                        break;
                    case "cleanse":
                        e = new Cleanse();
                        break;

                }
                ability.Effects.Add(e);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonAddEffect_Click(object sender, EventArgs e)
        {
            EffectSelector es = new EffectSelector();
            if (es.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Add();
                int rowNum = dataGridView1.RowCount - 1;
                dataGridView1.Rows[rowNum].Cells[0].Value = es.effectType;
                if(es.effectType=="psn"||es.effectType=="psnself"||es.effectType =="par"||es.effectType =="parself" || es.effectType == "bli" || es.effectType == "bliself")
                {
                    disableCell(rowNum, 1);
                    disableCell(rowNum, 3);
                }
                else if (es.effectType == "cleanse")
                {
                    disableCell(rowNum, 1);
                    disableCell(rowNum, 2);
                    disableCell(rowNum, 3);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch(e.ColumnIndex)
            {
                case 4:
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    break;
                case 5:
                    if (e.RowIndex > 0)
                    {
                        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                        dataGridView1.Rows.Remove(row);
                        dataGridView1.Rows.Insert(e.RowIndex - 1, row);
                    }
                    break;
                case 6:
                    if (e.RowIndex < (dataGridView1.Rows.Count - 1))
                    {
                        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                        dataGridView1.Rows.Remove(row);
                        dataGridView1.Rows.Insert(e.RowIndex + 1, row);
                    }
                    break;
                default:
                    break;
            }
        }

        private void disableCell(int row, int col)
        {
            DataGridViewCell cell = dataGridView1.Rows[row].Cells[col];
            cell.Value = 0;
            cell.ReadOnly = true;
            cell.Style.BackColor = Color.LightGray;
            cell.Style.ForeColor = Color.DarkGray;
        }

        private void disableCell(DataGridViewRow row, int col)
        {
            DataGridViewCell cell = row.Cells[col];
            cell.Value = 0;
            cell.ReadOnly = true;
            cell.Style.BackColor = Color.LightGray;
            cell.Style.ForeColor = Color.DarkGray;
        }
    }
}
