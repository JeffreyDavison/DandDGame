using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DandDProto
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
            pnlCharacterSelect.Visible = false;
            pnlItems.Visible = false;
            pnlBattle.Visible = false;
        }
        //Create the game and timer objects for the game. 
        Game game = new Game();
        System.Windows.Forms.Timer myTimer;
        int turn = 1;
        
        #region "Main Menu"
        private void btnPlay_Click(object sender, EventArgs e)
        {
            pnlCharacterSelect.Visible = true;
            btnWarrior.Visible = true;
            btnRanger.Visible = true;
            btnShaman.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region "Character Select Screen"
        bool character = false;
        private void btnWarrior_Click(object sender, EventArgs e)
        {
            PlayerImage.BackgroundImage = global::DandDProto.Properties.Resources.AxeImage;
            pnlCharacterSelect.BackgroundImage = global::DandDProto.Properties.Resources.HeroSelectionPane3;

            lblNameStat.Text = game.heros[0].getName();
            lblHealthStat.Text = "" + game.heros[0].getHealth();
            lblClassStat.Text = game.heros[0].getClass(); 
            lblAttackStat.Text = "" + game.heros[0].getAttack(); 
            lblCriticalHitStat.Text = "" + game.heros[0].getCriticalHit() + "%";
            lblEvasionStat.Text = "" + game.heros[0].getEvasion() + "%";
            lblSpecialAbilityStat.Text = game.heros[0].getSpecialAttackName();
            game.setPlayer(0);
            pbxHero.BackgroundImage = global::DandDProto.Properties.Resources.AxeBattle;
            character = true;
        }

        private void btnRanger_Click(object sender, EventArgs e)
        {
            PlayerImage.BackgroundImage = global::DandDProto.Properties.Resources.DrowImage;
            pnlCharacterSelect.BackgroundImage = global::DandDProto.Properties.Resources.HeroSelectionPane;

            lblNameStat.Text = game.heros[1].getName();
            lblHealthStat.Text = "" + game.heros[1].getHealth();
            lblClassStat.Text = game.heros[1].getClass();
            lblAttackStat.Text = "" + game.heros[1].getAttack();
            lblCriticalHitStat.Text = "" + game.heros[1].getCriticalHit() + "%";
            lblEvasionStat.Text = "" + game.heros[1].getEvasion() + "%";
            lblSpecialAbilityStat.Text = game.heros[1].getSpecialAttackName();
            game.setPlayer(1);
            pbxHero.BackgroundImage = global::DandDProto.Properties.Resources.DrowBattle;
            character = true;
        }

        private void btnShaman_Click(object sender, EventArgs e)
        {
            PlayerImage.BackgroundImage = global::DandDProto.Properties.Resources.ShamanImage;
            pnlCharacterSelect.BackgroundImage = global::DandDProto.Properties.Resources.HeroSelectionPane4;

            lblNameStat.Text = game.heros[2].getName();
            lblHealthStat.Text = "" + game.heros[2].getHealth();
            lblClassStat.Text = game.heros[2].getClass();
            lblAttackStat.Text = "" + game.heros[2].getAttack();
            lblCriticalHitStat.Text = "" + game.heros[2].getCriticalHit() + "%";
            lblEvasionStat.Text = "" + game.heros[2].getEvasion() + "%";
            lblSpecialAbilityStat.Text = game.heros[2].getSpecialAttackName();
            game.setPlayer(2);
            pbxHero.BackgroundImage = global::DandDProto.Properties.Resources.ShamanBattle;
            character = true;
            
        }
        

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(character == true)
            pnlItems.Visible = true;
        }
        #endregion

        #region "Items Menu"
        bool Weapon = false;
        bool Armour = false;
        private void btnItem1_Click(object sender, EventArgs e)
        {
            lblWeaponTypeStat.Text = "Axe";
            lblWeaponAttackStat.Text = "40";
            Weapon = true;
        }

        private void btnItem2_Click(object sender, EventArgs e)
        {
            lblWeaponTypeStat.Text = "Bow";
            lblWeaponAttackStat.Text = "30";
            Weapon = true;
        }

        private void btnItem3_Click(object sender, EventArgs e)
        {
            lblWeaponTypeStat.Text = "Staff";
            lblWeaponAttackStat.Text = "30";
            Weapon = true;
        }

        private void btnItem4_Click(object sender, EventArgs e)
        {
            lblArmourTypeStat.Text = "PlateMail";
            lblArmourDefenseStat.Text = "40";
            Armour = true;
        }

        private void btnItem5_Click(object sender, EventArgs e)
        {
            lblArmourTypeStat.Text = "Cloak";
            lblArmourDefenseStat.Text = "10";
            Armour = true;
        }

        private void btnItem6_Click(object sender, EventArgs e)
        {
            lblArmourTypeStat.Text = "Talisman";
            lblArmourDefenseStat.Text = "30";
            Armour = true;
        }
        #endregion

        //Button to head to the battle menu
        private void btnBattle_Click(object sender, EventArgs e)
        {
            if (Armour == true && Weapon == true)
            {
                game.SetWeapon(int.Parse(lblWeaponAttackStat.Text), lblWeaponTypeStat.Text);
                game.SetArmour(game.getPlayer(), int.Parse(lblArmourDefenseStat.Text), lblArmourTypeStat.Text);
                pnlBattle.Visible = true;
                lblHeroAttack.Text = "" + (game.heros[game.getPlayer()].getAttack() + game.heros[game.getPlayer()].getWeaponAttack());
                lblHeroArmour.Text = "" + game.heros[game.getPlayer()].getArmourDefense();
                lblEnemyAttack.Text = "" + game.enemy.getAttack();
                lblEnemyArmour.Text = "" + game.enemy.getDefense();
                btnAgain.Enabled = false;
            } 
        }

        //button to start the battle and set parameters for the timer
        private void btnStartBattle_Click(object sender, EventArgs e)
        {
            myTimer = new System.Windows.Forms.Timer();
            myTimer.Tick += new EventHandler(TimerEventProcessor);

            // Sets the timer interval to 5 seconds.
            myTimer.Interval = 1000;
            myTimer.Start();
           
            btnStartBattle.Enabled = false;
            pBarHeroHealth.Maximum = game.heros[game.getPlayer()].getHealth();
            pBarHeroHealth.Value = game.heros[game.getPlayer()].getHealth();
            pBarEnemyHealth.Maximum = game.enemy.getHealth();
            pBarEnemyHealth.Value = game.enemy.getHealth();
        
        }

        //Timer that handles the battle
        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            if (turn == 0)
            {
                lblBattle.Text = lblBattle.Text + Environment.NewLine + game.heros[game.getPlayer()].Defend(game.enemy.Strike());
                if (game.heros[game.getPlayer()].getHealthBattle() <= 0)
                {
                    myTimer.Stop();
                    pBarHeroHealth.Value = 0;
                    lblBattle.Text = lblBattle.Text + Environment.NewLine + "You have been Defeated!";
                    btnAgain.Enabled = true;
                }
                else 
                {
                pBarHeroHealth.Value = game.heros[game.getPlayer()].getHealthBattle();
                }
                turn++;
            }
            else if (turn == 1)
            {
                lblBattle.Text = lblBattle.Text + Environment.NewLine + game.enemy.Defend(game.heros[game.getPlayer()].Strike(), game.heros[game.getPlayer()].getName());
                if (game.enemy.getHealthBattle() <= 0)
                {
                    myTimer.Stop();
                    pBarEnemyHealth.Value = 0;
                    lblBattle.Text = lblBattle.Text + Environment.NewLine + "You have defeated the Enemy!";
                    btnAgain.Enabled = true;
                }
                else
                {
                    pBarEnemyHealth.Value = game.enemy.getHealthBattle();
                }
                turn--;
            }
        }

        //button to return to character menu
        private void btnAgain_Click(object sender, EventArgs e)
        {
            pnlBattle.Visible = false;
            pnlItems.Visible = false;
            pnlCharacterSelect.Visible = true;
            lblBattle.Text = "";
            pBarEnemyHealth.Value = 0;
            pBarHeroHealth.Value = 0;
            btnStartBattle.Enabled = true;
            game.enemy.setHealthBattle(game.enemy.getHealth());
            game.heros[game.getPlayer()].setHealthBattle(game.heros[game.getPlayer()].getHealth());
            turn = 1;
        }


    }
}
