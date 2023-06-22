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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelData = new System.Windows.Forms.Panel();
            this.labelPetData = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.labelPlayerData = new System.Windows.Forms.Label();
            this.panelActivity = new System.Windows.Forms.Panel();
            this.buttonClean = new System.Windows.Forms.Button();
            this.buttonVaccinate = new System.Windows.Forms.Button();
            this.buttonBath = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonFeed = new System.Windows.Forms.Button();
            this.pictureBoxPet = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelData.SuspendLayout();
            this.panelActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1248, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playGameToolStripMenuItem,
            this.resetGameToolStripMenuItem,
            this.changePetToolStripMenuItem});
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.playToolStripMenuItem.Text = "Game";
            // 
            // playGameToolStripMenuItem
            // 
            this.playGameToolStripMenuItem.Name = "playGameToolStripMenuItem";
            this.playGameToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.playGameToolStripMenuItem.Text = "Play Game";
            this.playGameToolStripMenuItem.Click += new System.EventHandler(this.playGameToolStripMenuItem_Click);
            // 
            // resetGameToolStripMenuItem
            // 
            this.resetGameToolStripMenuItem.Name = "resetGameToolStripMenuItem";
            this.resetGameToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.resetGameToolStripMenuItem.Text = "Reset Game";
            this.resetGameToolStripMenuItem.Click += new System.EventHandler(this.resetGameToolStripMenuItem_Click);
            // 
            // changePetToolStripMenuItem
            // 
            this.changePetToolStripMenuItem.Name = "changePetToolStripMenuItem";
            this.changePetToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.changePetToolStripMenuItem.Text = "Change Pet";
            this.changePetToolStripMenuItem.Click += new System.EventHandler(this.changePetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.Transparent;
            this.panelData.Controls.Add(this.labelPetData);
            this.panelData.Controls.Add(this.labelDateTime);
            this.panelData.Controls.Add(this.labelPlayerData);
            this.panelData.Location = new System.Drawing.Point(0, 34);
            this.panelData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(1248, 107);
            this.panelData.TabIndex = 1;
            // 
            // labelPetData
            // 
            this.labelPetData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelPetData.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPetData.ForeColor = System.Drawing.Color.Red;
            this.labelPetData.Location = new System.Drawing.Point(268, 0);
            this.labelPetData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPetData.Name = "labelPetData";
            this.labelPetData.Size = new System.Drawing.Size(732, 107);
            this.labelPetData.TabIndex = 2;
            this.labelPetData.Text = "labelPetData";
            this.labelPetData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDateTime
            // 
            this.labelDateTime.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateTime.Location = new System.Drawing.Point(1008, -6);
            this.labelDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(236, 113);
            this.labelDateTime.TabIndex = 1;
            this.labelDateTime.Text = "labelDateTime";
            this.labelDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPlayerData
            // 
            this.labelPlayerData.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerData.Location = new System.Drawing.Point(16, 0);
            this.labelPlayerData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlayerData.Name = "labelPlayerData";
            this.labelPlayerData.Size = new System.Drawing.Size(227, 107);
            this.labelPlayerData.TabIndex = 0;
            this.labelPlayerData.Text = "labelPlayerData";
            this.labelPlayerData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelActivity
            // 
            this.panelActivity.BackColor = System.Drawing.Color.Transparent;
            this.panelActivity.Controls.Add(this.buttonClean);
            this.panelActivity.Controls.Add(this.buttonVaccinate);
            this.panelActivity.Controls.Add(this.buttonBath);
            this.panelActivity.Controls.Add(this.buttonPlay);
            this.panelActivity.Controls.Add(this.buttonFeed);
            this.panelActivity.Location = new System.Drawing.Point(44, 519);
            this.panelActivity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelActivity.Name = "panelActivity";
            this.panelActivity.Size = new System.Drawing.Size(1180, 92);
            this.panelActivity.TabIndex = 2;
            // 
            // buttonClean
            // 
            this.buttonClean.BackColor = System.Drawing.Color.Green;
            this.buttonClean.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonClean.Location = new System.Drawing.Point(996, 10);
            this.buttonClean.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(164, 69);
            this.buttonClean.TabIndex = 4;
            this.buttonClean.Text = "Clean";
            this.buttonClean.UseVisualStyleBackColor = false;
            // 
            // buttonVaccinate
            // 
            this.buttonVaccinate.BackColor = System.Drawing.Color.Olive;
            this.buttonVaccinate.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVaccinate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonVaccinate.Location = new System.Drawing.Point(761, 10);
            this.buttonVaccinate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonVaccinate.Name = "buttonVaccinate";
            this.buttonVaccinate.Size = new System.Drawing.Size(164, 69);
            this.buttonVaccinate.TabIndex = 3;
            this.buttonVaccinate.Text = "Vaccinate";
            this.buttonVaccinate.UseVisualStyleBackColor = false;
            // 
            // buttonBath
            // 
            this.buttonBath.BackColor = System.Drawing.Color.Teal;
            this.buttonBath.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonBath.Location = new System.Drawing.Point(513, 10);
            this.buttonBath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBath.Name = "buttonBath";
            this.buttonBath.Size = new System.Drawing.Size(164, 69);
            this.buttonBath.TabIndex = 2;
            this.buttonBath.Text = "Bath";
            this.buttonBath.UseVisualStyleBackColor = false;
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonPlay.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonPlay.Location = new System.Drawing.Point(265, 10);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(164, 69);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = false;
            // 
            // buttonFeed
            // 
            this.buttonFeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonFeed.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonFeed.Location = new System.Drawing.Point(19, 10);
            this.buttonFeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFeed.Name = "buttonFeed";
            this.buttonFeed.Size = new System.Drawing.Size(164, 69);
            this.buttonFeed.TabIndex = 0;
            this.buttonFeed.Text = "Feed";
            this.buttonFeed.UseVisualStyleBackColor = false;
            // 
            // pictureBoxPet
            // 
            this.pictureBoxPet.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPet.Location = new System.Drawing.Point(502, 229);
            this.pictureBoxPet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxPet.Name = "pictureBoxPet";
            this.pictureBoxPet.Size = new System.Drawing.Size(258, 219);
            this.pictureBoxPet.TabIndex = 3;
            this.pictureBoxPet.TabStop = false;
            this.pictureBoxPet.Click += new System.EventHandler(this.pictureBoxPet_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Comic Sans MS", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(411, 450);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(454, 65);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "HAPPY PET GAME";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pet_game.Properties.Resources.Room;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1248, 642);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBoxPet);
            this.Controls.Add(this.panelActivity);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormGame";
            this.Text = "Happy Pet Game";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelData.ResumeLayout(false);
            this.panelActivity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Button buttonVaccinate;
        private System.Windows.Forms.Button buttonBath;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonFeed;
        public System.Windows.Forms.Label labelPetData;
        public System.Windows.Forms.Label labelDateTime;
        public System.Windows.Forms.Label labelPlayerData;
        public System.Windows.Forms.Panel panelData;
        public System.Windows.Forms.Panel panelActivity;
        private System.Windows.Forms.PictureBox pictureBoxPet;
        public System.Windows.Forms.Label labelTitle;
    }
}

