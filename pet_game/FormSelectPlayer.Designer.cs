namespace pet_game
{
    partial class FormSelectPlayer
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
            this.labelPlayer = new System.Windows.Forms.Label();
            this.comboBoxPlayer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelClickHere = new System.Windows.Forms.LinkLabel();
            this.pictureBoxPlay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPlayer
            // 
            this.labelPlayer.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer.Location = new System.Drawing.Point(342, 107);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(262, 34);
            this.labelPlayer.TabIndex = 5;
            this.labelPlayer.Text = "Select Player :";
            this.labelPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxPlayer
            // 
            this.comboBoxPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlayer.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPlayer.FormattingEnabled = true;
            this.comboBoxPlayer.Location = new System.Drawing.Point(344, 152);
            this.comboBoxPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPlayer.Name = "comboBoxPlayer";
            this.comboBoxPlayer.Size = new System.Drawing.Size(261, 38);
            this.comboBoxPlayer.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 34);
            this.label1.TabIndex = 13;
            this.label1.Text = "New Player?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabelClickHere
            // 
            this.linkLabelClickHere.AutoSize = true;
            this.linkLabelClickHere.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelClickHere.Location = new System.Drawing.Point(520, 370);
            this.linkLabelClickHere.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelClickHere.Name = "linkLabelClickHere";
            this.linkLabelClickHere.Size = new System.Drawing.Size(125, 31);
            this.linkLabelClickHere.TabIndex = 14;
            this.linkLabelClickHere.TabStop = true;
            this.linkLabelClickHere.Text = "Click Here";
            this.linkLabelClickHere.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelClickHere_LinkClicked);
            // 
            // pictureBoxPlay
            // 
            this.pictureBoxPlay.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlay.BackgroundImage = global::pet_game.Properties.Resources.Button_Play;
            this.pictureBoxPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPlay.Location = new System.Drawing.Point(378, 249);
            this.pictureBoxPlay.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxPlay.Name = "pictureBoxPlay";
            this.pictureBoxPlay.Size = new System.Drawing.Size(187, 111);
            this.pictureBoxPlay.TabIndex = 30;
            this.pictureBoxPlay.TabStop = false;
            this.pictureBoxPlay.Click += new System.EventHandler(this.pictureBoxPlay_Click);
            this.pictureBoxPlay.MouseLeave += new System.EventHandler(this.pictureBoxPlay_MouseLeave);
            this.pictureBoxPlay.MouseHover += new System.EventHandler(this.pictureBoxPlay_MouseHover);
            // 
            // FormSelectPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::pet_game.Properties.Resources.sunsetbackground;
            this.ClientSize = new System.Drawing.Size(1008, 580);
            this.Controls.Add(this.pictureBoxPlay);
            this.Controls.Add(this.linkLabelClickHere);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPlayer);
            this.Controls.Add(this.labelPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSelectPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSelectPlayer";
            this.Load += new System.EventHandler(this.FormSelectPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.ComboBox comboBoxPlayer;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelClickHere;
        private System.Windows.Forms.PictureBox pictureBoxPlay;
    }
}