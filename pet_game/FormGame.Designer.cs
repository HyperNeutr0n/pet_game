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
            this.menuStrip1.SuspendLayout();
            this.panelData.SuspendLayout();
            this.panelActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(818, 24);
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
            this.playToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.playToolStripMenuItem.Text = "Game";
            // 
            // playGameToolStripMenuItem
            // 
            this.playGameToolStripMenuItem.Name = "playGameToolStripMenuItem";
            this.playGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.playGameToolStripMenuItem.Text = "Play Game";
            this.playGameToolStripMenuItem.Click += new System.EventHandler(this.playGameToolStripMenuItem_Click);
            // 
            // resetGameToolStripMenuItem
            // 
            this.resetGameToolStripMenuItem.Name = "resetGameToolStripMenuItem";
            this.resetGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetGameToolStripMenuItem.Text = "Reset Game";
            this.resetGameToolStripMenuItem.Click += new System.EventHandler(this.resetGameToolStripMenuItem_Click);
            // 
            // changePetToolStripMenuItem
            // 
            this.changePetToolStripMenuItem.Name = "changePetToolStripMenuItem";
            this.changePetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changePetToolStripMenuItem.Text = "Change Pet";
            this.changePetToolStripMenuItem.Click += new System.EventHandler(this.changePetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.Transparent;
            this.panelData.Controls.Add(this.labelPetData);
            this.panelData.Controls.Add(this.labelDateTime);
            this.panelData.Controls.Add(this.labelPlayerData);
            this.panelData.Location = new System.Drawing.Point(0, 27);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(818, 87);
            this.panelData.TabIndex = 1;
            // 
            // labelPetData
            // 
            this.labelPetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPetData.Location = new System.Drawing.Point(321, 11);
            this.labelPetData.Name = "labelPetData";
            this.labelPetData.Size = new System.Drawing.Size(170, 34);
            this.labelPetData.TabIndex = 2;
            this.labelPetData.Text = "labelPetData";
            this.labelPetData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDateTime
            // 
            this.labelDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateTime.Location = new System.Drawing.Point(636, 11);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(170, 34);
            this.labelDateTime.TabIndex = 1;
            this.labelDateTime.Text = "labelDateTime";
            this.labelDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPlayerData
            // 
            this.labelPlayerData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerData.Location = new System.Drawing.Point(12, 11);
            this.labelPlayerData.Name = "labelPlayerData";
            this.labelPlayerData.Size = new System.Drawing.Size(170, 34);
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
            this.panelActivity.Location = new System.Drawing.Point(33, 422);
            this.panelActivity.Name = "panelActivity";
            this.panelActivity.Size = new System.Drawing.Size(744, 75);
            this.panelActivity.TabIndex = 2;
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(646, 25);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(75, 23);
            this.buttonClean.TabIndex = 4;
            this.buttonClean.Text = "Clean";
            this.buttonClean.UseVisualStyleBackColor = true;
            // 
            // buttonVaccinate
            // 
            this.buttonVaccinate.Location = new System.Drawing.Point(503, 25);
            this.buttonVaccinate.Name = "buttonVaccinate";
            this.buttonVaccinate.Size = new System.Drawing.Size(75, 23);
            this.buttonVaccinate.TabIndex = 3;
            this.buttonVaccinate.Text = "Vaccinate";
            this.buttonVaccinate.UseVisualStyleBackColor = true;
            // 
            // buttonBath
            // 
            this.buttonBath.Location = new System.Drawing.Point(344, 25);
            this.buttonBath.Name = "buttonBath";
            this.buttonBath.Size = new System.Drawing.Size(75, 23);
            this.buttonBath.TabIndex = 2;
            this.buttonBath.Text = "Bath";
            this.buttonBath.UseVisualStyleBackColor = true;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(183, 25);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            // 
            // buttonFeed
            // 
            this.buttonFeed.Location = new System.Drawing.Point(23, 25);
            this.buttonFeed.Name = "buttonFeed";
            this.buttonFeed.Size = new System.Drawing.Size(75, 23);
            this.buttonFeed.TabIndex = 0;
            this.buttonFeed.Text = "Feed";
            this.buttonFeed.UseVisualStyleBackColor = true;
            // 
            // pictureBoxPet
            // 
            this.pictureBoxPet.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPet.Location = new System.Drawing.Point(326, 203);
            this.pictureBoxPet.Name = "pictureBoxPet";
            this.pictureBoxPet.Size = new System.Drawing.Size(193, 178);
            this.pictureBoxPet.TabIndex = 3;
            this.pictureBoxPet.TabStop = false;
            this.pictureBoxPet.Click += new System.EventHandler(this.pictureBoxPet_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pet_game.Properties.Resources.Room;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(818, 522);
            this.Controls.Add(this.pictureBoxPet);
            this.Controls.Add(this.panelActivity);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
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
    }
}

