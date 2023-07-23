namespace pet_game
{
    partial class FormGame
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
            this.components = new System.ComponentModel.Container();
            this.panelData = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelHealth = new System.Windows.Forms.Label();
            this.labelVaccine = new System.Windows.Forms.Label();
            this.pictureBoxVac = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelPet = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.labelCoin = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.progressBarEnergy = new System.Windows.Forms.ProgressBar();
            this.progressBarHealth = new System.Windows.Forms.ProgressBar();
            this.progressBarHappy = new System.Windows.Forms.ProgressBar();
            this.panelActivity = new System.Windows.Forms.Panel();
            this.buttonSleep = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.buttonVaccinate = new System.Windows.Forms.Button();
            this.buttonBath = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonFeed = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.timerImage = new System.Windows.Forms.Timer(this.components);
            this.timerPetIdling = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxPet = new System.Windows.Forms.PictureBox();
            this.pictureBoxEat = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlay = new System.Windows.Forms.PictureBox();
            this.pictureBoxClean = new System.Windows.Forms.PictureBox();
            this.pictureBoxBath = new System.Windows.Forms.PictureBox();
            this.pictureBoxVaccine = new System.Windows.Forms.PictureBox();
            this.pictureBoxSleep = new System.Windows.Forms.PictureBox();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.panelActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVaccine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSleep)).BeginInit();
            this.SuspendLayout();
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.Transparent;
            this.panelData.Controls.Add(this.button1);
            this.panelData.Controls.Add(this.buttonExit);
            this.panelData.Controls.Add(this.labelHealth);
            this.panelData.Controls.Add(this.labelVaccine);
            this.panelData.Controls.Add(this.pictureBoxVac);
            this.panelData.Controls.Add(this.pictureBox5);
            this.panelData.Controls.Add(this.pictureBox4);
            this.panelData.Controls.Add(this.labelPet);
            this.panelData.Controls.Add(this.labelDateTime);
            this.panelData.Controls.Add(this.labelCoin);
            this.panelData.Controls.Add(this.pictureBox2);
            this.panelData.Controls.Add(this.pictureBox3);
            this.panelData.Controls.Add(this.pictureBox1);
            this.panelData.Controls.Add(this.pictureBoxIcon);
            this.panelData.Controls.Add(this.labelPlayer);
            this.panelData.Controls.Add(this.progressBarEnergy);
            this.panelData.Controls.Add(this.progressBarHealth);
            this.panelData.Controls.Add(this.progressBarHappy);
            this.panelData.Location = new System.Drawing.Point(0, 42);
            this.panelData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(1385, 265);
            this.panelData.TabIndex = 1;
            this.panelData.Paint += new System.Windows.Forms.PaintEventHandler(this.panelData_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(981, 168);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Eat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(890, 168);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(84, 29);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelHealth
            // 
            this.labelHealth.BackColor = System.Drawing.Color.Transparent;
            this.labelHealth.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHealth.Location = new System.Drawing.Point(604, 62);
            this.labelHealth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHealth.Name = "labelHealth";
            this.labelHealth.Size = new System.Drawing.Size(130, 42);
            this.labelHealth.TabIndex = 15;
            this.labelHealth.Text = "HAPPY PET GAME";
            this.labelHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVaccine
            // 
            this.labelVaccine.BackColor = System.Drawing.Color.Transparent;
            this.labelVaccine.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVaccine.Location = new System.Drawing.Point(287, 205);
            this.labelVaccine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVaccine.Name = "labelVaccine";
            this.labelVaccine.Size = new System.Drawing.Size(130, 42);
            this.labelVaccine.TabIndex = 14;
            this.labelVaccine.Text = "HAPPY PET GAME";
            this.labelVaccine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelVaccine.Visible = false;
            // 
            // pictureBoxVac
            // 
            this.pictureBoxVac.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxVac.BackgroundImage = global::pet_game.Properties.Resources.cat_vaccine;
            this.pictureBoxVac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxVac.Location = new System.Drawing.Point(225, 201);
            this.pictureBoxVac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxVac.Name = "pictureBoxVac";
            this.pictureBoxVac.Size = new System.Drawing.Size(55, 49);
            this.pictureBoxVac.TabIndex = 13;
            this.pictureBoxVac.TabStop = false;
            this.pictureBoxVac.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::pet_game.Properties.Resources.Avatar;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(91, 8);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(46, 45);
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::pet_game.Properties.Resources.Happy;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(334, 9);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(46, 45);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // labelPet
            // 
            this.labelPet.BackColor = System.Drawing.Color.Transparent;
            this.labelPet.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPet.Location = new System.Drawing.Point(387, 13);
            this.labelPet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPet.Name = "labelPet";
            this.labelPet.Size = new System.Drawing.Size(230, 42);
            this.labelPet.TabIndex = 10;
            this.labelPet.Text = "HAPPY PET GAME";
            this.labelPet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDateTime
            // 
            this.labelDateTime.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateTime.Location = new System.Drawing.Point(1065, 9);
            this.labelDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(266, 141);
            this.labelDateTime.TabIndex = 1;
            this.labelDateTime.Text = "labelDateTime";
            this.labelDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCoin
            // 
            this.labelCoin.BackColor = System.Drawing.Color.Transparent;
            this.labelCoin.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoin.Location = new System.Drawing.Point(87, 208);
            this.labelCoin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCoin.Name = "labelCoin";
            this.labelCoin.Size = new System.Drawing.Size(130, 42);
            this.labelCoin.TabIndex = 9;
            this.labelCoin.Text = "HAPPY PET GAME";
            this.labelCoin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::pet_game.Properties.Resources.health_icon;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(28, 55);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 45);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::pet_game.Properties.Resources.Coin;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(26, 201);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 49);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::pet_game.Properties.Resources.Energy;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(28, 101);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 45);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.BackgroundImage = global::pet_game.Properties.Resources.Happy;
            this.pictureBoxIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxIcon.Location = new System.Drawing.Point(28, 151);
            this.pictureBoxIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(46, 45);
            this.pictureBoxIcon.TabIndex = 4;
            this.pictureBoxIcon.TabStop = false;
            // 
            // labelPlayer
            // 
            this.labelPlayer.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer.Location = new System.Drawing.Point(130, 11);
            this.labelPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(182, 42);
            this.labelPlayer.TabIndex = 5;
            this.labelPlayer.Text = "HAPPY PET GAME";
            this.labelPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBarEnergy
            // 
            this.progressBarEnergy.Location = new System.Drawing.Point(80, 108);
            this.progressBarEnergy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarEnergy.Name = "progressBarEnergy";
            this.progressBarEnergy.Size = new System.Drawing.Size(519, 31);
            this.progressBarEnergy.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarEnergy.TabIndex = 5;
            // 
            // progressBarHealth
            // 
            this.progressBarHealth.Location = new System.Drawing.Point(80, 62);
            this.progressBarHealth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarHealth.Name = "progressBarHealth";
            this.progressBarHealth.Size = new System.Drawing.Size(519, 31);
            this.progressBarHealth.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarHealth.TabIndex = 4;
            // 
            // progressBarHappy
            // 
            this.progressBarHappy.Location = new System.Drawing.Point(80, 155);
            this.progressBarHappy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarHappy.Name = "progressBarHappy";
            this.progressBarHappy.Size = new System.Drawing.Size(519, 31);
            this.progressBarHappy.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarHappy.TabIndex = 6;
            // 
            // panelActivity
            // 
            this.panelActivity.BackColor = System.Drawing.Color.Transparent;
            this.panelActivity.Controls.Add(this.buttonSleep);
            this.panelActivity.Controls.Add(this.buttonClean);
            this.panelActivity.Controls.Add(this.buttonVaccinate);
            this.panelActivity.Controls.Add(this.buttonBath);
            this.panelActivity.Controls.Add(this.buttonPlay);
            this.panelActivity.Controls.Add(this.buttonFeed);
            this.panelActivity.Location = new System.Drawing.Point(49, 367);
            this.panelActivity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelActivity.Name = "panelActivity";
            this.panelActivity.Size = new System.Drawing.Size(1328, 115);
            this.panelActivity.TabIndex = 2;
            // 
            // buttonSleep
            // 
            this.buttonSleep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonSleep.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSleep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSleep.Location = new System.Drawing.Point(242, 12);
            this.buttonSleep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSleep.Name = "buttonSleep";
            this.buttonSleep.Size = new System.Drawing.Size(184, 86);
            this.buttonSleep.TabIndex = 5;
            this.buttonSleep.Text = "Sleep";
            this.buttonSleep.UseVisualStyleBackColor = false;
            this.buttonSleep.Click += new System.EventHandler(this.buttonSleep_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.BackColor = System.Drawing.Color.Green;
            this.buttonClean.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonClean.Location = new System.Drawing.Point(1120, 12);
            this.buttonClean.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(184, 86);
            this.buttonClean.TabIndex = 4;
            this.buttonClean.Text = "Clean";
            this.buttonClean.UseVisualStyleBackColor = false;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // buttonVaccinate
            // 
            this.buttonVaccinate.BackColor = System.Drawing.Color.Olive;
            this.buttonVaccinate.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVaccinate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonVaccinate.Location = new System.Drawing.Point(908, 12);
            this.buttonVaccinate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonVaccinate.Name = "buttonVaccinate";
            this.buttonVaccinate.Size = new System.Drawing.Size(184, 86);
            this.buttonVaccinate.TabIndex = 3;
            this.buttonVaccinate.Text = "Vaccinate";
            this.buttonVaccinate.UseVisualStyleBackColor = false;
            this.buttonVaccinate.Click += new System.EventHandler(this.buttonVaccinate_Click);
            // 
            // buttonBath
            // 
            this.buttonBath.BackColor = System.Drawing.Color.Teal;
            this.buttonBath.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonBath.Location = new System.Drawing.Point(687, 12);
            this.buttonBath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBath.Name = "buttonBath";
            this.buttonBath.Size = new System.Drawing.Size(184, 86);
            this.buttonBath.TabIndex = 2;
            this.buttonBath.Text = "Bath";
            this.buttonBath.UseVisualStyleBackColor = false;
            this.buttonBath.Click += new System.EventHandler(this.buttonBath_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonPlay.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonPlay.Location = new System.Drawing.Point(462, 12);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(184, 86);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonFeed
            // 
            this.buttonFeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonFeed.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonFeed.Location = new System.Drawing.Point(21, 12);
            this.buttonFeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFeed.Name = "buttonFeed";
            this.buttonFeed.Size = new System.Drawing.Size(184, 86);
            this.buttonFeed.TabIndex = 0;
            this.buttonFeed.Text = "Feed";
            this.buttonFeed.UseVisualStyleBackColor = false;
            this.buttonFeed.Click += new System.EventHandler(this.buttonFeed_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Comic Sans MS", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(1007, 546);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(494, 66);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "HAPPY PET GAME";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerGame
            // 
            this.timerGame.Interval = 1000;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // timerImage
            // 
            this.timerImage.Interval = 1000;
            this.timerImage.Tick += new System.EventHandler(this.timerImage_Tick);
            // 
            // timerPetIdling
            // 
            this.timerPetIdling.Enabled = true;
            this.timerPetIdling.Tick += new System.EventHandler(this.timerPet_Tick);
            // 
            // pictureBoxPet
            // 
            this.pictureBoxPet.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPet.Location = new System.Drawing.Point(658, 668);
            this.pictureBoxPet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxPet.Name = "pictureBoxPet";
            this.pictureBoxPet.Size = new System.Drawing.Size(216, 219);
            this.pictureBoxPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPet.TabIndex = 5;
            this.pictureBoxPet.TabStop = false;
            // 
            // pictureBoxEat
            // 
            this.pictureBoxEat.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEat.BackgroundImage = global::pet_game.Properties.Resources.Icon_Feed;
            this.pictureBoxEat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxEat.Location = new System.Drawing.Point(1416, 28);
            this.pictureBoxEat.Name = "pictureBoxEat";
            this.pictureBoxEat.Size = new System.Drawing.Size(84, 83);
            this.pictureBoxEat.TabIndex = 6;
            this.pictureBoxEat.TabStop = false;
            // 
            // pictureBoxPlay
            // 
            this.pictureBoxPlay.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlay.BackgroundImage = global::pet_game.Properties.Resources.Icon_Play;
            this.pictureBoxPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPlay.Location = new System.Drawing.Point(1417, 106);
            this.pictureBoxPlay.Name = "pictureBoxPlay";
            this.pictureBoxPlay.Size = new System.Drawing.Size(84, 83);
            this.pictureBoxPlay.TabIndex = 7;
            this.pictureBoxPlay.TabStop = false;
            // 
            // pictureBoxClean
            // 
            this.pictureBoxClean.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxClean.BackgroundImage = global::pet_game.Properties.Resources.Icon_Clean;
            this.pictureBoxClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxClean.Location = new System.Drawing.Point(1416, 434);
            this.pictureBoxClean.Name = "pictureBoxClean";
            this.pictureBoxClean.Size = new System.Drawing.Size(84, 83);
            this.pictureBoxClean.TabIndex = 8;
            this.pictureBoxClean.TabStop = false;
            // 
            // pictureBoxBath
            // 
            this.pictureBoxBath.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBath.BackgroundImage = global::pet_game.Properties.Resources.Icon_Bath;
            this.pictureBoxBath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBath.Location = new System.Drawing.Point(1416, 274);
            this.pictureBoxBath.Name = "pictureBoxBath";
            this.pictureBoxBath.Size = new System.Drawing.Size(84, 83);
            this.pictureBoxBath.TabIndex = 9;
            this.pictureBoxBath.TabStop = false;
            // 
            // pictureBoxVaccine
            // 
            this.pictureBoxVaccine.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxVaccine.BackgroundImage = global::pet_game.Properties.Resources.Icon_Vaccine;
            this.pictureBoxVaccine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxVaccine.Location = new System.Drawing.Point(1416, 353);
            this.pictureBoxVaccine.Name = "pictureBoxVaccine";
            this.pictureBoxVaccine.Size = new System.Drawing.Size(84, 83);
            this.pictureBoxVaccine.TabIndex = 10;
            this.pictureBoxVaccine.TabStop = false;
            // 
            // pictureBoxSleep
            // 
            this.pictureBoxSleep.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSleep.BackgroundImage = global::pet_game.Properties.Resources.Icon_Sleep;
            this.pictureBoxSleep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSleep.Location = new System.Drawing.Point(1416, 195);
            this.pictureBoxSleep.Name = "pictureBoxSleep";
            this.pictureBoxSleep.Size = new System.Drawing.Size(84, 83);
            this.pictureBoxSleep.TabIndex = 11;
            this.pictureBoxSleep.TabStop = false;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pet_game.Properties.Resources.Room;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1512, 895);
            this.Controls.Add(this.pictureBoxSleep);
            this.Controls.Add(this.pictureBoxVaccine);
            this.Controls.Add(this.pictureBoxBath);
            this.Controls.Add(this.pictureBoxClean);
            this.Controls.Add(this.pictureBoxPlay);
            this.Controls.Add(this.pictureBoxEat);
            this.Controls.Add(this.pictureBoxPet);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelActivity);
            this.Controls.Add(this.panelData);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Happy Pet Game";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.panelActivity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVaccine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSleep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Button buttonVaccinate;
        private System.Windows.Forms.Button buttonBath;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonFeed;
        public System.Windows.Forms.Label labelDateTime;
        public System.Windows.Forms.Panel panelData;
        public System.Windows.Forms.Panel panelActivity;
        public System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonSleep;
        private System.Windows.Forms.Timer timerImage;
        private System.Windows.Forms.ProgressBar progressBarHealth;
        private System.Windows.Forms.ProgressBar progressBarEnergy;
        private System.Windows.Forms.ProgressBar progressBarHappy;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        public System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Label labelCoin;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.Label labelPet;
        private System.Windows.Forms.PictureBox pictureBoxVac;
        public System.Windows.Forms.Label labelVaccine;
        public System.Windows.Forms.Timer timerGame;
        public System.Windows.Forms.Label labelHealth;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timerPetIdling;
        private System.Windows.Forms.PictureBox pictureBoxPet;
        private System.Windows.Forms.PictureBox pictureBoxEat;
        private System.Windows.Forms.PictureBox pictureBoxPlay;
        private System.Windows.Forms.PictureBox pictureBoxClean;
        private System.Windows.Forms.PictureBox pictureBoxBath;
        private System.Windows.Forms.PictureBox pictureBoxVaccine;
        private System.Windows.Forms.PictureBox pictureBoxSleep;
    }
}

