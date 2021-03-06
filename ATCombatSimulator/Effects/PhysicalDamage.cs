﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATCombatSimulator.Effects
{
    public class PhysicalDamage : Effect
    {
        int power;
        int crit;
        int accuracy;

        public int Power { get => power; set => power = value; }
        public int Crit { get => crit; set => crit = value; }
        public int Accuracy { get => accuracy; set => accuracy = value; }

        public PhysicalDamage()
        {
            Type = "pdmg";
        }

        public PhysicalDamage(int _pow, int _acc, int _crit)
        {
            Type = "pdmg";
            Power = _pow;
            Accuracy = _acc;
            Crit = _crit;
        }

        public override String toXMLNode()
        {
            String node = "<effect type=\"" + Type + "\" pow=\"" + Power + "\" acc=\"" + Accuracy + "\" crit=\"" + Crit + "\" />";
            return node;
        }

        public override String execute(Character user, Character target)
        {
            String result = "";
            int hitPercent = Accuracy + 2 * user.AGI - 2 * target.AGI;
            if (user.blinded) { hitPercent /= 2; }
            int critPercent = Crit + user.LCK - target.LCK;
            double damage = (user.ATK * (10 + user.level) * Power) / (10 * target.DEF);

            //sprawdzenie trafienia
            if (random.Next(0, 100) < hitPercent)
            {
                //losowanie dmg
                damage *= (random.Next(90, 111) / 100.0);
                //sprawdzenie krytyka
                if (random.Next(0, 100) < critPercent)
                {
                    result += "Critical hit! ";
                    damage *= 1.5;
                }
                target.currentHP -= (int)damage;
                result += target.name + " took " + (int)damage + " damage.\n";
            }
            else
            {
                result += "Miss!\n";
            }
            return result;
        }
    }
}
