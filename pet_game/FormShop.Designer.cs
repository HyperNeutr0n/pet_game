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
            this.labelData.BackColor = System.Drawing.Color.Transparent;
            this.labelData.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(503, 132);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(201, 142);
            this.labelData.TabIndex = 24;
            this.labelData.Text = "Don\'t have or need a new toy";
            this.labelData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxToys
            // 
            this.pictureBoxToys.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxToys.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxToys.Location = new System.Drawing.Point(288, 114);
            this.pictureBoxToys.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxToys.Name = "pictureBoxToys";
            this.pictureBoxToys.Size = new System.Drawing.Size(195, 176);
            this.pictureBoxToys.TabIndex = 25;
            this.pictureBoxToys.TabStop = false;
            // 
            // pictureBoxBuy
            // 
            this.pictureBoxBuy.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBuy.BackgroundImage = global::pet_game.Properties.Resources.Button_Buy;
            this.pictureBoxBuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBuy.Location = new System.Drawing.Point(399, 316);
            this.pictureBoxBuy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxBuy.Name = "pictureBoxBuy";
            this.pictureBoxBuy.Size = new System.Drawing.Size(187, 111);
            this.pictureBoxBuy.TabIndex = 30;
            this.pictureBoxBuy.TabStop = false;
            this.pictureBoxBuy.Click += new System.EventHandler(this.pictureBoxBuy_Click);
            this.pictureBoxBuy.MouseLeave += new System.EventHandler(this.pictureBoxBuy_MouseLeave);
            this.pictureBoxBuy.MouseHover += new System.EventHandler(this.pictureBoxBuy_MouseHover);
            // 
            // pictureBoxRight
            // 
            this.pictureBoxRight.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRight.BackgroundImage = global::pet_game.Properties.Resources.Button_Right;
            this.pictureBoxRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxRight.Location = new System.Drawing.Point(626, 316);
            this.pictureBoxRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxRight.Name = "pictureBoxRight";
            this.pictureBoxRight.Size = new System.Drawing.Size(117, 116);
            this.pictureBoxRight.TabIndex = 31;
            this.pictureBoxRight.TabStop = false;
            this.pictureBoxRight.Click += new System.EventHandler(this.pictureBoxRight_Click);
            this.pictureBoxRight.MouseLeave += new System.EventHandler(this.pictureBoxRight_MouseLeave);
            this.pictureBoxRight.MouseHover += new System.EventHandler(this.pictureBoxRight_MouseHover);
            // 
            // pictureBoxLeft
            // 
            this.pictureBoxLeft.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLeft.BackgroundImage = global::pet_game.Properties.Resources.Button_Left;
            this.pictureBoxLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLeft.Location = new System.Drawing.Point(243, 316);
            this.pictureBoxLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxLeft.Name = "pictureBoxLeft";
            this.pictureBoxLeft.Size = new System.Drawing.Size(117, 116);
            this.pictureBoxLeft.TabIndex = 32;
            this.pictureBoxLeft.TabStop = false;
            this.pictureBoxLeft.Click += new System.EventHandler(this.pictureBoxLeft_Click);
            this.pictureBoxLeft.MouseLeave += new System.EventHandler(this.pictureBoxLeft_MouseLeave);
            this.pictureBoxLeft.MouseHover += new System.EventHandler(this.pictureBoxLeft_MouseHover);
            // 
            // FormShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::pet_game.Properties.Resources.noonbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 580);
            this.Controls.Add(this.pictureBoxLeft);
            this.Controls.Add(this.pictureBoxRight);
            this.Controls.Add(this.pictureBoxBuy);
            this.Controls.Add(this.pictureBoxToys);
            this.Controls.Add(this.labelData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.PictureBox pictureBoxBuy;
        private System.Windows.Forms.PictureBox pictureBoxRight;
        private System.Windows.Forms.PictureBox pictureBoxLeft;
    }
}