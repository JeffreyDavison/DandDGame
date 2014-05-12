namespace DandDProto
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.pnlCharacterSelect = new System.Windows.Forms.Panel();
            this.pnlItems = new System.Windows.Forms.Panel();
            this.pnlBattle = new System.Windows.Forms.Panel();
            this.btnAgain = new System.Windows.Forms.Button();
            this.lblEnemyArmour = new System.Windows.Forms.Label();
            this.lblHeroArmour = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEnemyAttack = new System.Windows.Forms.Label();
            this.lblHeroAttack = new System.Windows.Forms.Label();
            this.pBarEnemyHealth = new System.Windows.Forms.ProgressBar();
            this.pBarHeroHealth = new System.Windows.Forms.ProgressBar();
            this.lblBattle = new System.Windows.Forms.Label();
            this.btnStartBattle = new System.Windows.Forms.Button();
            this.pbxEnemy = new System.Windows.Forms.PictureBox();
            this.pbxHero = new System.Windows.Forms.PictureBox();
            this.btnBattle = new System.Windows.Forms.Button();
            this.lblArmourDefense = new System.Windows.Forms.Label();
            this.lblArmourDefenseStat = new System.Windows.Forms.Label();
            this.lblWeaponAttack = new System.Windows.Forms.Label();
            this.lblWeaponAttackStat = new System.Windows.Forms.Label();
            this.lblArmourType = new System.Windows.Forms.Label();
            this.lblArmourTypeStat = new System.Windows.Forms.Label();
            this.lblWeaponType = new System.Windows.Forms.Label();
            this.lblWeaponTypeStat = new System.Windows.Forms.Label();
            this.lblArmour = new System.Windows.Forms.Label();
            this.lblWeapons = new System.Windows.Forms.Label();
            this.btnItem6 = new System.Windows.Forms.Button();
            this.btnItem5 = new System.Windows.Forms.Button();
            this.btnItem4 = new System.Windows.Forms.Button();
            this.btnItem2 = new System.Windows.Forms.Button();
            this.btnItem3 = new System.Windows.Forms.Button();
            this.btnItem1 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblClassStat = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblSpecialAbilityStat = new System.Windows.Forms.Label();
            this.lblEvasionStat = new System.Windows.Forms.Label();
            this.lblCriticalHitStat = new System.Windows.Forms.Label();
            this.lblAttackStat = new System.Windows.Forms.Label();
            this.lblHealthStat = new System.Windows.Forms.Label();
            this.lblNameStat = new System.Windows.Forms.Label();
            this.lblSpecialAttack = new System.Windows.Forms.Label();
            this.lblEvasion = new System.Windows.Forms.Label();
            this.lblCriticalHit = new System.Windows.Forms.Label();
            this.lblAttack = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.PlayerImage = new System.Windows.Forms.PictureBox();
            this.btnShaman = new System.Windows.Forms.Button();
            this.btnRanger = new System.Windows.Forms.Button();
            this.btnWarrior = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pnlMainMenu.SuspendLayout();
            this.pnlCharacterSelect.SuspendLayout();
            this.pnlItems.SuspendLayout();
            this.pnlBattle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.BackgroundImage = global::DandDProto.Properties.Resources.Splash;
            this.pnlMainMenu.Controls.Add(this.pnlCharacterSelect);
            this.pnlMainMenu.Controls.Add(this.btnExit);
            this.pnlMainMenu.Controls.Add(this.btnPlay);
            this.pnlMainMenu.Location = new System.Drawing.Point(2, 1);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(800, 600);
            this.pnlMainMenu.TabIndex = 0;
            // 
            // pnlCharacterSelect
            // 
            this.pnlCharacterSelect.BackgroundImage = global::DandDProto.Properties.Resources.HeroSelectionPane2;
            this.pnlCharacterSelect.Controls.Add(this.pnlItems);
            this.pnlCharacterSelect.Controls.Add(this.btnNext);
            this.pnlCharacterSelect.Controls.Add(this.lblClassStat);
            this.pnlCharacterSelect.Controls.Add(this.lblClass);
            this.pnlCharacterSelect.Controls.Add(this.lblSpecialAbilityStat);
            this.pnlCharacterSelect.Controls.Add(this.lblEvasionStat);
            this.pnlCharacterSelect.Controls.Add(this.lblCriticalHitStat);
            this.pnlCharacterSelect.Controls.Add(this.lblAttackStat);
            this.pnlCharacterSelect.Controls.Add(this.lblHealthStat);
            this.pnlCharacterSelect.Controls.Add(this.lblNameStat);
            this.pnlCharacterSelect.Controls.Add(this.lblSpecialAttack);
            this.pnlCharacterSelect.Controls.Add(this.lblEvasion);
            this.pnlCharacterSelect.Controls.Add(this.lblCriticalHit);
            this.pnlCharacterSelect.Controls.Add(this.lblAttack);
            this.pnlCharacterSelect.Controls.Add(this.lblHealth);
            this.pnlCharacterSelect.Controls.Add(this.lblName);
            this.pnlCharacterSelect.Controls.Add(this.PlayerImage);
            this.pnlCharacterSelect.Controls.Add(this.btnShaman);
            this.pnlCharacterSelect.Controls.Add(this.btnRanger);
            this.pnlCharacterSelect.Controls.Add(this.btnWarrior);
            this.pnlCharacterSelect.Location = new System.Drawing.Point(0, 0);
            this.pnlCharacterSelect.Name = "pnlCharacterSelect";
            this.pnlCharacterSelect.Size = new System.Drawing.Size(800, 597);
            this.pnlCharacterSelect.TabIndex = 2;
            // 
            // pnlItems
            // 
            this.pnlItems.BackgroundImage = global::DandDProto.Properties.Resources.ItemPane;
            this.pnlItems.Controls.Add(this.pnlBattle);
            this.pnlItems.Controls.Add(this.btnBattle);
            this.pnlItems.Controls.Add(this.lblArmourDefense);
            this.pnlItems.Controls.Add(this.lblArmourDefenseStat);
            this.pnlItems.Controls.Add(this.lblWeaponAttack);
            this.pnlItems.Controls.Add(this.lblWeaponAttackStat);
            this.pnlItems.Controls.Add(this.lblArmourType);
            this.pnlItems.Controls.Add(this.lblArmourTypeStat);
            this.pnlItems.Controls.Add(this.lblWeaponType);
            this.pnlItems.Controls.Add(this.lblWeaponTypeStat);
            this.pnlItems.Controls.Add(this.lblArmour);
            this.pnlItems.Controls.Add(this.lblWeapons);
            this.pnlItems.Controls.Add(this.btnItem6);
            this.pnlItems.Controls.Add(this.btnItem5);
            this.pnlItems.Controls.Add(this.btnItem4);
            this.pnlItems.Controls.Add(this.btnItem2);
            this.pnlItems.Controls.Add(this.btnItem3);
            this.pnlItems.Controls.Add(this.btnItem1);
            this.pnlItems.Location = new System.Drawing.Point(0, 0);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(800, 594);
            this.pnlItems.TabIndex = 19;
            // 
            // pnlBattle
            // 
            this.pnlBattle.BackgroundImage = global::DandDProto.Properties.Resources.Battle;
            this.pnlBattle.Controls.Add(this.btnAgain);
            this.pnlBattle.Controls.Add(this.lblEnemyArmour);
            this.pnlBattle.Controls.Add(this.lblHeroArmour);
            this.pnlBattle.Controls.Add(this.panel1);
            this.pnlBattle.Controls.Add(this.lblEnemyAttack);
            this.pnlBattle.Controls.Add(this.lblHeroAttack);
            this.pnlBattle.Controls.Add(this.pBarEnemyHealth);
            this.pnlBattle.Controls.Add(this.pBarHeroHealth);
            this.pnlBattle.Controls.Add(this.lblBattle);
            this.pnlBattle.Controls.Add(this.btnStartBattle);
            this.pnlBattle.Controls.Add(this.pbxEnemy);
            this.pnlBattle.Controls.Add(this.pbxHero);
            this.pnlBattle.Location = new System.Drawing.Point(0, 0);
            this.pnlBattle.Name = "pnlBattle";
            this.pnlBattle.Size = new System.Drawing.Size(800, 591);
            this.pnlBattle.TabIndex = 19;
            // 
            // btnAgain
            // 
            this.btnAgain.Location = new System.Drawing.Point(421, 376);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(75, 23);
            this.btnAgain.TabIndex = 18;
            this.btnAgain.Text = "Again?";
            this.btnAgain.UseVisualStyleBackColor = true;
            this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click);
            // 
            // lblEnemyArmour
            // 
            this.lblEnemyArmour.AutoSize = true;
            this.lblEnemyArmour.BackColor = System.Drawing.Color.Black;
            this.lblEnemyArmour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEnemyArmour.ForeColor = System.Drawing.Color.White;
            this.lblEnemyArmour.Location = new System.Drawing.Point(577, 534);
            this.lblEnemyArmour.Margin = new System.Windows.Forms.Padding(5);
            this.lblEnemyArmour.Name = "lblEnemyArmour";
            this.lblEnemyArmour.Size = new System.Drawing.Size(46, 17);
            this.lblEnemyArmour.TabIndex = 17;
            this.lblEnemyArmour.Text = "label2";
            // 
            // lblHeroArmour
            // 
            this.lblHeroArmour.AutoSize = true;
            this.lblHeroArmour.BackColor = System.Drawing.Color.Black;
            this.lblHeroArmour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHeroArmour.ForeColor = System.Drawing.Color.White;
            this.lblHeroArmour.Location = new System.Drawing.Point(201, 534);
            this.lblHeroArmour.Margin = new System.Windows.Forms.Padding(5);
            this.lblHeroArmour.Name = "lblHeroArmour";
            this.lblHeroArmour.Size = new System.Drawing.Size(46, 17);
            this.lblHeroArmour.TabIndex = 16;
            this.lblHeroArmour.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(293, 458);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 106);
            this.panel1.TabIndex = 15;
            // 
            // lblEnemyAttack
            // 
            this.lblEnemyAttack.AutoSize = true;
            this.lblEnemyAttack.BackColor = System.Drawing.Color.Transparent;
            this.lblEnemyAttack.ForeColor = System.Drawing.Color.White;
            this.lblEnemyAttack.Location = new System.Drawing.Point(536, 464);
            this.lblEnemyAttack.Name = "lblEnemyAttack";
            this.lblEnemyAttack.Size = new System.Drawing.Size(46, 17);
            this.lblEnemyAttack.TabIndex = 14;
            this.lblEnemyAttack.Text = "label2";
            // 
            // lblHeroAttack
            // 
            this.lblHeroAttack.AutoSize = true;
            this.lblHeroAttack.BackColor = System.Drawing.Color.Transparent;
            this.lblHeroAttack.ForeColor = System.Drawing.Color.White;
            this.lblHeroAttack.Location = new System.Drawing.Point(218, 464);
            this.lblHeroAttack.Name = "lblHeroAttack";
            this.lblHeroAttack.Size = new System.Drawing.Size(46, 17);
            this.lblHeroAttack.TabIndex = 13;
            this.lblHeroAttack.Text = "label1";
            // 
            // pBarEnemyHealth
            // 
            this.pBarEnemyHealth.Location = new System.Drawing.Point(421, 418);
            this.pBarEnemyHealth.MarqueeAnimationSpeed = 50;
            this.pBarEnemyHealth.Name = "pBarEnemyHealth";
            this.pBarEnemyHealth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pBarEnemyHealth.RightToLeftLayout = true;
            this.pBarEnemyHealth.Size = new System.Drawing.Size(184, 19);
            this.pBarEnemyHealth.TabIndex = 12;
            // 
            // pBarHeroHealth
            // 
            this.pBarHeroHealth.Location = new System.Drawing.Point(196, 418);
            this.pBarHeroHealth.MarqueeAnimationSpeed = 50;
            this.pBarHeroHealth.Name = "pBarHeroHealth";
            this.pBarHeroHealth.Size = new System.Drawing.Size(184, 19);
            this.pBarHeroHealth.TabIndex = 11;
            // 
            // lblBattle
            // 
            this.lblBattle.AutoSize = true;
            this.lblBattle.BackColor = System.Drawing.Color.Transparent;
            this.lblBattle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblBattle.ForeColor = System.Drawing.Color.White;
            this.lblBattle.Location = new System.Drawing.Point(296, 42);
            this.lblBattle.Name = "lblBattle";
            this.lblBattle.Size = new System.Drawing.Size(0, 15);
            this.lblBattle.TabIndex = 8;
            // 
            // btnStartBattle
            // 
            this.btnStartBattle.Location = new System.Drawing.Point(305, 376);
            this.btnStartBattle.Name = "btnStartBattle";
            this.btnStartBattle.Size = new System.Drawing.Size(75, 23);
            this.btnStartBattle.TabIndex = 7;
            this.btnStartBattle.Text = "Start";
            this.btnStartBattle.UseVisualStyleBackColor = true;
            this.btnStartBattle.Click += new System.EventHandler(this.btnStartBattle_Click);
            // 
            // pbxEnemy
            // 
            this.pbxEnemy.BackgroundImage = global::DandDProto.Properties.Resources.EnemyBattle;
            this.pbxEnemy.Location = new System.Drawing.Point(398, 380);
            this.pbxEnemy.Name = "pbxEnemy";
            this.pbxEnemy.Size = new System.Drawing.Size(402, 214);
            this.pbxEnemy.TabIndex = 1;
            this.pbxEnemy.TabStop = false;
            // 
            // pbxHero
            // 
            this.pbxHero.BackgroundImage = global::DandDProto.Properties.Resources.ShamanBattle;
            this.pbxHero.Location = new System.Drawing.Point(0, 380);
            this.pbxHero.Name = "pbxHero";
            this.pbxHero.Size = new System.Drawing.Size(402, 214);
            this.pbxHero.TabIndex = 0;
            this.pbxHero.TabStop = false;
            // 
            // btnBattle
            // 
            this.btnBattle.Location = new System.Drawing.Point(670, 543);
            this.btnBattle.Name = "btnBattle";
            this.btnBattle.Size = new System.Drawing.Size(75, 23);
            this.btnBattle.TabIndex = 18;
            this.btnBattle.Text = "Fight!";
            this.btnBattle.UseVisualStyleBackColor = true;
            this.btnBattle.Click += new System.EventHandler(this.btnBattle_Click);
            // 
            // lblArmourDefense
            // 
            this.lblArmourDefense.AutoSize = true;
            this.lblArmourDefense.BackColor = System.Drawing.Color.Transparent;
            this.lblArmourDefense.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArmourDefense.ForeColor = System.Drawing.Color.White;
            this.lblArmourDefense.Location = new System.Drawing.Point(447, 244);
            this.lblArmourDefense.Name = "lblArmourDefense";
            this.lblArmourDefense.Size = new System.Drawing.Size(148, 22);
            this.lblArmourDefense.TabIndex = 17;
            this.lblArmourDefense.Text = "Armour Defense:";
            // 
            // lblArmourDefenseStat
            // 
            this.lblArmourDefenseStat.AutoSize = true;
            this.lblArmourDefenseStat.BackColor = System.Drawing.Color.Transparent;
            this.lblArmourDefenseStat.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArmourDefenseStat.ForeColor = System.Drawing.Color.White;
            this.lblArmourDefenseStat.Location = new System.Drawing.Point(605, 244);
            this.lblArmourDefenseStat.Name = "lblArmourDefenseStat";
            this.lblArmourDefenseStat.Size = new System.Drawing.Size(0, 22);
            this.lblArmourDefenseStat.TabIndex = 16;
            // 
            // lblWeaponAttack
            // 
            this.lblWeaponAttack.AutoSize = true;
            this.lblWeaponAttack.BackColor = System.Drawing.Color.Transparent;
            this.lblWeaponAttack.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeaponAttack.ForeColor = System.Drawing.Color.White;
            this.lblWeaponAttack.Location = new System.Drawing.Point(84, 244);
            this.lblWeaponAttack.Name = "lblWeaponAttack";
            this.lblWeaponAttack.Size = new System.Drawing.Size(140, 22);
            this.lblWeaponAttack.TabIndex = 15;
            this.lblWeaponAttack.Text = "Weapon Attack:";
            // 
            // lblWeaponAttackStat
            // 
            this.lblWeaponAttackStat.AutoSize = true;
            this.lblWeaponAttackStat.BackColor = System.Drawing.Color.Transparent;
            this.lblWeaponAttackStat.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeaponAttackStat.ForeColor = System.Drawing.Color.White;
            this.lblWeaponAttackStat.Location = new System.Drawing.Point(242, 244);
            this.lblWeaponAttackStat.Name = "lblWeaponAttackStat";
            this.lblWeaponAttackStat.Size = new System.Drawing.Size(0, 22);
            this.lblWeaponAttackStat.TabIndex = 14;
            // 
            // lblArmourType
            // 
            this.lblArmourType.AutoSize = true;
            this.lblArmourType.BackColor = System.Drawing.Color.Transparent;
            this.lblArmourType.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArmourType.ForeColor = System.Drawing.Color.White;
            this.lblArmourType.Location = new System.Drawing.Point(447, 198);
            this.lblArmourType.Name = "lblArmourType";
            this.lblArmourType.Size = new System.Drawing.Size(123, 22);
            this.lblArmourType.TabIndex = 13;
            this.lblArmourType.Text = "Armour Type:";
            // 
            // lblArmourTypeStat
            // 
            this.lblArmourTypeStat.AutoSize = true;
            this.lblArmourTypeStat.BackColor = System.Drawing.Color.Transparent;
            this.lblArmourTypeStat.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArmourTypeStat.ForeColor = System.Drawing.Color.White;
            this.lblArmourTypeStat.Location = new System.Drawing.Point(605, 198);
            this.lblArmourTypeStat.Name = "lblArmourTypeStat";
            this.lblArmourTypeStat.Size = new System.Drawing.Size(0, 22);
            this.lblArmourTypeStat.TabIndex = 12;
            // 
            // lblWeaponType
            // 
            this.lblWeaponType.AutoSize = true;
            this.lblWeaponType.BackColor = System.Drawing.Color.Transparent;
            this.lblWeaponType.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeaponType.ForeColor = System.Drawing.Color.White;
            this.lblWeaponType.Location = new System.Drawing.Point(84, 198);
            this.lblWeaponType.Name = "lblWeaponType";
            this.lblWeaponType.Size = new System.Drawing.Size(125, 22);
            this.lblWeaponType.TabIndex = 11;
            this.lblWeaponType.Text = "Weapon Type:";
            // 
            // lblWeaponTypeStat
            // 
            this.lblWeaponTypeStat.AutoSize = true;
            this.lblWeaponTypeStat.BackColor = System.Drawing.Color.Transparent;
            this.lblWeaponTypeStat.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeaponTypeStat.ForeColor = System.Drawing.Color.White;
            this.lblWeaponTypeStat.Location = new System.Drawing.Point(242, 198);
            this.lblWeaponTypeStat.Name = "lblWeaponTypeStat";
            this.lblWeaponTypeStat.Size = new System.Drawing.Size(0, 22);
            this.lblWeaponTypeStat.TabIndex = 10;
            // 
            // lblArmour
            // 
            this.lblArmour.AutoSize = true;
            this.lblArmour.BackColor = System.Drawing.Color.Transparent;
            this.lblArmour.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArmour.ForeColor = System.Drawing.Color.White;
            this.lblArmour.Location = new System.Drawing.Point(511, 147);
            this.lblArmour.Name = "lblArmour";
            this.lblArmour.Size = new System.Drawing.Size(161, 29);
            this.lblArmour.TabIndex = 7;
            this.lblArmour.Text = "Armour Stats";
            // 
            // lblWeapons
            // 
            this.lblWeapons.AutoSize = true;
            this.lblWeapons.BackColor = System.Drawing.Color.Transparent;
            this.lblWeapons.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeapons.ForeColor = System.Drawing.Color.White;
            this.lblWeapons.Location = new System.Drawing.Point(140, 147);
            this.lblWeapons.Name = "lblWeapons";
            this.lblWeapons.Size = new System.Drawing.Size(163, 29);
            this.lblWeapons.TabIndex = 6;
            this.lblWeapons.Text = "Weapon Stats";
            // 
            // btnItem6
            // 
            this.btnItem6.BackgroundImage = global::DandDProto.Properties.Resources.Talisman;
            this.btnItem6.Location = new System.Drawing.Point(645, 461);
            this.btnItem6.Name = "btnItem6";
            this.btnItem6.Size = new System.Drawing.Size(100, 59);
            this.btnItem6.TabIndex = 5;
            this.btnItem6.UseVisualStyleBackColor = true;
            this.btnItem6.Click += new System.EventHandler(this.btnItem6_Click);
            // 
            // btnItem5
            // 
            this.btnItem5.BackgroundImage = global::DandDProto.Properties.Resources.Hood;
            this.btnItem5.Location = new System.Drawing.Point(539, 461);
            this.btnItem5.Name = "btnItem5";
            this.btnItem5.Size = new System.Drawing.Size(100, 59);
            this.btnItem5.TabIndex = 4;
            this.btnItem5.UseVisualStyleBackColor = true;
            this.btnItem5.Click += new System.EventHandler(this.btnItem5_Click);
            // 
            // btnItem4
            // 
            this.btnItem4.BackgroundImage = global::DandDProto.Properties.Resources.Mail;
            this.btnItem4.Location = new System.Drawing.Point(433, 461);
            this.btnItem4.Name = "btnItem4";
            this.btnItem4.Size = new System.Drawing.Size(100, 59);
            this.btnItem4.TabIndex = 3;
            this.btnItem4.UseVisualStyleBackColor = true;
            this.btnItem4.Click += new System.EventHandler(this.btnItem4_Click);
            // 
            // btnItem2
            // 
            this.btnItem2.BackColor = System.Drawing.Color.Transparent;
            this.btnItem2.BackgroundImage = global::DandDProto.Properties.Resources.Arrows;
            this.btnItem2.Location = new System.Drawing.Point(158, 461);
            this.btnItem2.Name = "btnItem2";
            this.btnItem2.Size = new System.Drawing.Size(100, 59);
            this.btnItem2.TabIndex = 2;
            this.btnItem2.UseVisualStyleBackColor = false;
            this.btnItem2.Click += new System.EventHandler(this.btnItem2_Click);
            // 
            // btnItem3
            // 
            this.btnItem3.BackgroundImage = global::DandDProto.Properties.Resources.Staff;
            this.btnItem3.Location = new System.Drawing.Point(264, 461);
            this.btnItem3.Name = "btnItem3";
            this.btnItem3.Size = new System.Drawing.Size(100, 59);
            this.btnItem3.TabIndex = 1;
            this.btnItem3.UseVisualStyleBackColor = true;
            this.btnItem3.Click += new System.EventHandler(this.btnItem3_Click);
            // 
            // btnItem1
            // 
            this.btnItem1.BackgroundImage = global::DandDProto.Properties.Resources.Axe;
            this.btnItem1.Location = new System.Drawing.Point(52, 461);
            this.btnItem1.Name = "btnItem1";
            this.btnItem1.Size = new System.Drawing.Size(100, 59);
            this.btnItem1.TabIndex = 0;
            this.btnItem1.UseVisualStyleBackColor = true;
            this.btnItem1.Click += new System.EventHandler(this.btnItem1_Click);
            // 
            // btnNext
            // 
            this.btnNext.AllowDrop = true;
            this.btnNext.Location = new System.Drawing.Point(678, 543);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 18;
            this.btnNext.Text = "Gear Up";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblClassStat
            // 
            this.lblClassStat.AutoSize = true;
            this.lblClassStat.BackColor = System.Drawing.Color.Transparent;
            this.lblClassStat.ForeColor = System.Drawing.Color.White;
            this.lblClassStat.Location = new System.Drawing.Point(649, 176);
            this.lblClassStat.Name = "lblClassStat";
            this.lblClassStat.Size = new System.Drawing.Size(0, 17);
            this.lblClassStat.TabIndex = 17;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.BackColor = System.Drawing.Color.Transparent;
            this.lblClass.ForeColor = System.Drawing.Color.White;
            this.lblClass.Location = new System.Drawing.Point(571, 176);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(46, 17);
            this.lblClass.TabIndex = 16;
            this.lblClass.Text = "Class:";
            // 
            // lblSpecialAbilityStat
            // 
            this.lblSpecialAbilityStat.AutoSize = true;
            this.lblSpecialAbilityStat.BackColor = System.Drawing.Color.Transparent;
            this.lblSpecialAbilityStat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSpecialAbilityStat.Location = new System.Drawing.Point(571, 382);
            this.lblSpecialAbilityStat.Name = "lblSpecialAbilityStat";
            this.lblSpecialAbilityStat.Size = new System.Drawing.Size(0, 17);
            this.lblSpecialAbilityStat.TabIndex = 15;
            // 
            // lblEvasionStat
            // 
            this.lblEvasionStat.AutoSize = true;
            this.lblEvasionStat.BackColor = System.Drawing.Color.Transparent;
            this.lblEvasionStat.ForeColor = System.Drawing.Color.White;
            this.lblEvasionStat.Location = new System.Drawing.Point(649, 311);
            this.lblEvasionStat.Name = "lblEvasionStat";
            this.lblEvasionStat.Size = new System.Drawing.Size(0, 17);
            this.lblEvasionStat.TabIndex = 14;
            // 
            // lblCriticalHitStat
            // 
            this.lblCriticalHitStat.AutoSize = true;
            this.lblCriticalHitStat.BackColor = System.Drawing.Color.Transparent;
            this.lblCriticalHitStat.ForeColor = System.Drawing.Color.White;
            this.lblCriticalHitStat.Location = new System.Drawing.Point(649, 277);
            this.lblCriticalHitStat.Name = "lblCriticalHitStat";
            this.lblCriticalHitStat.Size = new System.Drawing.Size(0, 17);
            this.lblCriticalHitStat.TabIndex = 13;
            // 
            // lblAttackStat
            // 
            this.lblAttackStat.AutoSize = true;
            this.lblAttackStat.BackColor = System.Drawing.Color.Transparent;
            this.lblAttackStat.ForeColor = System.Drawing.Color.White;
            this.lblAttackStat.Location = new System.Drawing.Point(649, 244);
            this.lblAttackStat.Name = "lblAttackStat";
            this.lblAttackStat.Size = new System.Drawing.Size(0, 17);
            this.lblAttackStat.TabIndex = 12;
            // 
            // lblHealthStat
            // 
            this.lblHealthStat.AutoSize = true;
            this.lblHealthStat.BackColor = System.Drawing.Color.Transparent;
            this.lblHealthStat.ForeColor = System.Drawing.Color.White;
            this.lblHealthStat.Location = new System.Drawing.Point(649, 210);
            this.lblHealthStat.Name = "lblHealthStat";
            this.lblHealthStat.Size = new System.Drawing.Size(0, 17);
            this.lblHealthStat.TabIndex = 11;
            // 
            // lblNameStat
            // 
            this.lblNameStat.AutoSize = true;
            this.lblNameStat.BackColor = System.Drawing.Color.Transparent;
            this.lblNameStat.ForeColor = System.Drawing.Color.White;
            this.lblNameStat.Location = new System.Drawing.Point(649, 147);
            this.lblNameStat.Name = "lblNameStat";
            this.lblNameStat.Size = new System.Drawing.Size(0, 17);
            this.lblNameStat.TabIndex = 10;
            // 
            // lblSpecialAttack
            // 
            this.lblSpecialAttack.AutoSize = true;
            this.lblSpecialAttack.BackColor = System.Drawing.Color.Transparent;
            this.lblSpecialAttack.ForeColor = System.Drawing.Color.White;
            this.lblSpecialAttack.Location = new System.Drawing.Point(571, 346);
            this.lblSpecialAttack.Name = "lblSpecialAttack";
            this.lblSpecialAttack.Size = new System.Drawing.Size(95, 17);
            this.lblSpecialAttack.TabIndex = 9;
            this.lblSpecialAttack.Text = "Special Ability";
            // 
            // lblEvasion
            // 
            this.lblEvasion.AutoSize = true;
            this.lblEvasion.BackColor = System.Drawing.Color.Transparent;
            this.lblEvasion.ForeColor = System.Drawing.Color.White;
            this.lblEvasion.Location = new System.Drawing.Point(571, 311);
            this.lblEvasion.Name = "lblEvasion";
            this.lblEvasion.Size = new System.Drawing.Size(62, 17);
            this.lblEvasion.TabIndex = 8;
            this.lblEvasion.Text = "Evasion:";
            // 
            // lblCriticalHit
            // 
            this.lblCriticalHit.AutoSize = true;
            this.lblCriticalHit.BackColor = System.Drawing.Color.Transparent;
            this.lblCriticalHit.ForeColor = System.Drawing.Color.White;
            this.lblCriticalHit.Location = new System.Drawing.Point(571, 277);
            this.lblCriticalHit.Name = "lblCriticalHit";
            this.lblCriticalHit.Size = new System.Drawing.Size(71, 17);
            this.lblCriticalHit.TabIndex = 7;
            this.lblCriticalHit.Text = "CriticalHit:";
            // 
            // lblAttack
            // 
            this.lblAttack.AutoSize = true;
            this.lblAttack.BackColor = System.Drawing.Color.Transparent;
            this.lblAttack.ForeColor = System.Drawing.Color.White;
            this.lblAttack.Location = new System.Drawing.Point(571, 244);
            this.lblAttack.Name = "lblAttack";
            this.lblAttack.Size = new System.Drawing.Size(51, 17);
            this.lblAttack.TabIndex = 6;
            this.lblAttack.Text = "Attack:";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.BackColor = System.Drawing.Color.Transparent;
            this.lblHealth.ForeColor = System.Drawing.Color.White;
            this.lblHealth.Location = new System.Drawing.Point(571, 210);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(53, 17);
            this.lblHealth.TabIndex = 5;
            this.lblHealth.Text = "Health:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(571, 147);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name:";
            // 
            // PlayerImage
            // 
            this.PlayerImage.BackgroundImage = global::DandDProto.Properties.Resources.BlankImage;
            this.PlayerImage.Location = new System.Drawing.Point(333, 147);
            this.PlayerImage.Name = "PlayerImage";
            this.PlayerImage.Size = new System.Drawing.Size(213, 240);
            this.PlayerImage.TabIndex = 3;
            this.PlayerImage.TabStop = false;
            // 
            // btnShaman
            // 
            this.btnShaman.BackgroundImage = global::DandDProto.Properties.Resources.Shaman_Button;
            this.btnShaman.Location = new System.Drawing.Point(31, 386);
            this.btnShaman.Name = "btnShaman";
            this.btnShaman.Size = new System.Drawing.Size(240, 140);
            this.btnShaman.TabIndex = 2;
            this.btnShaman.UseVisualStyleBackColor = true;
            this.btnShaman.Click += new System.EventHandler(this.btnShaman_Click);
            // 
            // btnRanger
            // 
            this.btnRanger.BackgroundImage = global::DandDProto.Properties.Resources.Drow_Button;
            this.btnRanger.Location = new System.Drawing.Point(31, 230);
            this.btnRanger.Name = "btnRanger";
            this.btnRanger.Size = new System.Drawing.Size(240, 140);
            this.btnRanger.TabIndex = 1;
            this.btnRanger.UseVisualStyleBackColor = true;
            this.btnRanger.Click += new System.EventHandler(this.btnRanger_Click);
            // 
            // btnWarrior
            // 
            this.btnWarrior.BackgroundImage = global::DandDProto.Properties.Resources.Axe_Button;
            this.btnWarrior.Location = new System.Drawing.Point(31, 75);
            this.btnWarrior.Name = "btnWarrior";
            this.btnWarrior.Size = new System.Drawing.Size(240, 140);
            this.btnWarrior.TabIndex = 0;
            this.btnWarrior.UseVisualStyleBackColor = true;
            this.btnWarrior.Click += new System.EventHandler(this.btnWarrior_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::DandDProto.Properties.Resources.Exit;
            this.btnExit.Location = new System.Drawing.Point(530, 406);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(155, 100);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = global::DandDProto.Properties.Resources.Play;
            this.btnPlay.Location = new System.Drawing.Point(116, 406);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(155, 100);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 593);
            this.Controls.Add(this.pnlMainMenu);
            this.Name = "GUI";
            this.Text = "Battle Arena";
            this.pnlMainMenu.ResumeLayout(false);
            this.pnlCharacterSelect.ResumeLayout(false);
            this.pnlCharacterSelect.PerformLayout();
            this.pnlItems.ResumeLayout(false);
            this.pnlItems.PerformLayout();
            this.pnlBattle.ResumeLayout(false);
            this.pnlBattle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Panel pnlCharacterSelect;
        private System.Windows.Forms.Button btnShaman;
        private System.Windows.Forms.Button btnRanger;
        private System.Windows.Forms.Button btnWarrior;
        private System.Windows.Forms.PictureBox PlayerImage;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSpecialAbilityStat;
        private System.Windows.Forms.Label lblEvasionStat;
        private System.Windows.Forms.Label lblCriticalHitStat;
        private System.Windows.Forms.Label lblAttackStat;
        private System.Windows.Forms.Label lblHealthStat;
        private System.Windows.Forms.Label lblNameStat;
        private System.Windows.Forms.Label lblSpecialAttack;
        private System.Windows.Forms.Label lblEvasion;
        private System.Windows.Forms.Label lblCriticalHit;
        private System.Windows.Forms.Label lblAttack;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label lblClassStat;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel pnlItems;
        private System.Windows.Forms.Button btnItem6;
        private System.Windows.Forms.Button btnItem5;
        private System.Windows.Forms.Button btnItem4;
        private System.Windows.Forms.Button btnItem2;
        private System.Windows.Forms.Button btnItem3;
        private System.Windows.Forms.Button btnItem1;
        private System.Windows.Forms.Label lblArmourDefense;
        private System.Windows.Forms.Label lblArmourDefenseStat;
        private System.Windows.Forms.Label lblWeaponAttack;
        private System.Windows.Forms.Label lblWeaponAttackStat;
        private System.Windows.Forms.Label lblArmourType;
        private System.Windows.Forms.Label lblArmourTypeStat;
        private System.Windows.Forms.Label lblWeaponType;
        private System.Windows.Forms.Label lblWeaponTypeStat;
        private System.Windows.Forms.Label lblArmour;
        private System.Windows.Forms.Label lblWeapons;
        private System.Windows.Forms.Button btnBattle;
        private System.Windows.Forms.Panel pnlBattle;
        private System.Windows.Forms.PictureBox pbxHero;
        private System.Windows.Forms.PictureBox pbxEnemy;
        private System.Windows.Forms.Button btnStartBattle;
        private System.Windows.Forms.Label lblBattle;
        private System.Windows.Forms.ProgressBar pBarEnemyHealth;
        private System.Windows.Forms.ProgressBar pBarHeroHealth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEnemyAttack;
        private System.Windows.Forms.Label lblHeroAttack;
        private System.Windows.Forms.Label lblEnemyArmour;
        private System.Windows.Forms.Label lblHeroArmour;
        private System.Windows.Forms.Button btnAgain;
    }
}

