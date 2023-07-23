namespace pet_game
{
    partial class FormShop
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
            this.labelData = new System.Windows.Forms.Label();
            this.pictureBoxToys = new System.Windows.Forms.PictureBox();
            this.buttonL = new System.Windows.Forms.Button();
            this.buttonR = new System.Windows.Forms.Button();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.pictureBoxBuy = new System.Windows.Forms.PictureBox();
            this.pictureBoxRight = new System.Windows.Forms.PictureBox();
            this.pictureBoxLeft = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // labelData
            // 
            this.labelData.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(754, 203);
            this.labelData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(302, 218);
            this.labelData.TabIndex = 24;
            this.labelData.Text = "Don\'t have or need a new toy";
            this.labelData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxToys
            // 
            this.pictureBoxToys.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxToys.Location = new System.Drawing.Point(432, 176);
            this.pictureBoxToys.Name = "pictureBoxToys";
            this.pictureBoxToys.Size = new System.Drawing.Size(292, 271);
            this.pictureBoxToys.TabIndex = 25;
            this.pictureBoxToys.TabStop = false;
            // 
            // buttonL
            // 
            this.buttonL.Location = new System.Drawing.Point(194, 656);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(76, 42);
            this.buttonL.TabIndex = 26;
            this.buttonL.Text = "Kiri";
            this.buttonL.UseVisualStyleBackColor = true;
            this.buttonL.Click += new System.EventHandler(this.buttonL_Click);
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(1119, 690);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(75, 42);
            this.buttonR.TabIndex = 27;
            this.buttonR.Text = "Kanan";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // buttonBuy
            // 
            this.buttonBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonBuy.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuy.ForeColor = System.Drawing.Color.Black;
            this.buttonBuy.Location = new System.Drawing.Point(622, 866);
            this.buttonBuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(207, 75);
            this.buttonBuy.TabIndex = 29;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.UseVisualStyleBackColor = false;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // pictureBoxBuy
            // 
            this.pictureBoxBuy.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBuy.BackgroundImage = global::pet_game.Properties.Resources.Button_Buy;
            this.pictureBoxBuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBuy.Location = new System.Drawing.Point(598, 486);
            this.pictureBoxBuy.Name = "pictureBoxBuy";
            this.pictureBoxBuy.Size = new System.Drawing.Size(281, 171);
            this.pictureBoxBuy.TabIndex = 30;
            this.pictureBoxBuy.TabStop = false;
            this.pictureBoxBuy.MouseLeave += new System.EventHandler(this.pictureBoxBuy_MouseLeave);
            this.pictureBoxBuy.MouseHover += new System.EventHandler(this.pictureBoxBuy_MouseHover);
            // 
            // pictureBoxRight
            // 
            this.pictureBoxRight.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRight.BackgroundImage = global::pet_game.Properties.Resources.Button_Right;
            this.pictureBoxRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxRight.Location = new System.Drawing.Point(939, 486);
            this.pictureBoxRight.Name = "pictureBoxRight";
            this.pictureBoxRight.Size = new System.Drawing.Size(176, 178);
            this.pictureBoxRight.TabIndex = 31;
            this.pictureBoxRight.TabStop = false;
            this.pictureBoxRight.MouseLeave += new System.EventHandler(this.pictureBoxRight_MouseLeave);
            this.pictureBoxRight.MouseHover += new System.EventHandler(this.pictureBoxRight_MouseHover);
            // 
            // pictureBoxLeft
            // 
            this.pictureBoxLeft.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLeft.BackgroundImage = global::pet_game.Properties.Resources.Button_Left;
            this.pictureBoxLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLeft.Location = new System.Drawing.Point(364, 486);
            this.pictureBoxLeft.Name = "pictureBoxLeft";
            this.pictureBoxLeft.Size = new System.Drawing.Size(176, 178);
            this.pictureBoxLeft.TabIndex = 32;
            this.pictureBoxLeft.TabStop = false;
            this.pictureBoxLeft.MouseLeave += new System.EventHandler(this.pictureBoxLeft_MouseLeave);
            this.pictureBoxLeft.MouseHover += new System.EventHandler(this.pictureBoxLeft_MouseHover);
            // 
            // FormShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::pet_game.Properties.Resources.noonbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1536, 955);
            this.Controls.Add(this.pictureBoxLeft);
            this.Controls.Add(this.pictureBoxRight);
            this.Controls.Add(this.pictureBoxBuy);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.buttonL);
            this.Controls.Add(this.pictureBoxToys);
            this.Controls.Add(this.labelData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormShop";
            this.Load += new System.EventHandler(this.FormShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label labelData;
        private System.Windows.Forms.PictureBox pictureBoxToys;
        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.PictureBox pictureBoxBuy;
        private System.Windows.Forms.PictureBox pictureBoxRight;
        private System.Windows.Forms.PictureBox pictureBoxLeft;
    }
}