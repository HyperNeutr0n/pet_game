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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.buttonContinueGame = new System.Windows.Forms.Button();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.buttonExit);
            this.panelMain.Controls.Add(this.buttonSetting);
            this.panelMain.Controls.Add(this.buttonContinueGame);
            this.panelMain.Controls.Add(this.buttonNewGame);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1008, 580);
            this.panelMain.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(397, 349);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSetting
            // 
            this.buttonSetting.Location = new System.Drawing.Point(397, 277);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(75, 23);
            this.buttonSetting.TabIndex = 6;
            this.buttonSetting.Text = "Settings";
            this.buttonSetting.UseVisualStyleBackColor = true;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // buttonContinueGame
            // 
            this.buttonContinueGame.Location = new System.Drawing.Point(397, 213);
            this.buttonContinueGame.Name = "buttonContinueGame";
            this.buttonContinueGame.Size = new System.Drawing.Size(75, 23);
            this.buttonContinueGame.TabIndex = 5;
            this.buttonContinueGame.Text = "Continue Game";
            this.buttonContinueGame.UseVisualStyleBackColor = true;
            this.buttonContinueGame.Click += new System.EventHandler(this.buttonContinueGame_Click);
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(397, 154);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(75, 23);
            this.buttonNewGame.TabIndex = 4;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 582);
            this.Controls.Add(this.panelMain);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSetting;
        private System.Windows.Forms.Button buttonContinueGame;
        private System.Windows.Forms.Button buttonNewGame;
        public System.Windows.Forms.Panel panelMain;
    }
}