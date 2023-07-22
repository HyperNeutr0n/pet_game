namespace pet_game
{
    partial class FormSelectToys
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
            this.linkLabelBuy = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxToys = new System.Windows.Forms.ComboBox();
            this.labelToys = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelData = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelBuy
            // 
            this.linkLabelBuy.AutoSize = true;
            this.linkLabelBuy.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelBuy.Location = new System.Drawing.Point(418, 484);
            this.linkLabelBuy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelBuy.Name = "linkLabelBuy";
            this.linkLabelBuy.Size = new System.Drawing.Size(113, 31);
            this.linkLabelBuy.TabIndex = 24;
            this.linkLabelBuy.TabStop = true;
            this.linkLabelBuy.Text = "Buy Here";
            this.linkLabelBuy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBuy_LinkClicked);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 68);
            this.label1.TabIndex = 23;
            this.label1.Text = "Don\'t have or need a new toy";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxToys
            // 
            this.comboBoxToys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxToys.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxToys.FormattingEnabled = true;
            this.comboBoxToys.Location = new System.Drawing.Point(336, 85);
            this.comboBoxToys.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxToys.Name = "comboBoxToys";
            this.comboBoxToys.Size = new System.Drawing.Size(261, 38);
            this.comboBoxToys.TabIndex = 22;
            this.comboBoxToys.SelectedIndexChanged += new System.EventHandler(this.comboBoxToys_SelectedIndexChanged);
            // 
            // labelToys
            // 
            this.labelToys.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToys.Location = new System.Drawing.Point(334, 38);
            this.labelToys.Name = "labelToys";
            this.labelToys.Size = new System.Drawing.Size(262, 34);
            this.labelToys.TabIndex = 21;
            this.labelToys.Text = "Select Toy :";
            this.labelToys.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonPlay.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.ForeColor = System.Drawing.Color.Black;
            this.buttonPlay.Location = new System.Drawing.Point(340, 336);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(260, 77);
            this.buttonPlay.TabIndex = 20;
            this.buttonPlay.Text = "Let\'s Play";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(367, 139);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // labelData
            // 
            this.labelData.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(525, 150);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(210, 142);
            this.labelData.TabIndex = 26;
            this.labelData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(23, 24);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 28;
            this.buttonBack.Text = "< Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormSelectToys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1008, 582);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.linkLabelBuy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxToys);
            this.Controls.Add(this.labelToys);
            this.Controls.Add(this.buttonPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSelectToys";
            this.Text = "FormSelection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSelectToys_FormClosing);
            this.Load += new System.EventHandler(this.FormSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelBuy;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxToys;
        public System.Windows.Forms.Label labelToys;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Button buttonBack;
    }
}