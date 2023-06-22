
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
            this.radioButtonChameleon = new System.Windows.Forms.RadioButton();
            this.radioButtonFish = new System.Windows.Forms.RadioButton();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.radioButtonCat = new System.Windows.Forms.RadioButton();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.labelEnvirontment = new System.Windows.Forms.Label();
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
            this.comboBoxEnvironment.Location = new System.Drawing.Point(919, 496);
            this.comboBoxEnvironment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxEnvironment.Name = "comboBoxEnvironment";
            this.comboBoxEnvironment.Size = new System.Drawing.Size(261, 46);
            this.comboBoxEnvironment.TabIndex = 22;
            // 
            // textBoxPetName
            // 
            this.textBoxPetName.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPetName.Location = new System.Drawing.Point(349, 495);
            this.textBoxPetName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPetName.Name = "textBoxPetName";
            this.textBoxPetName.Size = new System.Drawing.Size(317, 45);
            this.textBoxPetName.TabIndex = 20;
            // 
            // labelPetName
            // 
            this.labelPetName.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPetName.Location = new System.Drawing.Point(12, 495);
            this.labelPetName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPetName.Name = "labelPetName";
            this.labelPetName.Size = new System.Drawing.Size(350, 42);
            this.labelPetName.TabIndex = 19;
            this.labelPetName.Text = "Enter Pet Name :";
            this.labelPetName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlayerName.Location = new System.Drawing.Point(349, 22);
            this.textBoxPlayerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(317, 45);
            this.textBoxPlayerName.TabIndex = 18;
            // 
            // radioButtonChameleon
            // 
            this.radioButtonChameleon.BackgroundImage = global::pet_game.Properties.Resources.chameleon_happy;
            this.radioButtonChameleon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonChameleon.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonChameleon.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonChameleon.Location = new System.Drawing.Point(836, 150);
            this.radioButtonChameleon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonChameleon.Name = "radioButtonChameleon";
            this.radioButtonChameleon.Size = new System.Drawing.Size(343, 258);
            this.radioButtonChameleon.TabIndex = 17;
            this.radioButtonChameleon.TabStop = true;
            this.radioButtonChameleon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonChameleon.UseVisualStyleBackColor = true;
            this.radioButtonChameleon.CheckedChanged += new System.EventHandler(this.radioButtonChameleon_CheckedChanged);
            // 
            // radioButtonFish
            // 
            this.radioButtonFish.BackgroundImage = global::pet_game.Properties.Resources.fish_happy;
            this.radioButtonFish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonFish.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonFish.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFish.Location = new System.Drawing.Point(428, 150);
            this.radioButtonFish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonFish.Name = "radioButtonFish";
            this.radioButtonFish.Size = new System.Drawing.Size(343, 258);
            this.radioButtonFish.TabIndex = 16;
            this.radioButtonFish.TabStop = true;
            this.radioButtonFish.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonFish.UseVisualStyleBackColor = true;
            this.radioButtonFish.CheckedChanged += new System.EventHandler(this.radioButtonFish_CheckedChanged);
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerName.Location = new System.Drawing.Point(12, 21);
            this.labelPlayerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(350, 42);
            this.labelPlayerName.TabIndex = 15;
            this.labelPlayerName.Text = "Enter Player Name :";
            this.labelPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonCat
            // 
            this.radioButtonCat.BackgroundImage = global::pet_game.Properties.Resources.cat_happy;
            this.radioButtonCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonCat.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonCat.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCat.Location = new System.Drawing.Point(70, 150);
            this.radioButtonCat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonCat.Name = "radioButtonCat";
            this.radioButtonCat.Size = new System.Drawing.Size(343, 258);
            this.radioButtonCat.TabIndex = 14;
            this.radioButtonCat.TabStop = true;
            this.radioButtonCat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonCat.UseVisualStyleBackColor = true;
            this.radioButtonCat.CheckedChanged += new System.EventHandler(this.radioButtonCat_CheckedChanged);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonPlay.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.ForeColor = System.Drawing.Color.Black;
            this.buttonPlay.Location = new System.Drawing.Point(510, 570);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(295, 82);
            this.buttonPlay.TabIndex = 13;
            this.buttonPlay.Text = "Let\'s Play";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // labelEnvirontment
            // 
            this.labelEnvirontment.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnvirontment.Location = new System.Drawing.Point(672, 495);
            this.labelEnvirontment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnvirontment.Name = "labelEnvirontment";
            this.labelEnvirontment.Size = new System.Drawing.Size(296, 42);
            this.labelEnvirontment.TabIndex = 21;
            this.labelEnvirontment.Text = "Environment :";
            this.labelEnvirontment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSelectPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1256, 671);
            this.Controls.Add(this.comboBoxEnvironment);
            this.Controls.Add(this.textBoxPetName);
            this.Controls.Add(this.labelPetName);
            this.Controls.Add(this.textBoxPlayerName);
            this.Controls.Add(this.radioButtonChameleon);
            this.Controls.Add(this.radioButtonFish);
            this.Controls.Add(this.labelPlayerName);
            this.Controls.Add(this.radioButtonCat);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.labelEnvirontment);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormSelectPet";
            this.Text = "FormSelectPet";
            this.Load += new System.EventHandler(this.FormSelectPet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEnvironment;
        private System.Windows.Forms.TextBox textBoxPetName;
        public System.Windows.Forms.Label labelPetName;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.RadioButton radioButtonChameleon;
        private System.Windows.Forms.RadioButton radioButtonFish;
        public System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.RadioButton radioButtonCat;
        private System.Windows.Forms.Button buttonPlay;
        public System.Windows.Forms.Label labelEnvirontment;
    }
}