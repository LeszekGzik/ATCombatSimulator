using ATCombatSimulator.Effects;
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
        public int level = 1;
        public int maxHP;
        public int currentHP;
        public int maxSP;
        public int currentSP;

        public int ATK = 1;
        public int DEF = 1;
        public int VIT = 1;
        public int SKL = 1;
        public int MDEF = 1;
        public int MATK = 1;
        public int AGI = 1;
        public int LCK = 1;

        public bool poisoned;
        public bool paralyzed;
        public bool cantmove;

        public Character()
        {
            abilities = new List<Ability>();
            abilities.Add(new Ability("Wait", 0));
            selectedAbility = abilities[0];
            reset();
        }

        public void reset()
        {
            maxHP = (10 + level) * VIT / 10;
            maxSP = (10 + level) * SKL / 20;
            currentHP = maxHP;
            currentSP = maxSP;
            clearBuffs();
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

            abilities.Clear();
            foreach (XmlNode abilityNode in doc.SelectNodes("//ability"))
            {
                Ability a = new Ability();
                int _pow, _acc, _crit;
                a.Name = abilityNode.Attributes["name"].Value;
                a.SpCost = Int32.Parse(abilityNode.Attributes["sp"].Value);
                foreach (XmlNode effectNode in doc.SelectNodes("//ability[@name='" + a.Name + "']/effect"))
                {
                    Effect e = null;
                    String _type = effectNode.Attributes["type"].Value;
                    try {
                        _pow = Int32.Parse(effectNode.Attributes["pow"].Value);
                    } catch(NullReferenceException) { _pow = 0; }
                    try
                    {
                        _acc = Int32.Parse(effectNode.Attributes["acc"].Value);
                    } catch (NullReferenceException) { _acc = 0; }
                    try
                    {
                        _crit = Int32.Parse(effectNode.Attributes["crit"].Value);
                    } catch (NullReferenceException) { _crit = 0; }
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
                        case "cleanse":
                            e = new Cleanse();
                            break;
                    }
                    a.Effects.Add(e);
                }
                abilities.Add(a);
            }
            reset();
            selectedAbility = abilities[0];
        }

        public void saveToXML(String fileName)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(docNode);

            XmlElement characterNode = doc.CreateElement("character");
            characterNode.SetAttribute("name", name);
            doc.AppendChild(characterNode);

            XmlElement statsNode = doc.CreateElement("stats");
            characterNode.AppendChild(statsNode);

            XmlElement statNode = doc.CreateElement("stat");
            statNode.SetAttribute("key", "level");
            statNode.SetAttribute("value", level.ToString());
            statsNode.AppendChild(statNode);

            statNode = doc.CreateElement("stat");
            statNode.SetAttribute("key", "ATK");
            statNode.SetAttribute("value", ATK.ToString());
            statsNode.AppendChild(statNode);

            statNode = doc.CreateElement("stat");
            statNode.SetAttribute("key", "DEF");
            statNode.SetAttribute("value", DEF.ToString());
            statsNode.AppendChild(statNode);

            statNode = doc.CreateElement("stat");
            statNode.SetAttribute("key", "VIT");
            statNode.SetAttribute("value", VIT.ToString());
            statsNode.AppendChild(statNode);

            statNode = doc.CreateElement("stat");
            statNode.SetAttribute("key", "SKL");
            statNode.SetAttribute("value", SKL.ToString());
            statsNode.AppendChild(statNode);

            statNode = doc.CreateElement("stat");
            statNode.SetAttribute("key", "MATK");
            statNode.SetAttribute("value", MATK.ToString());
            statsNode.AppendChild(statNode);

            statNode = doc.CreateElement("stat");
            statNode.SetAttribute("key", "MDEF");
            statNode.SetAttribute("value", MDEF.ToString());
            statsNode.AppendChild(statNode);

            statNode = doc.CreateElement("stat");
            statNode.SetAttribute("key", "AGI");
            statNode.SetAttribute("value", AGI.ToString());
            statsNode.AppendChild(statNode);

            statNode = doc.CreateElement("stat");
            statNode.SetAttribute("key", "LCK");
            statNode.SetAttribute("value", LCK.ToString());
            statsNode.AppendChild(statNode);

            XmlElement abilitiesNode = doc.CreateElement("abilities");
            characterNode.AppendChild(abilitiesNode);

            foreach(Ability a in abilities)
            {
                XmlElement abilityNode = doc.CreateElement("ability");
                abilityNode.SetAttribute("name", a.Name);
                abilityNode.SetAttribute("sp", a.SpCost.ToString());
                XmlDocumentFragment effectNode = doc.CreateDocumentFragment();
                effectNode.InnerXml = a.getEffectsAsXML();
                abilityNode.AppendChild(effectNode);
                abilitiesNode.AppendChild(abilityNode);
            }
            doc.Save(fileName);
        }

        internal bool isDead()
        {
            return (currentHP <= 0);
        }

        public bool hasEnoughSP()
        {
            return (currentSP >= selectedAbility.SpCost);
        }

        internal String attack(Character target)
        {
            return selectedAbility.execute(this, target);
        }

        internal String processBuffs()
        {
            String result = "";
            if (poisoned)
            {
                int poisonDmg = maxHP / 10;
                if (poisonDmg == 0)
                {
                    poisonDmg = 1;
                }
                currentHP -= poisonDmg;
                result += (name + " took " + poisonDmg + " damage from poison.\n");
            }
            if (paralyzed)
            {
                if (Effect.random.Next(0, 100) < 50)
                {
                    cantmove = true;
                    result += (name + " can't move due to paralysis!\n");
                }
            }
            return result;
        }

        internal void clearBuffs()
        {
            poisoned = false;
            paralyzed = false;
        }
    }
}
