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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToys)).BeginInit();
            this.SuspendLayout();
            // 
            // labelData
            // 
            this.labelData.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(483, 181);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(201, 142);
            this.labelData.TabIndex = 24;
            this.labelData.Text = "Don\'t have or need a new toy";
            this.labelData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxToys
            // 
            this.pictureBoxToys.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxToys.Location = new System.Drawing.Point(268, 163);
            this.pictureBoxToys.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxToys.Name = "pictureBoxToys";
            this.pictureBoxToys.Size = new System.Drawing.Size(195, 176);
            this.pictureBoxToys.TabIndex = 25;
            this.pictureBoxToys.TabStop = false;
            // 
            // buttonL
            // 
            this.buttonL.Location = new System.Drawing.Point(329, 385);
            this.buttonL.Margin = new System.Windows.Forms.Padding(2);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(51, 27);
            this.buttonL.TabIndex = 26;
            this.buttonL.Text = "Kiri";
            this.buttonL.UseVisualStyleBackColor = true;
            this.buttonL.Click += new System.EventHandler(this.buttonL_Click);
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(554, 385);
            this.buttonR.Margin = new System.Windows.Forms.Padding(2);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(50, 27);
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
            this.buttonBuy.Location = new System.Drawing.Point(399, 378);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(138, 49);
            this.buttonBuy.TabIndex = 29;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.UseVisualStyleBackColor = false;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // FormShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1024, 621);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.buttonL);
            this.Controls.Add(this.pictureBoxToys);
            this.Controls.Add(this.labelData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormShop";
            this.Load += new System.EventHandler(this.FormShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToys)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label labelData;
        private System.Windows.Forms.PictureBox pictureBoxToys;
        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Button buttonBuy;
    }
}