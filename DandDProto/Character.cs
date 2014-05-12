using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DandDProto
{
    public abstract class Character
    {
        //abstract Fields
        private string Name;
        private string Class;

        private int Health = 0;
        private int Defense = 0;

        private int Attack = 0;
        private int upperAttack = 0;

        private double Evasion = 0;
        private double CriticalHit = 0;
        private int HealthBattle = 0;


        //abstract methods
        public abstract int Strike();
        

        #region "Getter Methods"
        public string getName()
        {
            return this.Name;
        }

        public string getClass()
        {
            return this.Class;
        }

        public int getHealth()
        {
            return this.Health;
        }

        public int getHealthBattle()
        {
            return this.HealthBattle;
        }

        public int getAttack()
        {
            return this.Attack;
        }

        public int getUpperAttack()
        {
            return this.upperAttack;
        }

        public int getDefense()
        {
            return this.Defense;
        }

        public double getEvasion()
        {
            return this.Evasion;
        }

        public double getCriticalHit()
        {
            return this.CriticalHit;
        }
        #endregion

        #region "Setter Methods"
        public void setName(string name)
        {
            this.Name = name;
        }

        public void setClass(string playerClass)
        {
            this.Class = playerClass;
        }

        public void setHealth(int health)
        {
            this.Health = health;
        }

        public void setHealthBattle(int healthbattle)
        {
            this.HealthBattle = healthbattle;
        }

        public void setAttack(int attack)
        {
            this.Attack = attack;
        }

        public void setUpperAttack(int upperattack)
        {
            this.upperAttack = upperattack;
        }

        public void setDefense(int defense)
        {
            this.Defense = defense;
        }

        public void setEvasion(double evasion)
        {
            this.Evasion = evasion;
        }

        public void setCriticalHit(double criticalHit)
        {
            this.CriticalHit = criticalHit;
        }
        #endregion

    }
}
