using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DandDProto
{
    public class Wizard : Hero
    {
        Random random = new Random();
        /// <summary>
        /// Shaman Class
        /// </summary>
        /// <param></param>
        public Wizard()
        {
        }
        //Character Constructor for the wizard class
        public Wizard(int HP, int BHP, int BDam, int UDam, int Chit, int evd)
        {
            this.setName("Rhasta");
            this.setClass("Wizard");
            this.setSpecialAttackName("Ether Shock");
            this.setHealth(HP);
            this.setHealthBattle(BHP);
            this.setAttack(BDam);
            this.setUpperAttack(UDam);
            this.setCriticalHit(Chit);
            this.setEvasion(evd);
        }// end Constructor Method

        //Attacking method that returns the attack damage in int form. 
        public override int Strike()
        {
            int strike = random.Next(getAttack(), getUpperAttack()) + getWeaponAttack();
            string weapon = getWeaponType();
            if (weapon == "Staff")
            {
                strike = strike + 10;
            }
             int Crit = random.Next(0, 100);
             if (Crit <= this.getCriticalHit())
             {
                 return strike * 2;
             }
             else
             {
                 return strike;
             }
        }
        //a Defend method that handles the enemys attack and out puts the formated battle text. 
        public override String Defend(int EAttack)
        {
             int evade = random.Next(0, 100);
             if (evade <= this.getEvasion())
             {
                 return getName() + " evaded the attack!";
             }
             else
             {
                 int playerDamage = EAttack - this.getArmourDefense();
                 string armour = getArmourType();
                 if (armour == "Robe")
                 {
                     playerDamage = playerDamage - 10;
                 }
                 setHealthBattle(getHealthBattle() - playerDamage);
                 return "The Enemy Attacked for" + playerDamage + " Damage!";
             }
        }

        // A special Attack method (un-implimented, Added for expantion)
        public override double SpecialAttack()
        {
            double strike = Strike() * 1.5;
            return strike;
        }


    }
}