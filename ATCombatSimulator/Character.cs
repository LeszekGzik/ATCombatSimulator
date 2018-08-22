using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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

        public void loadFromXML(String fileName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            name = doc.SelectSingleNode("//character").Attributes["name"].Value;
            foreach (XmlNode statNode in doc.SelectNodes("//stat"))
            {
                switch(statNode.Attributes["key"].Value)
                {
                    case "level":
                        level = Int32.Parse(statNode.Attributes["value"].Value);
                        break;
                    case "ATK":
                        ATK = Int32.Parse(statNode.Attributes["value"].Value);
                        break;
                    case "DEF":
                        DEF = Int32.Parse(statNode.Attributes["value"].Value);
                        break;
                    case "VIT":
                        VIT = Int32.Parse(statNode.Attributes["value"].Value);
                        break;
                    case "SKL":
                        SKL = Int32.Parse(statNode.Attributes["value"].Value);
                        break;
                    case "MATK":
                        MATK = Int32.Parse(statNode.Attributes["value"].Value);
                        break;
                    case "MDEF":
                        MDEF = Int32.Parse(statNode.Attributes["value"].Value);
                        break;
                    case "AGI":
                        AGI = Int32.Parse(statNode.Attributes["value"].Value);
                        break;
                    case "LCK":
                        LCK = Int32.Parse(statNode.Attributes["value"].Value);
                        break;
                }
            }

            foreach (XmlNode abilityNode in doc.SelectNodes("//ability"))
            {
                Ability a = new Ability();
                a.Name = abilityNode.Attributes["name"].Value;
                a.Power = Int32.Parse(abilityNode.Attributes["pow"].Value);
                a.Crit = Double.Parse(abilityNode.Attributes["crit"].Value);
                a.Accuracy = Double.Parse(abilityNode.Attributes["acc"].Value);
                a.SpCost = Int32.Parse(abilityNode.Attributes["sp"].Value);
                a.Physical = (abilityNode.Attributes["type"].Value == "P");
                abilities.Add(a);
            }
            reset();
            selectedAbility = abilities[0];
        }
    }
}
