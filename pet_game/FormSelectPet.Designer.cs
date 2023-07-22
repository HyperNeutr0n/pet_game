
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
            this.buttonPlay = new System.Windows.Forms.Button();
            this.labelEnvirontment = new System.Windows.Forms.Label();
            this.pictureBoxSelection = new System.Windows.Forms.PictureBox();
            this.buttonL = new System.Windows.Forms.Button();
            this.buttonR = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelection)).BeginInit();
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
            this.comboBoxEnvironment.Location = new System.Drawing.Point(490, 395);
            this.comboBoxEnvironment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxEnvironment.Name = "comboBoxEnvironment";
            this.comboBoxEnvironment.Size = new System.Drawing.Size(197, 38);
            this.comboBoxEnvironment.TabIndex = 22;
            // 
            // textBoxPetName
            // 
            this.textBoxPetName.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPetName.Location = new System.Drawing.Point(490, 357);
            this.textBoxPetName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPetName.Name = "textBoxPetName";
            this.textBoxPetName.Size = new System.Drawing.Size(239, 37);
            this.textBoxPetName.TabIndex = 20;
            // 
            // labelPetName
            // 
            this.labelPetName.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPetName.Location = new System.Drawing.Point(237, 357);
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
            this.labelPlayerName.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerName.Location = new System.Drawing.Point(237, 44);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(262, 34);
            this.labelPlayerName.TabIndex = 15;
            this.labelPlayerName.Text = "Enter Player Name :";
            this.labelPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonPlay.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.ForeColor = System.Drawing.Color.Black;
            this.buttonPlay.Location = new System.Drawing.Point(353, 456);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(259, 79);
            this.buttonPlay.TabIndex = 13;
            this.buttonPlay.Text = "Let\'s Play";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // labelEnvirontment
            // 
            this.labelEnvirontment.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnvirontment.Location = new System.Drawing.Point(237, 391);
            this.labelEnvirontment.Name = "labelEnvirontment";
            this.labelEnvirontment.Size = new System.Drawing.Size(222, 34);
            this.labelEnvirontment.TabIndex = 21;
            this.labelEnvirontment.Text = "Environment :";
            this.labelEnvirontment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxSelection
            // 
            this.pictureBoxSelection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSelection.Location = new System.Drawing.Point(345, 96);
            this.pictureBoxSelection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxSelection.Name = "pictureBoxSelection";
            this.pictureBoxSelection.Size = new System.Drawing.Size(286, 244);
            this.pictureBoxSelection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSelection.TabIndex = 23;
            this.pictureBoxSelection.TabStop = false;
            // 
            // buttonL
            // 
            this.buttonL.Location = new System.Drawing.Point(228, 182);
            this.buttonL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(80, 75);
            this.buttonL.TabIndex = 24;
            this.buttonL.Text = "L";
            this.buttonL.UseVisualStyleBackColor = true;
            this.buttonL.Click += new System.EventHandler(this.buttonL_Click);
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(665, 182);
            this.buttonR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(80, 75);
            this.buttonR.TabIndex = 25;
            this.buttonR.Text = "R";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
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
            // FormSelectPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1008, 582);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.buttonL);
            this.Controls.Add(this.pictureBoxSelection);
            this.Controls.Add(this.comboBoxEnvironment);
            this.Controls.Add(this.textBoxPetName);
            this.Controls.Add(this.labelPetName);
            this.Controls.Add(this.textBoxPlayerName);
            this.Controls.Add(this.labelPlayerName);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.labelEnvirontment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSelectPet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSelectPet";
            this.Load += new System.EventHandler(this.FormSelectPet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEnvironment;
        private System.Windows.Forms.TextBox textBoxPetName;
        public System.Windows.Forms.Label labelPetName;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        public System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.Button buttonPlay;
        public System.Windows.Forms.Label labelEnvirontment;
        private System.Windows.Forms.PictureBox pictureBoxSelection;
        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Button buttonBack;
    }
}