using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DandDProto
{
    public class Demon : Character
    {

        Random random = new Random();
        public Demon(){}
        public Demon(int HP, int BDam, int UDam, int Chit, int evd, int Def)
        {
            this.setName("LifeStealer");
            this.setClass("Demon");
            this.setHealth(HP);
            this.setHealthBattle(HP);
            this.setAttack(BDam);
            this.setUpperAttack(UDam);
            this.setCriticalHit(Chit);
            this.setEvasion(evd);
            this.setDefense(Def);
        }// end Constructor Method

        //Basic attack method with critical hit posibility
        public override int Strike()
        {
            int strike = random.Next(getAttack(), getUpperAttack());
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

        public String Defend(int HAttack, string HeroName)
        {  
            int evade = random.Next(0, 100);
            if (evade <= this.getEvasion())
            {
                return getName() + " evaded the attack!";
            }
            else
            {
                int playerDamage = HAttack - this.getDefense();
                setHealthBattle(getHealthBattle() - playerDamage);
                return HeroName + " Attacked for" + playerDamage + " Damage!";
            }
        }
    }
}
