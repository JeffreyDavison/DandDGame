using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DandDProto
{
    public class Weapon
    {
        private string Type;
        private int Attack;

        public Weapon(){}//Constructor

        #region "setters"
        public void setType(string type)
        {
            this.Type = type;
        }

        public void setAttack(int attack)
        {
            this.Attack = attack;
        }
        #endregion
        #region "getters"
        public string getType()
        {
            return this.Type;
        }

        public int getAttack()
        {
            return this.Attack;
        }
        #endregion
    }
}
