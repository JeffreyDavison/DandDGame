using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DandDProto
{
    public class Armour
    {
        private string Type = "No Armour";
        private int Defense = 0;

        public Armour() { }//Constructor

        #region "setters"
        public void setType(string type)
        {
            this.Type = type;
        }

        public void setDefense(int defense)
        {
            this.Defense = defense;
        }
        #endregion
        #region "getters"
        public string getType()
        {
            return this.Type;
        }

        public int getDefense()
        {
            return this.Defense;
        }
        #endregion
    }
}
