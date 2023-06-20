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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.radioButtonCat = new System.Windows.Forms.RadioButton();
            this.radioButtonFish = new System.Windows.Forms.RadioButton();
            this.radioButtonChameleon = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(352, 354);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.Text = "Let\'s Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // radioButtonCat
            // 
            this.radioButtonCat.AutoSize = true;
            this.radioButtonCat.Location = new System.Drawing.Point(341, 189);
            this.radioButtonCat.Name = "radioButtonCat";
            this.radioButtonCat.Size = new System.Drawing.Size(85, 17);
            this.radioButtonCat.TabIndex = 2;
            this.radioButtonCat.TabStop = true;
            this.radioButtonCat.Text = "radioButton1";
            this.radioButtonCat.UseVisualStyleBackColor = true;
            // 
            // radioButtonFish
            // 
            this.radioButtonFish.AutoSize = true;
            this.radioButtonFish.Location = new System.Drawing.Point(450, 189);
            this.radioButtonFish.Name = "radioButtonFish";
            this.radioButtonFish.Size = new System.Drawing.Size(85, 17);
            this.radioButtonFish.TabIndex = 3;
            this.radioButtonFish.TabStop = true;
            this.radioButtonFish.Text = "radioButton2";
            this.radioButtonFish.UseVisualStyleBackColor = true;
            // 
            // radioButtonChameleon
            // 
            this.radioButtonChameleon.AutoSize = true;
            this.radioButtonChameleon.Location = new System.Drawing.Point(564, 189);
            this.radioButtonChameleon.Name = "radioButtonChameleon";
            this.radioButtonChameleon.Size = new System.Drawing.Size(85, 17);
            this.radioButtonChameleon.TabIndex = 4;
            this.radioButtonChameleon.TabStop = true;
            this.radioButtonChameleon.Text = "radioButton3";
            this.radioButtonChameleon.UseVisualStyleBackColor = true;
            // 
            // FormSelectPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonChameleon);
            this.Controls.Add(this.radioButtonFish);
            this.Controls.Add(this.radioButtonCat);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.label1);
            this.Name = "FormSelectPlayer";
            this.Text = "FormSelectPlayer";
            this.Load += new System.EventHandler(this.FormSelectPlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.RadioButton radioButtonCat;
        private System.Windows.Forms.RadioButton radioButtonFish;
        private System.Windows.Forms.RadioButton radioButtonChameleon;
    }
}