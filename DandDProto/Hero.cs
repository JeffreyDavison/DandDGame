using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DandDProto
{
    public abstract class Hero : Character
    {
        Weapon myWeapon;
        Armour myArmour;

        //default constructor
        public Hero()
        {
            myWeapon = new Weapon();
            myArmour = new Armour();
        }

        //abstracts for the methods of the hero characters. 
        private string SpecialAttackName;
        public abstract double SpecialAttack();
        public abstract string Defend(int Eattack);

        #region "Special Attack Getter and Setter"
        public void setSpecialAttackName(string specialattackname)
        {
            this.SpecialAttackName = specialattackname;
        }

        public string getSpecialAttackName()
        {
            return this.SpecialAttackName;
        }
        #endregion

        #region "Weapon setters"
        public void setWeaponType(string WeaponType)
        {
            myWeapon.setType(WeaponType);
        }

        public void setWeaponAttack(int WeaponAttack)
        {
            myWeapon.setAttack(WeaponAttack);
        }
        #endregion
        #region "Weapon getters"
        public string getWeaponType()
        {
            return myWeapon.getType();
        }

        public int getWeaponAttack()
        {
            return myWeapon.getAttack();
        }
        #endregion

        #region "Armour setters"
        public void setArmourType(string ArmourType)
        {
            myArmour.setType(ArmourType);
        }

        public void setArmourDefense(int ArmourDefense)
        {
            myArmour.setDefense(ArmourDefense);
        }
        #endregion
        #region "Armour getters"
        public string getArmourType()
        {
            return myArmour.getType();
        }

        public int getArmourDefense()
        {
            return myArmour.getDefense();
        }
        #endregion



    }
}
