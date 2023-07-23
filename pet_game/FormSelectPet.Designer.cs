
namespace pet_game
{
    partial class FormSelectPet
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
            this.comboBoxEnvironment = new System.Windows.Forms.ComboBox();
            this.textBoxPetName = new System.Windows.Forms.TextBox();
            this.labelPetName = new System.Windows.Forms.Label();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.labelEnvirontment = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBoxLeft = new System.Windows.Forms.PictureBox();
            this.pictureBoxRight = new System.Windows.Forms.PictureBox();
            this.pictureBoxSelection = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxEnvironment
            // 
            this.comboBoxEnvironment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEnvironment.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEnvironment.FormattingEnabled = true;
            this.comboBoxEnvironment.Items.AddRange(new object[] {
            "River",
            "Sea",
            "Pond"});
            this.comboBoxEnvironment.Location = new System.Drawing.Point(490, 409);
            this.comboBoxEnvironment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxEnvironment.Name = "comboBoxEnvironment";
            this.comboBoxEnvironment.Size = new System.Drawing.Size(197, 38);
            this.comboBoxEnvironment.TabIndex = 22;
            // 
            // textBoxPetName
            // 
            this.textBoxPetName.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPetName.Location = new System.Drawing.Point(490, 370);
            this.textBoxPetName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPetName.Name = "textBoxPetName";
            this.textBoxPetName.Size = new System.Drawing.Size(239, 37);
            this.textBoxPetName.TabIndex = 20;
            // 
            // labelPetName
            // 
            this.labelPetName.BackColor = System.Drawing.Color.Transparent;
            this.labelPetName.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPetName.Location = new System.Drawing.Point(237, 370);
            this.labelPetName.Name = "labelPetName";
            this.labelPetName.Size = new System.Drawing.Size(262, 34);
            this.labelPetName.TabIndex = 19;
            this.labelPetName.Text = "Enter Pet Name :";
            this.labelPetName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlayerName.Location = new System.Drawing.Point(490, 46);
            this.textBoxPlayerName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(239, 37);
            this.textBoxPlayerName.TabIndex = 18;
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayerName.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerName.Location = new System.Drawing.Point(237, 44);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(262, 34);
            this.labelPlayerName.TabIndex = 15;
            this.labelPlayerName.Text = "Enter Player Name :";
            this.labelPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEnvirontment
            // 
            this.labelEnvirontment.BackColor = System.Drawing.Color.Transparent;
            this.labelEnvirontment.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnvirontment.Location = new System.Drawing.Point(237, 405);
            this.labelEnvirontment.Name = "labelEnvirontment";
            this.labelEnvirontment.Size = new System.Drawing.Size(222, 34);
            this.labelEnvirontment.TabIndex = 21;
            this.labelEnvirontment.Text = "Environment :";
            this.labelEnvirontment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(13, 25);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 26;
            this.buttonBack.Text = "< Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // pictureBoxLeft
            // 
            this.pictureBoxLeft.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLeft.BackgroundImage = global::pet_game.Properties.Resources.Button_Left;
            this.pictureBoxLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLeft.Location = new System.Drawing.Point(207, 170);
            this.pictureBoxLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxLeft.Name = "pictureBoxLeft";
            this.pictureBoxLeft.Size = new System.Drawing.Size(117, 116);
            this.pictureBoxLeft.TabIndex = 28;
            this.pictureBoxLeft.TabStop = false;
            this.pictureBoxLeft.Click += new System.EventHandler(this.pictureBoxLeft_Click);
            this.pictureBoxLeft.MouseLeave += new System.EventHandler(this.pictureBoxLeft_MouseLeave);
            this.pictureBoxLeft.MouseHover += new System.EventHandler(this.pictureBoxLeft_MouseHover);
            // 
            // pictureBoxRight
            // 
            this.pictureBoxRight.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRight.BackgroundImage = global::pet_game.Properties.Resources.Button_Right;
            this.pictureBoxRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxRight.Location = new System.Drawing.Point(661, 170);
            this.pictureBoxRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxRight.Name = "pictureBoxRight";
            this.pictureBoxRight.Size = new System.Drawing.Size(117, 116);
            this.pictureBoxRight.TabIndex = 27;
            this.pictureBoxRight.TabStop = false;
            this.pictureBoxRight.Click += new System.EventHandler(this.pictureBoxRight_Click);
            this.pictureBoxRight.MouseLeave += new System.EventHandler(this.pictureBoxRight_MouseLeave);
            this.pictureBoxRight.MouseHover += new System.EventHandler(this.pictureBoxRight_MouseHover);
            // 
            // pictureBoxSelection
            // 
            this.pictureBoxSelection.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSelection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSelection.Location = new System.Drawing.Point(345, 96);
            this.pictureBoxSelection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxSelection.Name = "pictureBoxSelection";
            this.pictureBoxSelection.Size = new System.Drawing.Size(286, 244);
            this.pictureBoxSelection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSelection.TabIndex = 23;
            this.pictureBoxSelection.TabStop = false;
            // 
            // pictureBoxPlay
            // 
            this.pictureBoxPlay.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlay.BackgroundImage = global::pet_game.Properties.Resources.Button_Play;
            this.pictureBoxPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPlay.Location = new System.Drawing.Point(401, 447);
            this.pictureBoxPlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxPlay.Name = "pictureBoxPlay";
            this.pictureBoxPlay.Size = new System.Drawing.Size(187, 111);
            this.pictureBoxPlay.TabIndex = 29;
            this.pictureBoxPlay.TabStop = false;
            this.pictureBoxPlay.Click += new System.EventHandler(this.pictureBoxPlay_Click);
            this.pictureBoxPlay.MouseLeave += new System.EventHandler(this.pictureBoxPlay_MouseLeave);
            this.pictureBoxPlay.MouseHover += new System.EventHandler(this.pictureBoxPlay_MouseHover);
            // 
            // FormSelectPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::pet_game.Properties.Resources.sunsetbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 580);
            this.Controls.Add(this.pictureBoxPlay);
            this.Controls.Add(this.pictureBoxLeft);
            this.Controls.Add(this.pictureBoxRight);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.pictureBoxSelection);
            this.Controls.Add(this.comboBoxEnvironment);
            this.Controls.Add(this.textBoxPetName);
            this.Controls.Add(this.labelPetName);
            this.Controls.Add(this.textBoxPlayerName);
            this.Controls.Add(this.labelPlayerName);
            this.Controls.Add(this.labelEnvirontment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSelectPet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSelectPet";
            this.Load += new System.EventHandler(this.FormSelectPet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEnvironment;
        private System.Windows.Forms.TextBox textBoxPetName;
        public System.Windows.Forms.Label labelPetName;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        public System.Windows.Forms.Label labelPlayerName;
        public System.Windows.Forms.Label labelEnvirontment;
        private System.Windows.Forms.PictureBox pictureBoxSelection;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBoxRight;
        private System.Windows.Forms.PictureBox pictureBoxLeft;
        private System.Windows.Forms.PictureBox pictureBoxPlay;
    }
}