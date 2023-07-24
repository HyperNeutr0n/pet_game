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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelMain = new System.Windows.Forms.Panel();
            this.mxp = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.pictureBoxReset = new System.Windows.Forms.PictureBox();
            this.pictureBoxLoad = new System.Windows.Forms.PictureBox();
            this.pictureBoxNew = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mxp)).BeginInit();
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
            this.panelMain.Controls.Add(this.textBox1);
            this.panelMain.Controls.Add(this.mxp);
            this.panelMain.Controls.Add(this.pictureBoxExit);
            this.panelMain.Controls.Add(this.pictureBoxReset);
            this.panelMain.Controls.Add(this.pictureBoxLoad);
            this.panelMain.Controls.Add(this.pictureBoxNew);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1008, 580);
            this.panelMain.TabIndex = 0;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // mxp
            // 
            this.mxp.Enabled = true;
            this.mxp.Location = new System.Drawing.Point(142, 349);
            this.mxp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mxp.Name = "mxp";
            this.mxp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mxp.OcxState")));
            this.mxp.Size = new System.Drawing.Size(273, 110);
            this.mxp.TabIndex = 12;
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxExit.BackgroundImage = global::pet_game.Properties.Resources.Button_Exits;
            this.pictureBoxExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxExit.Location = new System.Drawing.Point(416, 462);
            this.pictureBoxExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(188, 111);
            this.pictureBoxExit.TabIndex = 11;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            this.pictureBoxExit.MouseLeave += new System.EventHandler(this.pictureBoxExit_MouseLeave);
            this.pictureBoxExit.MouseHover += new System.EventHandler(this.pictureBoxExit_MouseHover);
            // 
            // pictureBoxReset
            // 
            this.pictureBoxReset.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxReset.BackgroundImage = global::pet_game.Properties.Resources.Button_Reset;
            this.pictureBoxReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxReset.Location = new System.Drawing.Point(416, 347);
            this.pictureBoxReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxReset.Name = "pictureBoxReset";
            this.pictureBoxReset.Size = new System.Drawing.Size(188, 111);
            this.pictureBoxReset.TabIndex = 10;
            this.pictureBoxReset.TabStop = false;
            this.pictureBoxReset.Click += new System.EventHandler(this.pictureBoxReset_Click);
            this.pictureBoxReset.MouseLeave += new System.EventHandler(this.pictureBoxReset_MouseLeave);
            this.pictureBoxReset.MouseHover += new System.EventHandler(this.pictureBoxReset_MouseHover);
            // 
            // pictureBoxLoad
            // 
            this.pictureBoxLoad.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLoad.BackgroundImage = global::pet_game.Properties.Resources.Button_Load;
            this.pictureBoxLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLoad.Location = new System.Drawing.Point(416, 232);
            this.pictureBoxLoad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxLoad.Name = "pictureBoxLoad";
            this.pictureBoxLoad.Size = new System.Drawing.Size(188, 111);
            this.pictureBoxLoad.TabIndex = 9;
            this.pictureBoxLoad.TabStop = false;
            this.pictureBoxLoad.Click += new System.EventHandler(this.pictureBoxLoad_Click);
            this.pictureBoxLoad.MouseLeave += new System.EventHandler(this.pictureBoxLoad_MouseLeave);
            this.pictureBoxLoad.MouseHover += new System.EventHandler(this.pictureBoxLoad_MouseHover);
            // 
            // pictureBoxNew
            // 
            this.pictureBoxNew.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNew.BackgroundImage = global::pet_game.Properties.Resources.Button_NewGame;
            this.pictureBoxNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxNew.Location = new System.Drawing.Point(416, 119);
            this.pictureBoxNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxNew.Name = "pictureBoxNew";
            this.pictureBoxNew.Size = new System.Drawing.Size(188, 111);
            this.pictureBoxNew.TabIndex = 8;
            this.pictureBoxNew.TabStop = false;
            this.pictureBoxNew.Click += new System.EventHandler(this.pictureBoxNew_Click);
            this.pictureBoxNew.MouseLeave += new System.EventHandler(this.pictureBoxNew_MouseLeave);
            this.pictureBoxNew.MouseHover += new System.EventHandler(this.pictureBoxNew_MouseHover);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(800, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
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
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mxp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureBoxNew;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.PictureBox pictureBoxReset;
        private System.Windows.Forms.PictureBox pictureBoxLoad;
        private AxWMPLib.AxWindowsMediaPlayer mxp;
        private System.Windows.Forms.TextBox textBox1;
    }
}