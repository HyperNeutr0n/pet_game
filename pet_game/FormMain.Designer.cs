namespace pet_game
{
    partial class FormMain
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.pictureBoxReset = new System.Windows.Forms.PictureBox();
            this.pictureBoxLoad = new System.Windows.Forms.PictureBox();
            this.pictureBoxNew = new System.Windows.Forms.PictureBox();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.buttonContinueGame = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNew)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackgroundImage = global::pet_game.Properties.Resources.Menu_BG;
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMain.Controls.Add(this.pictureBoxExit);
            this.panelMain.Controls.Add(this.pictureBoxReset);
            this.panelMain.Controls.Add(this.pictureBoxLoad);
            this.panelMain.Controls.Add(this.pictureBoxNew);
            this.panelMain.Controls.Add(this.buttonNewGame);
            this.panelMain.Controls.Add(this.buttonExit);
            this.panelMain.Controls.Add(this.buttonSetting);
            this.panelMain.Controls.Add(this.buttonContinueGame);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1512, 892);
            this.panelMain.TabIndex = 0;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxExit.BackgroundImage = global::pet_game.Properties.Resources.Button_Exits;
            this.pictureBoxExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxExit.Location = new System.Drawing.Point(624, 711);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(281, 171);
            this.pictureBoxExit.TabIndex = 11;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.MouseLeave += new System.EventHandler(this.pictureBoxExit_MouseLeave);
            this.pictureBoxExit.MouseHover += new System.EventHandler(this.pictureBoxExit_MouseHover);
            // 
            // pictureBoxReset
            // 
            this.pictureBoxReset.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxReset.BackgroundImage = global::pet_game.Properties.Resources.Button_Reset;
            this.pictureBoxReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxReset.Location = new System.Drawing.Point(624, 534);
            this.pictureBoxReset.Name = "pictureBoxReset";
            this.pictureBoxReset.Size = new System.Drawing.Size(281, 171);
            this.pictureBoxReset.TabIndex = 10;
            this.pictureBoxReset.TabStop = false;
            this.pictureBoxReset.MouseLeave += new System.EventHandler(this.pictureBoxReset_MouseLeave);
            this.pictureBoxReset.MouseHover += new System.EventHandler(this.pictureBoxReset_MouseHover);
            // 
            // pictureBoxLoad
            // 
            this.pictureBoxLoad.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLoad.BackgroundImage = global::pet_game.Properties.Resources.Button_Load;
            this.pictureBoxLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLoad.Location = new System.Drawing.Point(624, 357);
            this.pictureBoxLoad.Name = "pictureBoxLoad";
            this.pictureBoxLoad.Size = new System.Drawing.Size(281, 171);
            this.pictureBoxLoad.TabIndex = 9;
            this.pictureBoxLoad.TabStop = false;
            this.pictureBoxLoad.MouseLeave += new System.EventHandler(this.pictureBoxLoad_MouseLeave);
            this.pictureBoxLoad.MouseHover += new System.EventHandler(this.pictureBoxLoad_MouseHover);
            // 
            // pictureBoxNew
            // 
            this.pictureBoxNew.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNew.BackgroundImage = global::pet_game.Properties.Resources.Button_NewGame;
            this.pictureBoxNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxNew.Location = new System.Drawing.Point(624, 182);
            this.pictureBoxNew.Name = "pictureBoxNew";
            this.pictureBoxNew.Size = new System.Drawing.Size(281, 171);
            this.pictureBoxNew.TabIndex = 8;
            this.pictureBoxNew.TabStop = false;
            this.pictureBoxNew.MouseLeave += new System.EventHandler(this.pictureBoxNew_MouseLeave);
            this.pictureBoxNew.MouseHover += new System.EventHandler(this.pictureBoxNew_MouseHover);
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.BackColor = System.Drawing.Color.Transparent;
            this.buttonNewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNewGame.Location = new System.Drawing.Point(967, 243);
            this.buttonNewGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(190, 110);
            this.buttonNewGame.TabIndex = 4;
            this.buttonNewGame.Text = "NEw Game";
            this.buttonNewGame.UseVisualStyleBackColor = false;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(996, 817);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(173, 64);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSetting
            // 
            this.buttonSetting.Location = new System.Drawing.Point(1009, 508);
            this.buttonSetting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(169, 95);
            this.buttonSetting.TabIndex = 6;
            this.buttonSetting.Text = "Settings";
            this.buttonSetting.UseVisualStyleBackColor = true;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // buttonContinueGame
            // 
            this.buttonContinueGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonContinueGame.Location = new System.Drawing.Point(1009, 357);
            this.buttonContinueGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonContinueGame.Name = "buttonContinueGame";
            this.buttonContinueGame.Size = new System.Drawing.Size(134, 78);
            this.buttonContinueGame.TabIndex = 5;
            this.buttonContinueGame.Text = "Continue Game";
            this.buttonContinueGame.UseVisualStyleBackColor = true;
            this.buttonContinueGame.Click += new System.EventHandler(this.buttonContinueGame_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 895);
            this.Controls.Add(this.panelMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSetting;
        private System.Windows.Forms.Button buttonContinueGame;
        private System.Windows.Forms.Button buttonNewGame;
        public System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureBoxNew;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.PictureBox pictureBoxReset;
        private System.Windows.Forms.PictureBox pictureBoxLoad;
    }
}