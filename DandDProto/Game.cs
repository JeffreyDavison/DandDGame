/* 
 * Creator: Jeffrey Davison
 * Project: Create a Simple game with automated battle. 
 * This is a simple game where you select a hero and pick a weapon and armour. 
 * once you pick you will fight the enemy in automated battle. 
 * selecting the correct weapon for the character or correct armour will give a damage or defense boost. 
 * 
 * All Images are photoshopped from the Valve game DOTA 2 to fit the assignment. 
 * I claim no rights to images in the game, all characters, Items ,symbols and HUD belong to valve. 
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DandDProto
{
    public class Game
    {
        public Game(){}
        //array of Hero Characters
        public Hero[] heros = new Hero[] { new Warrior(1500,1500,150,200,7,15), 
                                    new Ranger(1300,1300, 175, 200, 4, 20), 
                                    new Wizard(1100,1100, 200, 250, 15, 15)};
        //create Enemy Object in game. 
        public Demon enemy = new Demon(1200,150,200,5,10,15);

        protected int Player = 0;

        #region "Setters"
        //a Region for the setter methods to access the methods of the heros and the enemys.
        public void setPlayer(int playerChoice)
        {
            this.Player = playerChoice;
        }

        public int getPlayer()
        {
            return this.Player;
        }

        public void SetWeapon(int Attack, string Type)
        {
            heros[Player].setWeaponAttack(Attack);
            heros[Player].setWeaponType(Type);
        }

        public void SetArmour(int player, int Defense, string Type)
        {
            heros[Player].setArmourDefense(Defense);
            heros[Player].setArmourType(Type);
        }
        #endregion

        #region "Attack Methods"
        // Methods to handle the battling in game - returning the formatted text data. 
        public string PlayerAttack() 
        {
            return enemy.Defend(heros[Player].Strike(), heros[Player].getName());
        }

        public string EnemyAttack()
        {
            return heros[Player].Defend(enemy.Strike());
        }
        #endregion



    }
}
