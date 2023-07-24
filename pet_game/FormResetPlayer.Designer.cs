namespace pet_game
{
    partial class FormResetPlayer
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
            this.pictureBoxDelete = new System.Windows.Forms.PictureBox();
            this.comboBoxPlayer = new System.Windows.Forms.ComboBox();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDelete
            // 
            this.pictureBoxDelete.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDelete.BackgroundImage = global::pet_game.Properties.Resources.Button_Play;
            this.pictureBoxDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDelete.Location = new System.Drawing.Point(380, 286);
            this.pictureBoxDelete.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxDelete.Name = "pictureBoxDelete";
            this.pictureBoxDelete.Size = new System.Drawing.Size(187, 111);
            this.pictureBoxDelete.TabIndex = 33;
            this.pictureBoxDelete.TabStop = false;
            this.pictureBoxDelete.Click += new System.EventHandler(this.pictureBoxDelete_Click);
            // 
            // comboBoxPlayer
            // 
            this.comboBoxPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlayer.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPlayer.FormattingEnabled = true;
            this.comboBoxPlayer.Location = new System.Drawing.Point(346, 189);
            this.comboBoxPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPlayer.Name = "comboBoxPlayer";
            this.comboBoxPlayer.Size = new System.Drawing.Size(261, 38);
            this.comboBoxPlayer.TabIndex = 32;
            // 
            // labelPlayer
            // 
            this.labelPlayer.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer.Location = new System.Drawing.Point(309, 140);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(337, 34);
            this.labelPlayer.TabIndex = 31;
            this.labelPlayer.Text = "Select Player to Reset:";
            this.labelPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(31, 28);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 34;
            this.buttonBack.Text = "< Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormResetPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pet_game.Properties.Resources.sunsetbackground;
            this.ClientSize = new System.Drawing.Size(1008, 580);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.pictureBoxDelete);
            this.Controls.Add(this.comboBoxPlayer);
            this.Controls.Add(this.labelPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormResetPlayer";
            this.Text = "FormResetPlayer";
            this.Load += new System.EventHandler(this.FormResetPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDelete;
        private System.Windows.Forms.ComboBox comboBoxPlayer;
        public System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Button buttonBack;
    }
}