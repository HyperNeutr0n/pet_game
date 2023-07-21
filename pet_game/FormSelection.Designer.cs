namespace pet_game
{
    partial class FormSelection
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxToys = new System.Windows.Forms.ComboBox();
            this.labelToys = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(221, 745);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(165, 45);
            this.linkLabel1.TabIndex = 24;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Buy Here";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 620);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 105);
            this.label1.TabIndex = 23;
            this.label1.Text = "Don\'t have or need a new toy";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxToys
            // 
            this.comboBoxToys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxToys.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxToys.FormattingEnabled = true;
            this.comboBoxToys.Location = new System.Drawing.Point(101, 110);
            this.comboBoxToys.Name = "comboBoxToys";
            this.comboBoxToys.Size = new System.Drawing.Size(390, 53);
            this.comboBoxToys.TabIndex = 22;
            this.comboBoxToys.SelectedIndexChanged += new System.EventHandler(this.comboBoxToys_SelectedIndexChanged);
            // 
            // labelToys
            // 
            this.labelToys.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToys.Location = new System.Drawing.Point(98, 39);
            this.labelToys.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelToys.Name = "labelToys";
            this.labelToys.Size = new System.Drawing.Size(393, 52);
            this.labelToys.TabIndex = 21;
            this.labelToys.Text = "Select Toy :";
            this.labelToys.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonPlay.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.ForeColor = System.Drawing.Color.Black;
            this.buttonPlay.Location = new System.Drawing.Point(106, 497);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(390, 118);
            this.buttonPlay.TabIndex = 20;
            this.buttonPlay.Text = "Let\'s Play";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(59, 189);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 270);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // labelData
            // 
            this.labelData.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(384, 211);
            this.labelData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(315, 218);
            this.labelData.TabIndex = 26;
            this.labelData.Text = "Don\'t have or need a new toy";
            this.labelData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(883, 905);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxToys);
            this.Controls.Add(this.labelToys);
            this.Controls.Add(this.buttonPlay);
            this.Name = "FormSelection";
            this.Text = "FormSelection";
            this.Load += new System.EventHandler(this.FormSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxToys;
        public System.Windows.Forms.Label labelToys;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label labelData;
    }
}