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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelData = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBoxUse = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUse)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelBuy
            // 
            this.linkLabelBuy.AutoSize = true;
            this.linkLabelBuy.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelBuy.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelBuy.Location = new System.Drawing.Point(418, 500);
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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 432);
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
            this.comboBoxToys.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxToys.Name = "comboBoxToys";
            this.comboBoxToys.Size = new System.Drawing.Size(261, 38);
            this.comboBoxToys.TabIndex = 22;
            this.comboBoxToys.SelectedIndexChanged += new System.EventHandler(this.comboBoxToys_SelectedIndexChanged);
            // 
            // labelToys
            // 
            this.labelToys.BackColor = System.Drawing.Color.Transparent;
            this.labelToys.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToys.Location = new System.Drawing.Point(334, 38);
            this.labelToys.Name = "labelToys";
            this.labelToys.Size = new System.Drawing.Size(262, 34);
            this.labelToys.TabIndex = 21;
            this.labelToys.Text = "Select Toy :";
            this.labelToys.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(367, 139);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // labelData
            // 
            this.labelData.BackColor = System.Drawing.Color.Transparent;
            this.labelData.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(573, 155);
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
            // pictureBoxUse
            // 
            this.pictureBoxUse.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUse.BackgroundImage = global::pet_game.Properties.Resources.Button_Use;
            this.pictureBoxUse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxUse.Location = new System.Drawing.Point(374, 319);
            this.pictureBoxUse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxUse.Name = "pictureBoxUse";
            this.pictureBoxUse.Size = new System.Drawing.Size(187, 111);
            this.pictureBoxUse.TabIndex = 29;
            this.pictureBoxUse.TabStop = false;
            this.pictureBoxUse.Click += new System.EventHandler(this.pictureBoxUse_Click);
            this.pictureBoxUse.MouseLeave += new System.EventHandler(this.pictureBoxUse_MouseLeave);
            this.pictureBoxUse.MouseHover += new System.EventHandler(this.pictureBoxUse_MouseHover);
            // 
            // FormSelectToys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::pet_game.Properties.Resources.dawnbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 580);
            this.Controls.Add(this.pictureBoxUse);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.linkLabelBuy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxToys);
            this.Controls.Add(this.labelToys);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormSelectToys";
            this.Text = "FormSelection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSelectToys_FormClosing);
            this.Load += new System.EventHandler(this.FormSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelBuy;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxToys;
        public System.Windows.Forms.Label labelToys;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBoxUse;
    }
}