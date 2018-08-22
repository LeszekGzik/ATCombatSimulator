using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATCombatSimulator
{
    public class Character
    {
        public String name;
        public List<Ability> abilities;
        public Ability selectedAbility;
        public int level;
        public int maxHP;
        public int currentHP;
        public int maxSP;
        public int currentSP;

        public int ATK;
        public int DEF;
        public int VIT;
        public int SKL;
        public int MDEF;
        public int MATK;
        public int AGI;
        public int LCK;

        public void reset()
        {
            maxHP = (10 + level) * VIT / 10;
            maxSP = (10 + level) * SKL / 20;
            currentHP = maxHP;
            currentSP = maxSP;
        }
    }
}
